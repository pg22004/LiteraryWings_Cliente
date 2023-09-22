using LiteraryWings.ClienteBlazor.Models;

namespace LiteraryWings.ClienteBlazor.Services
{
    public interface IEditorialService
    {
        Task<IEnumerable<Editorial>> GetAll();
    }
}
