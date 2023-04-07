using System;
namespace Ticket.Presentation.Models
{
    public class CalendarModel
    {
        public int Id { get; set; }

        public int UserCode { get; set; }

        public string CardCode { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string AppointmentType { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string NameSurname { get; set; }
    }
}
