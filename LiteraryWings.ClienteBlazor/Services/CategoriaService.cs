using LiteraryWings.ClienteBlazor.Models;
using System.Text.Json;

namespace LiteraryWings.ClienteBlazor.Services
{
    public class CategoriaService : ICategoriaService
    {

        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public CategoriaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, options);
        }
    }
}
