using System.Net.Http;
using System.Text.Json;
using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public class CategoriaServices : ICategoriaServices
    {
        //inyeccion de inde pendencias de httpCliente
        private readonly HttpClient _httpClient;
        public CategoriaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            var optins = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, optins);

        }
    }
}
