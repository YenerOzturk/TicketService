using System;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Helpers
{
    public class CookieHelper
    {
        public static void SetToken(HttpResponse response, string key, string value)
        {
            CookieOptions option = new CookieOptions();

            option.Expires = DateTime.Now.AddDays(30);

            response.Cookies.Append(key, value, option);
        }

        public static string GetToken(HttpRequest request, string key)
        {
            return request.Cookies[key];
        }
    }
}
