using System;
using System.Collections.Generic;

namespace Ticket.Presentation.Models
{
    public class GetTicketRequestModel
    {
        public List<int> Status { get; set; }
        public List<string> CardCodes { get; set; }
        public List<int> UserIds { get; set; }
        public string Subject { get; set; }
        public int SupportType { get; set; }
        public int TicketId { get; set; }
        public List<int> Priority { get; set; }
        public int PageLength { get; internal set; }
    }
}
