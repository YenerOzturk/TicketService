using System;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.ViewModels
{
    public class VersionViewModel
    {
		public int Id { get; set; }
		public int ProductId { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string CardCode { get; set; }
		public string Currency { get; set; }
		public int Installment { get; set; }
		public decimal Price { get; set; }
        public string Attachment { get; set; }
		public IFormFile File { get; set; }
	}
}
