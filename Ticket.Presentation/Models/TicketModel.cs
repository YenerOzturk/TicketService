using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CardCode { get; set; }
        public int ProjectId { get; set; }
        public DateTime CreateDate { get; set; }
        public int SupportType { get; set; }
        public bool Billing { get; set; }
        public int Status { get; set; }
        public string TicketDescription { get; set; }
        public string ProductId { get; set; }
        public string Subject { get; set; }
        public int CreatedBy { get; set; }

        public string Description { get; set; }
        public string Attachment { get; set; }
        public bool SendMail { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public string TicketLabel { get; set; }

        [JsonIgnore]
        public IFormFile File { get; set; }
    }
}
