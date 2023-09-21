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

        public async Task<IEnumerable<Producto>> GetAll()
        {
           var optins = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpCliente.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, optins);


        }
    }
}
