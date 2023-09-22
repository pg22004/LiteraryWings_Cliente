using LiteraryWings.ClienteBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace LiteraryWings.ClienteBlazor.Services
{
    public class EditorialService : IEditorialService
    {
        private readonly HttpClient _httpClient;
        public EditorialService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async  Task<IEnumerable<Editorial>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Editorial");
            return JsonSerializer.Deserialize<IEnumerable<Editorial>>(resp, options);
        }
    }
}
