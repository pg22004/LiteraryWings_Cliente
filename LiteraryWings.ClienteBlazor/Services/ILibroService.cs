using LiteraryWings.ClienteBlazor.Models;

namespace LiteraryWings.ClienteBlazor.Services
{
    public interface ILibroService
    {
        Task<IEnumerable<Libro>> GetAll();
        Task<IEnumerable<Libro>> GetByAutor(int idAut);
        Task<IEnumerable<Libro>> GetByCategoria(int idCateg);
        Task<IEnumerable<Libro>> GetByEditorial(int idEditor);
        Task<Libro> GetById(int id);
    }
}
