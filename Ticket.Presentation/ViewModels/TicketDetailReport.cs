using System;
namespace Ticket.Presentation.ViewModels
{
    public class TicketDetailReport
    {
        public string CardName { get; set; }
        public string Owner { get; set; }
        public string TicketDetail { get; set; }
        public string SubTicketDetail { get; set; }
        public string CreatedBy { get; set; }
        public string WorkingBy { get; set; }
        public double WorkDay { get; set; }
        public double WorkHour { get; set; }
        public string StartDate { get; set; }
        public bool IsRejected { get; set; }
    }
}
