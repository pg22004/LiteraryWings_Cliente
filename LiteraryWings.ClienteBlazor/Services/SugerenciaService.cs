using LiteraryWings.ClienteBlazor.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
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

        public async Task Save (Sugerencia sugerencia)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync<Sugerencia>("sugerencia", sugerencia);

        }
    
    }
}
