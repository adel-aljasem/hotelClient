using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;
using PayPal.Api;
namespace Hotel_Client.Service.IService
{
    public class PayPalService
    {
        private readonly HttpClient httpClient;
        public PayPalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PayPalDTO> Pay(string redirectUrl,string cancelUrl,string price)
        {
            var result = await httpClient.GetAsync($"api/paypalpayment/payment?redirectUrl={redirectUrl}&cancel_url={cancelUrl}&price={price}");
            
            if (result.IsSuccessStatusCode)
            {
                var paymentInfo = await result.Content.ReadAsStringAsync();
                var paymentObject = JsonConvert.DeserializeObject<PayPalDTO>(paymentInfo);

                return paymentObject;

            }
            else
            {
                throw new Exception();
            }

           
        }

    }
}
