using System;
namespace Ticket.Presentation.Models
{
    public class VersionListResultModel
    {
		public int Id { get; set; }
		public string ProductName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string CardName { get; set; }
		public string Currency { get; set; }
		public int Installment { get; set; }
		public decimal Price { get; set; }
		public string StartDateAsString { get; set; }
		public string EndDateAsString { get; set; }
	}
}
