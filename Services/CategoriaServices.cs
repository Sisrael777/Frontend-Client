using Microsoft.Extensions.Options;
using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class CategoriaServices: ICategoriaServices
    {
        private readonly HttpClient _httpCliente;
        public CategoriaServices(HttpClient httpCliente)
        {

            _httpCliente = httpCliente;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Categoria>> GetAll()
        {
            string resp = await _httpCliente.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, options);


        }
        public async Task<Categoria> GetById(int id)
        {
            string resp = await _httpCliente.GetStringAsync($"Categoria/{id}");
            return JsonSerializer.Deserialize<Categoria>(resp, options);
        }
    }

}

