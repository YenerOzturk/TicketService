using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;
using Ticket.Presentation.ViewModels;

namespace Ticket.Presentation.Controllers
{
    [Authorize]
    public class TicketController : BaseController
    {
        private IWebHostEnvironment _hostEnvironment;


        public TicketController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> GetTickets(JqueryDataTableParam param)
        {
            string url = $"Ticket/get-Tickets";

            string urlParam = string.Empty;


            if (param.cardCodes != null)
            {
                foreach (var item in param.cardCodes)
                {
                    urlParam += $"&CardCodes={item}";
                }
            }


            if (param.id > 0)
            {
                urlParam += $"&Id={param.id}";
            }

            if (param.userIds != null)
            {
                foreach (var item in param.userIds)
                {
                    urlParam += $"&UserIds={item}";
                }
            }


            if (!string.IsNullOrEmpty(param.description))
            {
                urlParam += $"&Description={param.description}";
            }

            if (param.statuList != null)
            {
                foreach (var item in param.statuList)
                {
                    urlParam += $"&Status={item}";
                }
            }


            if (param.supportType > 0)
            {
                urlParam += $"&SupportType={param.supportType}";
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }


            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<TicketListResultModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        public async Task<IActionResult> GetSubTickets(int ticketId)
        {
            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<SubTicketViewModel>>($"Ticket/get-subTicketsByTicketId?TicketId={ticketId}", CookieHelper.GetToken(Request, "oaut.Cookie"));

            string html = SubTicketHtml.Html;
            string retval = string.Empty;

            string statusName = string.Empty;
            string statusColor = string.Empty;

            foreach (var repo in repositories.ToList())
            {

                if (repo.Status == 1)
                {
                    statusName = "Açık";
                    statusColor = "success";
                }
                else if (repo.Status == 3)
                {
                    statusName = "Yazılımda";
                    statusColor = "info";
                }
                else
                {
                    statusName = "Kapalı";
                    statusColor = "danger";
                }


                string attachment = string.Empty;

                if (!string.IsNullOrEmpty(repo.Attachment))
                {
                    attachment = $"<div class=\"mt-2\"><b>Eklenti:</b><a href=\"{repo.Attachment}\">{repo.Attachment}</a></div>";
                }

                retval += html.Replace("[Attachment]", attachment).Replace("{StartDate}", repo.StartDate.ToString("dd.MM.yyyy HH:mm")).Replace("{EndDate}", repo.EndDate.ToString("dd.MM.yyyy HH:mm")).Replace("{Description}", repo.Description).Replace("{UserName}", repo.UserName).Replace("{Status}", statusName).Replace("{StatusColor}", statusColor).Replace("{id}", repo.Id.ToString()).Replace("{ticketId}", ticketId.ToString());

            }

            return Ok(retval);
        }

        public async Task<IActionResult> SaveTicket(TicketModel model)
        {
            int result = 0;

            if (model.File != null)
            {
                var filePath = Path.Combine(_hostEnvironment.WebRootPath, "attachments/" + model.File.FileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await model.File.CopyToAsync(stream);
                }

                model.Attachment = "/attachments/" + model.File.FileName;
            }


            if (model.Id == 0)
            {
                model.Status = 1;
                model.CreateDate = DateTime.Now;

                if (model.UserId == 0)
                {
                    var userMail = User.FindFirstValue(ClaimTypes.Name);

                    model.UserId = UserHelper.GetByEmailAsync(userMail, CookieHelper.GetToken(Request, "oaut.Cookie")).Id;

                }

                result = await HttpClientHelper.SendPostRequest(model, "Ticket/create-ticket", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }
            else
            {
                result = await HttpClientHelper.SendPostRequest(model, "Ticket/update-ticket", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            return Ok(result);
        }

        public async Task<IActionResult> SaveSubTicket(SubTicketModel model)
        {

            if (model.File != null)
            {
                var filePath = Path.Combine(_hostEnvironment.WebRootPath, "attachments/" + model.File.FileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await model.File.CopyToAsync(stream);
                }

                model.Attachment = "/attachments/" + model.File.FileName;
            }

            if (model.AllDay)
            {
                model.StartDate = new DateTime(model.StartDate.Year, model.StartDate.Month, model.StartDate.Day, 9, 0, 0);
                model.EndDate = new DateTime(model.EndDate.Year, model.EndDate.Month, model.EndDate.Day, 18, 0, 0);
            }

            if (model.Id == 0)
            {
                await HttpClientHelper.SendPostRequest(model, "Ticket/create-subTicket", CookieHelper.GetToken(Request, "oaut.Cookie"));

                if (model.CloseTicket)
                {
                    await HttpClientHelper.SendPostRequest(new TicketMailModel() { TicketId = model.TicketId }, "Ticket/send-ticket-mail", CookieHelper.GetToken(Request, "oaut.Cookie"));
                }
            }
            else
            {
                await HttpClientHelper.SendPostRequest(model, "Ticket/update-subTicket", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            


            return Ok("Ok");
        }

        public async Task<IActionResult> GetTicketById(int id)
        {

            string url = $"Ticket/get-by-id?Id={id}";

            var model = await HttpClientHelper.SendGetRequest<TicketModel>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            TicketViewModel retval = new TicketViewModel();

            retval.Billing = model.Billing;
            retval.CardCode = model.CardCode;
            retval.Description = model.Description;
            retval.Id = model.Id;
            retval.ProductId = model.ProductId;
            retval.ProjectId = model.ProjectId;
            retval.Status = model.Status;
            retval.SupportType = model.SupportType;
            retval.UserId = model.UserId;
            retval.CreateDate = model.CreateDate;
            retval.Attachment = model.Attachment;
            retval.EstimatedEndDate = model.EstimatedEndDate;
            retval.TicketLabel = model.TicketLabel;
            retval.Subject = model.Subject;

            return Ok(retval);
        }

        public async Task<IActionResult> GetSubTicket(int id)
        {
            var retval = await HttpClientHelper.SendGetRequest<SubTicketModel>("Ticket/get-subTicketsById?id=" + id, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok(retval);
        }

        public async Task<IActionResult> CompleteSubTicket(SubTicketModel model)
        {
            model.Status = 2;
            await HttpClientHelper.SendPostRequest(model, "Ticket/update-subTicket", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }

        public async Task<IActionResult> DeleteSubTicket(SubTicketModel model)
        {
            await HttpClientHelper.SendPostRequest(model, "Ticket/delete-subTicket", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }

        public async Task<IActionResult> SendMail(TicketMailModel model)
        {
            await HttpClientHelper.SendPostRequest(model, "Ticket/send-ticket-mail", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }

        public async Task<IActionResult> CancelTicket(int ticketId)
        {
            UpdateTicketStatusModel model = new UpdateTicketStatusModel();
            model.Id = ticketId;
            model.Status = 5;

            await HttpClientHelper.SendPostRequest(model, "Ticket/update-ticket-status", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }
    }
}
