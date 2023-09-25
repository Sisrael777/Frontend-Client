using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class ConsolaServices : IConsolaServices
    {
        private readonly HttpClient _httpCliente;
        public ConsolaServices(HttpClient httpCliente)
        {

            _httpCliente = httpCliente;
        }

        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Consola>> GetAll()
        {
            string resp = await _httpCliente.GetStringAsync($"Consola");
            return JsonSerializer.Deserialize<IEnumerable<Consola>>(resp, options);


        }
        public async Task<Consola> GetById(int id)
        {
            string resp = await _httpCliente.GetStringAsync($"Consola/{id}");
            return JsonSerializer.Deserialize<Consola>(resp, options);
        }
    }
}
