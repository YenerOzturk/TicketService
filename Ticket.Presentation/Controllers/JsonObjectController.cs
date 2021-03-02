using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    [Authorize]
    public class JsonObjectController : Controller
    {
        public async Task<IActionResult> GetProjectsForDropDown(string cardCode, string productId)
        {
            string url = $"Project/get-Projects?CardCode={cardCode}&ProductId={productId}&Status=1";

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<ProjectModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            List<DropDownModel> retval = new List<DropDownModel>();

            retval.Add(new DropDownModel() { Desc = "Proje Bağımsız", Val = -1 });

            foreach (var item in repositories)
            {
                retval.Add(new DropDownModel()
                {

                    Desc = item.ProjectName,
                    Val = item.Id
                });
            }

            return Ok(retval);
        }


        public async Task<IActionResult> GetCustomersForDropDown()
        {
            string url = $"Customer/get-Customers?isActive=true";


            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<CustomerModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            List<DropDownModel> retval = new List<DropDownModel>();

            foreach (var item in repositories)
            {
                retval.Add(new DropDownModel()
                {

                    Desc = item.CardName,
                    Val = item.CardCode
                });
            }

            return Ok(retval);
        }


        public async Task<IActionResult> GetProductsForDropDown()
        {
            string url = $"Product/get-all-products";

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<ProductModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            List<DropDownModel> retval = new List<DropDownModel>();

            foreach (var item in repositories)
            {
                retval.Add(new DropDownModel()
                {

                    Desc = item.ProductName,
                    Val = item.Id
                });
            }

            return Ok(retval);
        }

        public async Task<IActionResult> GetUsersForDropDown(string cardCode)
        {
            if (string.IsNullOrEmpty(cardCode))
                cardCode = "C0001";

            string url = $"User/get-users-by-cardCode?cardCode={cardCode}";

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<UserModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            List<DropDownModel> retval = new List<DropDownModel>();

            foreach (var item in repositories)
            {
                retval.Add(new DropDownModel()
                {

                    Desc = item.NameSurname,
                    Val = item.Id
                });
            }

            return Ok(retval);
        }

        public async Task<IActionResult> GetTicketLabels()
        {
            string url = $"Ticket/get-Labels";

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<string>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok(repositories.ToList());
        }
    }
}
