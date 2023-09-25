using LiteraryWings.ClienteBlazor.Models;
using System.Text.Json;

namespace LiteraryWings.ClienteBlazor.Services
{
    public class AutorService : IAutorService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public AutorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Autor>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Autor");
            return JsonSerializer.Deserialize<IEnumerable<Autor>>(resp, options);
        }
    }
    
}
