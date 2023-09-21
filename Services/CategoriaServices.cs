using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly HttpClient _httpCliente;
        public CategoriaServices(HttpClient httpCliente)
        {

            _httpCliente = httpCliente;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            var optins = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpCliente.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, optins);


        }
    }
}
