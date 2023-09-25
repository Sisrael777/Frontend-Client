using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public interface IConsolaServices
    {
        Task<IEnumerable<Consola>> GetAll();
        Task<Consola> GetById(int id);
    }
}
