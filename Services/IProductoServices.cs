using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public interface IProductoServices
    {
        Task<IEnumerable<Producto>> GetAll();
        Task<Producto> GetById(int id);
    }
}
