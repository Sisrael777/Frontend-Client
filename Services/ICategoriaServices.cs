using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public interface ICategoriaServices
    {
        Task<IEnumerable<Categoria>> GetAll();
    }
}
