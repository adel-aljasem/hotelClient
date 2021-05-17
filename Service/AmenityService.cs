using Hotel_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hotel_Client.Service
{
    public class AmenityService : IAmenityService
    {

        private readonly HttpClient httpClient;
        public AmenityService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<AmenityDTO>> GetAllAmentiy()
        {
            var response = await httpClient.GetAsync("api/amenity");
            var content = await response.Content.ReadAsStringAsync();
            var amenity = JsonConvert.DeserializeObject<IEnumerable<AmenityDTO>>(content);
            return amenity;
        }
    }
}
