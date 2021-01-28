using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Helpers;
using Ticket.Presentation.Models;
using Ticket.Presentation.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket.Presentation.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ReportController : BaseController
    {
        // GET: /<controller>/
        public IActionResult SmartWmVersionControl()
        {
            return View();
        }

        public IActionResult TicketDetailReport()
        {
            return View();
        }

        public async Task<IActionResult> GetSmartWmVersionControl(JqueryDataTableParam param)
        {

            string url = $"Report/get-smartWmVersionReport";


            if (!string.IsNullOrEmpty(param.reportParam1))
            {
                url += $"?SmartWMVersion={param.reportParam1}";
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<SmartWMVersionControlModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }

        public IActionResult ServiceReport()
        {
            return View();
        }

        public IActionResult BillingReport()
        {
            return View();
        }

        public IActionResult BillingReportWithProject()
        {
            return View();
        }

        public IActionResult EmployeePerformanceReport()
        {
            return View();
        }

        public IActionResult VersionReport()
        {
            return View();
        }

        public IActionResult NotAnsweredTicketReport()
        {
            return View();
        }

        public async Task<IActionResult> GetNotAnsweredTicketReport(JqueryDataTableParam param)
        {

            string url = $"Report/notAnsweredTickets";

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

        public async Task<IActionResult> GetServiceReport(ServiceReportParams param)
        {

            string url = $"Report/get-serviceReport";


            string urlParam = string.Empty;
            if (!string.IsNullOrEmpty(param.CardCode))
            {
                urlParam += $"&CardCode={param.CardCode}";
            }

            if (param.StartDate != DateTime.MinValue)
            {
                urlParam += $"&StartDate={param.StartDate.ToString("yyyy-MM-dd")}";
            }

            if (param.EndDate != DateTime.MinValue)
            {
                urlParam += $"&EndDate={param.EndDate.ToString("yyyy-MM-dd")}";
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<ServiceReport>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(repositories.ToList());
        }

        public async Task<IActionResult> GetTicketDetailReport(ServiceReportParams param)
        {

            string url = $"Report/get-ticketDetailReport";


            if (!string.IsNullOrEmpty(param.CardCode))
            {
                url += $"?CardCode={param.CardCode}";
            }


            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<TicketDetailReport>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(repositories.ToList());
        }

        public async Task<IActionResult> GetEmployeePerformanceReport(ServiceReportParams param)
        {

            string url = $"Report/employeePerformanceReport";

            string urlParam = $"&UserId={param.UserId}";

            if (param.StartDate != DateTime.MinValue)
            {
                urlParam += $"&StartDate={param.StartDate.ToString("yyyy-MM-dd")}";
            }

            if (param.EndDate != DateTime.MinValue)
            {
                urlParam += $"&EndDate={param.EndDate.ToString("yyyy-MM-dd")}";
            }

            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }


            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<EmployeePerformanceReport>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(repositories.ToList());
        }

        public async Task<IActionResult> GetBillingReportReportWithProject(ServiceReportParams param)
        {

            string url = $"Report/billingReportWithProject";


            string urlParam = string.Empty;
            if (!string.IsNullOrEmpty(param.CardCode))
            {
                urlParam += $"&CardCode={param.CardCode}";
            }

            if (param.StartDate != DateTime.MinValue)
            {
                urlParam += $"&StartDate={param.StartDate.ToString("yyyy-MM-dd")}";
            }

            if (param.EndDate != DateTime.MinValue)
            {
                urlParam += $"&EndDate={param.EndDate.ToString("yyyy-MM-dd")}";
            }

            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<BillingReportWithProject>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(repositories.ToList());
        }

        public async Task<IActionResult> GetBillingReport(ServiceReportParams param)
        {

            string url = $"Report/billingReport";


            string urlParam = string.Empty;
            if (!string.IsNullOrEmpty(param.CardCode))
            {
                urlParam += $"&CardCode={param.CardCode}";
            }

            if (param.StartDate != DateTime.MinValue)
            {
                urlParam += $"&StartDate={param.StartDate.ToString("yyyy-MM-dd")}";
            }

            if (param.EndDate != DateTime.MinValue)
            {
                urlParam += $"&EndDate={param.EndDate.ToString("yyyy-MM-dd")}";
            }


            if (!string.IsNullOrEmpty(urlParam))
            {
                url += "?" + urlParam.Remove(0, 1);
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<BillingReport>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(repositories.ToList());
        }

        public async Task<IActionResult> GetVersionReport(JqueryDataTableParam param)
        {

            string url = $"Report/versionReport";


            if (!string.IsNullOrEmpty(param.reportParam1))
            {
                url += $"?CardName={param.reportParam1}";
            }

            var repositories = await HttpClientHelper.SendGetRequest<IEnumerable<VersionReportModel>>(url, CookieHelper.GetToken(Request, "oaut.Cookie"));

            return Json(new
            {
                draw = param.draw,
                recordsTotal = repositories.Count(),
                recordsFiltered = 0,
                error = string.Empty,
                data = repositories.ToList()
            });
        }
    }
}
