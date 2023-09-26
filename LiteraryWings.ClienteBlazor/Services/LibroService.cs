using LiteraryWings.ClienteBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace LiteraryWings.ClienteBlazor.Services
{
    public class LibroService : ILibroService
    {
        //Inyección de dependencias de Httpclient
        private readonly HttpClient client;
        public LibroService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Libro>> GetAll()
        {
            string resp = await client.GetStringAsync($"Libro");
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(resp, options);
        }

        public async Task<IEnumerable<Libro>> GetAllRefs()
        {
            var resp = await client.PostAsJsonAsync($"Libro/Buscar", new { top_aux = 100 });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<IEnumerable<Libro>> GetByAutor(int idAut)
        {
            var resp = await client.PostAsJsonAsync($"Libro/Buscar", new { idAutor = idAut });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<IEnumerable<Libro>> GetByCategoria(int idCateg)
        {
            var resp = await client.PostAsJsonAsync($"Libro/Buscar", new { idCategoria = idCateg });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<IEnumerable<Libro>> GetByEditorial(int idEditor)
        {
            var resp = await client.PostAsJsonAsync($"Libro/Buscar", new { idEditorial = idEditor });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<Libro> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Libro/{id}");
            Libro libro = JsonSerializer.Deserialize<Libro>(resp, options);
            return libro;
        }
    }
}
