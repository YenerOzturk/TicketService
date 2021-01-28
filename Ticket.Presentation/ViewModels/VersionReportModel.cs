using System;
namespace Ticket.Presentation.ViewModels
{
    public class VersionReportModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string FormatedStartDate { get; set; }
        public string FormatedEndDate { get; set; }
        public int RemainingDay { get; set; }
        public string CardName { get; set; }
        public string Currency { get; set; }
        public int Installment { get; set; }
        public decimal Price { get; set; }
    }
}
