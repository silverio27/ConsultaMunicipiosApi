using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ibge.Municipios
{
    public class MunicipiosApi : IMunicipios
    {
        HttpClient _httpClient;
        public MunicipiosApi(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<Municipio>> Get()
        {
            var request = await _httpClient.GetAsync(_httpClient.BaseAddress);

            if (request.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = await request.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Municipio>>(json);
            }

            throw new Exception("O método falhou");
        }
    }

}