using LiteraryWings.ClienteBlazor.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace LiteraryWings.ClienteBlazor.Services
{
    public class SugerenciaService : ISugerenciaService
    {
        private readonly HttpClient _httpClient;
        private bool showLeaveAlert;

        public SugerenciaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> Save(Sugerencia sugerencia)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync<Sugerencia>("sugerencia", sugerencia);

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<IEnumerable<Sugerencia>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Sugerencia");
            return JsonSerializer.Deserialize<IEnumerable<Sugerencia>>(resp, options);
        }

    }
}
