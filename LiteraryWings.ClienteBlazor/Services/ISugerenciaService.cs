using LiteraryWings.ClienteBlazor.Models;

namespace LiteraryWings.ClienteBlazor.Services
{
    public interface ISugerenciaService
    {
       Task<IEnumerable<Sugerencia>> GetAll();
       Task<int> Save(Sugerencia sugerencia);
    }
}
