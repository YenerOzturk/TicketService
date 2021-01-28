using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Telephone { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool Reporting { get; set; }
        public string Currency { get; set; }
        public decimal ManHourPrice { get; set; }
        public string Attachment { get; set; }
        public string RemoteDesktopInfo { get; set; }
        public string VPNInfo { get; set; }
        public string Note { get; set; }
        public string ConsultantMail { get; set; }
        public string KnownName { get; set; }
        [JsonIgnore]
        public IFormFile File { get; set; }
    }
}
