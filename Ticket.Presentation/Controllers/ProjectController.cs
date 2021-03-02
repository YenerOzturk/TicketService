using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;
using Ticket.Presentation.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    [Authorize]
    public class ProjectController : BaseController
    {

        private IWebHostEnvironment _hostEnvironment;


        public ProjectController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ProjectViewModel retval = new ProjectViewModel();

            if (id != null)
            {
                var model = await HttpClientHelper.SendGetRequest<ProjectModel>("Project/get-Project-by-Id?id=" + id, CookieHelper.GetToken(Request, "oaut.Cookie"));

                retval.Attachment = model.Attachment;
                retval.CardCode = model.CardCode;
                retval.Description = model.Description;
                retval.EndDate = model.EndDate.ToString("yyyy-MM-ddTHH:mm:00");
                retval.StartDate = model.StartDate.ToString("yyyy-MM-ddTHH:mm:00");
                retval.ManHour = model.ManHour;
                retval.ProductIds = string.Join(',', model.ProductIds);
                retval.Id = model.Id;
                retval.ProjectName = model.ProjectName;
                retval.Billing = model.Billing;
                retval.ProjectOwners = model.ProjectOwners;
                retval.Status = model.Status;

            }
            else
            {
                retval.EndDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:00");
                retval.StartDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:00");
                retval.Status = 1;
            }

            return View(retval);
        }

        public async Task<IActionResult> GetProjects(JqueryDataTableParam param)
        {

            string url = $"Project/get-Projects";

            string urlParam = string.Empty;


            /*if (!string.IsNullOrEmpty(param.cardCode))
            {
                urlParam += $"&CardCode={param.cardCode}";
            }

            if (!string.IsNullOrEmpty(param.productId))
            {
                urlParam += $"&ProductId={param.productId}";
            }

            urlParam += $"&StartDate={param.startDate}&EndDate={param.endDate}";*/

            if (param.statuList != null)
            {
                foreach (var item in param.statuList)
                {
                    urlParam += $"&Status={item}";
                }
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<ProjectListResultModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        public async Task<IActionResult> GetProjectById(int Id)
        {
            string url = $"Project/get-Project-by-Id?Id={Id}";

            var result = await HttpClientHelper.SendGetRequest<ProjectModel>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));


            ProjectViewModel retval = new ProjectViewModel();
            retval.EndDate = result.EndDate.ToString("yyyy-MM-ddTHH:mm:00");
            retval.StartDate = result.StartDate.ToString("yyyy-MM-ddTHH:mm:00");
            retval.Attachment = result.Attachment;
            retval.Billing = result.Billing;
            retval.CardCode = result.CardCode;
            retval.Description = result.Description;
            retval.Id = result.Id;
            retval.ManHour = result.ManHour;
            retval.ProductIds = string.Join(',', result.ProductIds);
            retval.ProjectName = result.ProjectName;
            retval.ProjectOwners = result.ProjectOwners;
            retval.Status = result.Status;

            return Ok(retval);
        }

        public async Task<IActionResult> SaveProject(ProjectModel model)
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

            if (model.Id == 0)
            {
                await HttpClientHelper.SendPostRequest(model, "Project/create-project", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }
            else
            {
                await HttpClientHelper.SendPostRequest(model, "Project/update-project", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            return Ok("Ok");
        }

        public async Task<IActionResult> DeleteProject(ProjectModel model)
        {
            await HttpClientHelper.SendPostRequest(model, "Project/delete-project", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }

        public IActionResult ProjectList()
        {
            return View();
        }
    }
}
