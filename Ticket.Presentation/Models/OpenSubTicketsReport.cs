using System;
namespace Ticket.Presentation.Models
{
    public class OpenSubTicketsReport
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TicketId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NameSurname { get; set; }
        public string CardName { get; set; }
    }
}
