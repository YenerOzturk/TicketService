using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;
using Ticket.Presentation.ViewModels;

namespace Ticket.Presentation.Controllers
{
    [Authorize]   
    public class HomeController : BaseController
    {

        private readonly string[] colors = { "fc-event-success", "fc-event-primary", "fc-event-danger" };


        public async Task<IActionResult> Index()
        {
            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<CalendarModel>>("Calendar/get-all-by-userId?userId=0", CookieHelper.GetToken(Request, "oaut.Cookie"));

            Random rnd = new Random();

            List<CalendarEventModel> result = new List<CalendarEventModel>();
            foreach (var repo in repositories)
            {
                result.Add(new CalendarEventModel()
                {
                    id = repo.Id,
                    start = repo.StartDate.ToString("yyyy-MM-dd").Replace(" ", "T"),
                    end = repo.EndDate.ToString("yyyy-MM-dd").Replace(" ", "T"),
                    description = repo.Description,
                    title = repo.Title,
                    className = colors[rnd.Next(0, 2)]
                });
            }

           

            ViewData["Events"] = result;

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddNewApp(CalendarModel model)
        {

            var result = await HttpClientHelper.SendPostRequest(model, "Calendar/create-appointment", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }


        [HttpPost]
        public async Task<IActionResult> UpdateApp(CalendarModel model)
        {
            var existedModel = await HttpClientHelper.SendGetRequest<CalendarModel>("Calendar/get-by-id?id=" + model.Id, CookieHelper.GetToken(Request, "oaut.Cookie"));

            existedModel.StartDate = model.StartDate;
            existedModel.EndDate = model.EndDate;

            var result = await HttpClientHelper.SendPostRequest(existedModel, "Calendar/update-appointment", CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok("Ok");
        }


        [HttpGet]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var model = await HttpClientHelper.SendGetRequest<CalendarModel>("Calendar/get-by-id?id=" + id, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Ok(model);
        }


        

        public IActionResult Ticket()
        {
            return View();
        }
        
    }
}
