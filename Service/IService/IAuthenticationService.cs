using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Client.Service.IService
{
    public interface IAuthenticationService
    {
        Task<RegisterationResponseDTO> RegisterUser(UserRequsetDTO userForRegisteration);
        Task<AuthenticationResponseDTO> Login(AuthenticationDTO userFromAuthentication);
        Task Logout();

    }
}
