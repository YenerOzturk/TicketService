using System;
namespace Ticket.Presentation.Models
{
    public class TicketMailModel
    {
        public int SubTicketId { get; set; }
        public int TicketId { get; set; }
        public string Message { get; set; }
    }
}
