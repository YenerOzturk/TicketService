using System;
using System.Collections.Generic;

namespace Ticket.Presentation.Models
{
    public class ServiceReportParams
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CardCode { get; set; }
        public int UserId { get; set; }
        public List<string> Billing { get; set; }
        public List<string> ProjectIds { get; set; }
        public bool ShowOnlyProjectUnRelatedTicket { get; set; }
    }
}
