using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    public class BaseController : Controller
    {
        // GET: /<controller>/
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            ViewData["UserId"] = User.Claims.First(x => x.Type == ClaimTypes.Sid).Value;
            ViewData["UserRole"] = User.Claims.First(x => x.Type == ClaimTypes.Role).Value;
            ViewData["UserName"] = User.Claims.First(x => x.Type == ClaimTypes.GivenName).Value;
            ViewData["Email"] = User.Claims.First(x => x.Type == ClaimTypes.Name).Value;
            ViewData["UserFirstLetter"] = User.Claims.First(x => x.Type == ClaimTypes.GivenName).Value.Substring(0,1);
            ViewData["CardCode"] = User.Claims.First(x => x.Type == ClaimTypes.UserData).Value;


            base.OnActionExecuting(context);
        }
    }
}
