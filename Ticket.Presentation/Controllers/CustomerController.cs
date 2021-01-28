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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private IWebHostEnvironment _hostEnvironment;

        public CustomerController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(int? id)
        {
            CustomerModel model = new CustomerModel();

            if (id != null)
            {
                string url = $"Customer/get-Customers-by-Id?Id={id}";

                model = await HttpClientHelper.SendGetRequest<CustomerModel>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));
            }


            return View(model);
        }

        public IActionResult CustomerList()
        {
            return View();
        }

        public async Task<IActionResult> GetCustomers(JqueryDataTableParam param)
        {

            string url = $"Customer/get-Customers";

            string urlParam = string.Empty;


            if (!string.IsNullOrEmpty(param.cardCode))
            {
                urlParam += $"&CardCode={param.cardCode}";
            }

            if (!string.IsNullOrEmpty(param.cardName))
            {
                urlParam += $"&CardName={param.cardName}";
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<CustomerModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        public async Task<IActionResult> SaveCustomer(CustomerModel model)
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


            await HttpClientHelper.SendPostRequest(model, "Customer/update-customer", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }
    }
}
