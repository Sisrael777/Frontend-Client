using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public interface ICategoriaServices
    {
        Task<IEnumerable<Categoria>> GetAll();
        Task<Categoria> GetById(int id);
    }
}
