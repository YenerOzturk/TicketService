using Ticket.Presentation.Models;

namespace Ticket.Presentation.Helpers
{
    public class UserHelper
    {
        public static async System.Threading.Tasks.Task<UserModel> GetByEmailAsync(string email,string token)
        {
            var url = $"User/get-users-by-email?email={email}";

            var repositories = await HttpClientHelper.SendGetRequest<UserModel>(url, token);

            return repositories;
        }
    }
}
