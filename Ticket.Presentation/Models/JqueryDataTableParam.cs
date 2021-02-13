using System;
using System.Collections.Generic;

namespace Ticket.Presentation.Models
{
    public class JqueryDataTableParam
    {

        public string draw { get; set; }
        public string start { get; set; }
        public int length { get; set; }
        public int columns { get; set; }
        public string userId { get; set; }
        public int id { get; set; }
        public string cardCode { get; set; }
        public int status { get; set; }
        public string productId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }
        public string nameSurname { get; set; }
        public string email { get; set; }
        public int supportType { get; set; }
        public string cardName { get; set; }
        public string reportParam1 { get; set; }
        public string reportParam2 { get; set; }
        public string subject { get; set; }

        public List<string> cardCodes { get; set; }
        public List<string> userIds { get; set; }
        public List<string> statuList { get; set; }
    }
}
