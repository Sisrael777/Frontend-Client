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

        public async Task<IEnumerable<Consola>> GetAll()
        {
            var optins = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpCliente.GetStringAsync($"Consola");
            return JsonSerializer.Deserialize<IEnumerable<Consola>>(resp, optins);


        }




    }
}
