using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ticket.Presentation.Helpers
{
    public class HttpClientHelper
    {
        private static readonly string _baseUrl = "http://localhost:5009/";

        public static async Task<T> SendGetRequest<T>(string url, string token)
        {
            try
            {

                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                var response = await client.GetStringAsync(_baseUrl + url);

                var repository = JsonSerializer.Deserialize<T>(response, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                return repository;
            }
            catch (Exception ex)
            {
                throw new Exception("Url: "+url+" Ex:"+ex.Message);
            }

        }

        public static async Task<int> SendPostRequest<T>(T model, string url, string token)
        {

            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                HttpContent httpContent = new StringContent(JsonSerializer.Serialize<T>(model), Encoding.UTF8);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response= await client.PostAsync(_baseUrl + url, httpContent);
                var result = await response.Content.ReadAsStringAsync();

                int id = 0;
                if (int.TryParse(result, out id))
                    return id;

                return 0; 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



    }
}
