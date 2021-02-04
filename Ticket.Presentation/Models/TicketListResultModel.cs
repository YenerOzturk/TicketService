using System;
namespace Ticket.Presentation.Models
{
    public class TicketListResultModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string CardName { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreateDate { get; set; }
        public string SupportType { get; set; }
        public bool Billing { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public bool AllDay { get; set; }
        public string CreateDateAsString { get; set; }
        public string Subject { get; set; }
    }
}
