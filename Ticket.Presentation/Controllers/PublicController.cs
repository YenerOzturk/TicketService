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
    public class PublicController : Controller
    {
        [AllowAnonymous]
        public IActionResult ApproveMonth(string id)
        {
            ViewBag.UserId = id;

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Approve(ApproveMonthModel model)
        {
            await HttpClientHelper.SendPostRequest(model, "User/approve-month", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok(new { Status = 1 });
        }
    }
}
