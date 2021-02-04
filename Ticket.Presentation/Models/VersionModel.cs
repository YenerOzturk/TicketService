using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Models
{
    public class VersionModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CardCode { get; set; }
        public string Currency { get; set; }
        public int Installment { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
        public string Attachment { get; set; }
        [JsonIgnore]
        public IFormFile File { get; set; }
    }
}
