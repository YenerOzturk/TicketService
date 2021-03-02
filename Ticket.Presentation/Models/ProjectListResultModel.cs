using System;
namespace Ticket.Presentation.Models
{
    public class ProjectListResultModel
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ManHour { get; set; }
        public string Attachment { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string TotalWorkingTime { get; set; }
        public string StartDateAsString { get; set; }
        public string EndDateAsString { get; set; }
        public int Status { get; set; }
    }
}
