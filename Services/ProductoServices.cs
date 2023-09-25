using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class ProductoServices:IProductoServices
    {
        //inyeccion de dependencias de HttpCliente
        private readonly HttpClient _httpCliente;
        public ProductoServices(HttpClient httpCliente)
        {

            _httpCliente = httpCliente;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Producto>> GetAll()
        {
            string resp = await _httpCliente.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, options);


        }
        public async Task<Producto> GetById(int id)
        {
            string resp = await _httpCliente.GetStringAsync($"Producto/{id}");
            return JsonSerializer.Deserialize<Producto>(resp, options);
        }
    }
}
