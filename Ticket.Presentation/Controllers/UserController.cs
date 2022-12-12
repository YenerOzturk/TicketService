using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index(int? id)
        {
            UserModel model = new UserModel();

            if (id != null)
            {
                model = await HttpClientHelper.SendGetRequest<UserModel>("User/get-user-by-Id?id=" + id, CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            return View(model);
        }


        public async Task<IActionResult> GetUsers(JqueryDataTableParam param)
        {

            string url = $"User/get-all-users";

            string urlParam = string.Empty;


            if (!string.IsNullOrEmpty(param.cardName))
            {
                urlParam += $"&CardName={param.cardName}";
            }

            if (!string.IsNullOrEmpty(param.nameSurname))
            {
                urlParam += $"&NameSurname={param.nameSurname}";
            }

            if (!string.IsNullOrEmpty(param.email))
            {
                urlParam += $"&Email={param.email}";
            }

            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<UserModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        public async Task<IActionResult> SaveUser(UserModel model)
        {
            if (model.Id == 0)
            {
                await HttpClientHelper.SendPostRequest(model, "User/add-new-user", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }
            else
            {
                await HttpClientHelper.SendPostRequest(model, "User/update-user", CookieHelper.GetToken(Request, "oaut.Cookie"));
            }

            return Ok("Ok");
        }

        public async Task<IActionResult> DeleteUser(UserModel model)
        {
            await HttpClientHelper.SendPostRequest(model, "User/delete-user", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }

        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {

            string userId = User.Claims.First(x => x.Type == ClaimTypes.Name).Value;

            UserModel user = await HttpClientHelper.SendGetRequest<UserModel>("User/get-users-by-email?email=" + userId, CookieHelper.GetToken(Request, "oaut.Cookie"));

            if (user.Id == 0 || user.Password != model.OldPassword)
            {
                return Ok(new { Status=2, Message="Eski Şifre Hatalı" });
            }

            if (model.NewPassword != model.NewPasswordRepeat)
            {
                return Ok(new { Status = 2, Message = "Yeni Şifre ve Tekrarı Birbiriyle Uyuşmuyor." });
            }

            user.Password = model.NewPassword;

            await HttpClientHelper.SendPostRequest(model, "User/update-user", CookieHelper.GetToken(Request, "oaut.Cookie"));

           return Ok(new { Status = 1 });
        }

    }
}
