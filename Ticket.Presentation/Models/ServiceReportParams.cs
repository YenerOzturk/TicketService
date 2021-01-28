using System;
namespace Ticket.Presentation.Models
{
    public class ServiceReportParams
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CardCode { get; set; }
        public int UserId { get; set; }
    }
}
