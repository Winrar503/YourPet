using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YourPett.Models;

namespace YourPett.Services
{
    public class RegistroAnimalService : IRegistroAnimalService
    {
        private const string URL = "https://example-rest-api-2.onrender.com/api/mascota";

        public async Task<List<RegistroAnimal>> ObtenerRegistro()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var registro = JsonSerializer.Deserialize<List<RegistroAnimal>>(content);
                    return registro;
                }
                return null;
            }
        }

        public async Task<RegistroAnimal> CrearRegistro(RegistroAnimal nuevaRegistroAnimal)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonSerializer.Serialize(nuevaRegistroAnimal), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(URL, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var registroCreada = JsonSerializer.Deserialize<RegistroAnimal>(responseContent);
                    return registroCreada;
                }
                return null;
            }
        }
    }
}
