using System;
namespace Ticket.Presentation.ViewModels
{
    public class BillingReportWithProject
    {
        public string CardName { get; set; }
        public string SupportType { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public int TotalWorkDay { get; set; }
        public int TotalWorkHour { get; set; }
        public double ManHour { get; set; }
        public double TotalPrice { get; set; }
        public string ProjectName { get; set; }
    }
}
