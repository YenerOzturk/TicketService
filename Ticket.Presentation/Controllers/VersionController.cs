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
    public class VersionController : BaseController
    {
        private IWebHostEnvironment _hostEnvironment;

        public VersionController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(int? id)
        {
            VersionViewModel retval = new VersionViewModel();

            if (id != null)
            {
                string url = $"Version/get-version-by-Id?Id={id}";

                VersionModel model = await HttpClientHelper.SendGetRequest<VersionModel>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

                retval.CardCode = model.CardCode;
                retval.Currency = model.Currency;
                retval.EndDate = model.EndDate.ToString("yyyy-MM-dd"); ;
                retval.Id = model.Id;
                retval.Installment = model.Installment;
                retval.Price = model.Price;
                retval.ProductId = model.ProductId;
                retval.StartDate = model.StartDate.ToString("yyyy-MM-dd");
                retval.Attachment = model.Attachment;
                retval.Note = model.Note;
            }
            else
            {
                retval.StartDate = DateTime.Today.ToString("yyyy-MM-dd");
                retval.EndDate = DateTime.Today.ToString("yyyy-MM-dd");
            }

            return View(retval);
        }

        public IActionResult VersionList()
        {
            return View();
        }

        public async Task<IActionResult> GetVersions(JqueryDataTableParam param)
        {

            string url = $"Version/get-all-versions";

            string urlParam = string.Empty;


            if (!string.IsNullOrEmpty(param.cardCode))
            {
                urlParam += $"&CardCode={param.cardCode}";
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<VersionListResultModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        [HttpPost]
        public async Task<IActionResult> SaveVersion(VersionModel model)
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
                await HttpClientHelper.SendPostRequest(model, "Version/add-new-version", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }
            else
            {
                await HttpClientHelper.SendPostRequest(model, "Version/update-version", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            return Ok();
        }

        public async Task<IActionResult> DeleteVersion(int id)
        {

            VersionModel model = new VersionModel() { Id = id };

            await HttpClientHelper.SendPostRequest(model, "Version/delete-version", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok();
        }
    }
}
