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
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient client;

        public HotelRoomService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetHotelRooms(string checkInDate, string checkOutDate)
        {
            var response = await client.GetAsync($"api/hotelroom?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);
            return rooms;
        }

        public async Task<HotelRoomDTO> GetHotelRoomsDetails(int roomId, string checkInDate, string checkOutDate)
        {
            var response = await client.GetAsync($"api/hotelroom/{roomId}?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<HotelRoomDTO>(content);
                return room;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }

        }
    }
}
