using System;
namespace Ticket.Presentation.ViewModels
{
    public class ServiceReport
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectName { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public double TotalDays { get; set; }
    }
}
