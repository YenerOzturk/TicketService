using System;
namespace Ticket.Presentation.ViewModels
{
    public class EmployeePerformanceReport
    {
        public string TicketDescription { get; set; }
        public string SubTicketDescription { get; set; }
        public string NameSurname { get; set; }
        public int TotalWorkHour { get; set; }
        public int TotalWorkDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CardName { get; set; }
        public int Id { get; set; }
    }
}
