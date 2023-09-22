using LiteraryWings.ClienteBlazor.Models;

namespace LiteraryWings.ClienteBlazor.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAll();
    }
}
