using System;
namespace Ticket.Presentation.ViewModels
{
    public class SubTicketViewModel
    {
        public string Description { get; set; }
        public int Status { get; set; }
        public int TicketId { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CloseTicket { get; set; }
    }
}
