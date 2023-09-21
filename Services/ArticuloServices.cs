using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class ArticuloServices : IArticuloServices
    {
        private readonly HttpClient _httpCliente;
        public ArticuloServices(HttpClient httpCliente)
        {

            _httpCliente = httpCliente;
        }

        public async Task<IEnumerable<Articulo>> GetAll()
        {
            var optins = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpCliente.GetStringAsync($"Articulo");
            return JsonSerializer.Deserialize<IEnumerable<Articulo>>(resp, optins);


        }
    }
}
