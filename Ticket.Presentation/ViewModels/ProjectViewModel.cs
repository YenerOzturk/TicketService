using System;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CardCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ManHour { get; set; }
        public string Attachment { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string ProjectName { get; set; }
        public bool Billing { get; set; }
        public string ProjectOwners { get; set; }
        public IFormFile File { get; set; }
    }
}
