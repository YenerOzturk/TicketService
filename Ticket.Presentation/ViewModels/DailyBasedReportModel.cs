using System;
namespace Ticket.Presentation.ViewModels
{
    public class DailyBasedReportModel
    {
        public string cardName { get; set; }
        public string subject { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string description { get; set; }
        public double totalWorkHour { get; set; }
    }
}
