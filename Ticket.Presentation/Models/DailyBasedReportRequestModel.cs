using System;
using System.Collections.Generic;

namespace Ticket.Presentation.Models
{
    public class DailyBasedReportRequestModel
    {
        public int UserId { get; set; }
        public List<string> CardCodes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
