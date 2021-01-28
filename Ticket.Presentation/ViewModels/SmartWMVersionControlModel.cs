using System;
namespace Ticket.Presentation.ViewModels
{
    public class SmartWMVersionControlModel
    {
        public int Version { get; set; }
        public int TicketId { get; set; }
        public string Description { get; set; }
        public string SubTicketUser { get; set; }
    }
}
