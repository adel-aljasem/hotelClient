using Blazored.LocalStorage;
using Common;
using Hotel_Client.Helper;
using Hotel_Client.Service.IService;
using Microsoft.AspNetCore.Components.Authorization;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Client.Service
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorageService;
        private readonly AuthenticationStateProvider authStateProvider;

        public AuthenticationService(HttpClient httpClient, ILocalStorageService localStorageService, AuthenticationStateProvider authStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorageService = localStorageService;
            this.authStateProvider = authStateProvider;
        }

        public async Task<AuthenticationResponseDTO> Login(AuthenticationDTO userFromAuthentication)
        {
            var content = JsonConvert.SerializeObject(userFromAuthentication);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/account/signin", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthenticationResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                await localStorageService.SetItemAsync(SD.Local_Token, result.Token);
                await localStorageService.SetItemAsync(SD.Local_UserDetails, result.UserDto);
                ((AuthStateProvider)authStateProvider).NotifyUserLoggedIn(result.Token);
                ((AuthStateProvider)authStateProvider).NotifyUserLoggedIn(result.Token);

                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", result.Token);

                return new AuthenticationResponseDTO { IsAuthSuccessful =true };
            }
            else
            {
                return result;
            }
        }

        public async Task Logout()
        {
            await localStorageService.RemoveItemAsync(SD.Local_Token);
            await localStorageService.RemoveItemAsync(SD.Local_UserDetails);
            ((AuthStateProvider)authStateProvider).NotifyUserLogout();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegisterationResponseDTO> RegisterUser(UserRequsetDTO userForRegisteration)
        {
            var content = JsonConvert.SerializeObject(userForRegisteration);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/account/signup", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegisterationResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
               
                return new RegisterationResponseDTO { IsRegisterationSuccessful = true };
            }
            else
            {
                return result;
            }
        }

      
    }
}
