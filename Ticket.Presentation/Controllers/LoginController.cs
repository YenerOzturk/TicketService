using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;

namespace Ticket.Presentation.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> Login(UserModel model)
        {
            if (!string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.Password))
            {
                return RedirectToAction("Login");
            }

            string returnUrl = "../../Ticket/TicketList";

            string url = $"Token/new?email={model.Email}&password={model.Password}";

            var token = await HttpClientHelper.SendGetRequest<string>(url, "");

            if (!string.IsNullOrEmpty(token))
            {
                model = await HttpClientHelper.SendGetRequest<UserModel>("User/get-users-by-email?email=" + model.Email, token);

                string role = "User";
                if (model.IsAdmin)
                    role = "Admin";


                CookieHelper.SetToken(Response, "oaut.Cookie", token);

                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, model.Email),
                    new Claim(ClaimTypes.GivenName,model.NameSurname),
                    new Claim(ClaimTypes.Role,role),
                    new Claim(ClaimTypes.Sid,model.Id.ToString()),
                    new Claim(ClaimTypes.UserData,model.CardCode)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.Now.AddDays(7)
                });

                if (model.CardCode != "C0001")
                {
                    returnUrl = "../../Customer/CustomerTickets";
                }
            }

            return Ok(returnUrl);
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
