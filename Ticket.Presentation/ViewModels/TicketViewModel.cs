using System;
namespace Ticket.Presentation.ViewModels
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CardCode { get; set; }
        public int ProjectId { get; set; }
        public int SupportType { get; set; }
        public bool Billing { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        public bool AllDay { get; set; }
        public DateTime CreateDate { get; set; }
        public string Attachment { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public string TicketLabel { get; set; }
        public string Subject { get; set; }
    }
}
