using System;
namespace Ticket.Presentation.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string Password { get; set; }
        public string CardCode { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string CardName { get; set; }
    }
}
