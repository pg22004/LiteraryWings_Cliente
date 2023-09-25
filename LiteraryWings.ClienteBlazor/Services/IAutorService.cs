using LiteraryWings.ClienteBlazor.Models;

namespace LiteraryWings.ClienteBlazor.Services
{
    public interface IAutorService
    {
        Task<IEnumerable<Autor>> GetAll();
    }
}
