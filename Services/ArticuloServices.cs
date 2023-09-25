using Microsoft.Extensions.Options;
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
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Articulo>> GetAll()
        {
            string resp = await _httpCliente.GetStringAsync($"Articulo");
            return JsonSerializer.Deserialize<IEnumerable<Articulo>>(resp, options);


        }
        public async Task<Articulo> GetById(int id)
        {
            string resp = await _httpCliente.GetStringAsync($"Articulo/{id}");
            return JsonSerializer.Deserialize<Articulo>(resp, options);
        }
    }
}
