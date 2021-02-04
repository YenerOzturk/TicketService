using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string CardCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ManHour { get; set; }
        public string Attachment { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string ProjectName { get; set; }
        public string ProjectOwners { get; set; }
        public bool Billing { get; set; }
        [JsonIgnore]
        public IFormFile File { get; set; }
    }
}
