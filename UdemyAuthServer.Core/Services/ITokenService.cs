using System;
using System.Collections.Generic;
using System.Text;
using UdemyAuthServer.Core.Configuration;
using UdemyAuthServer.Core.Dto;
using UdemyAuthServer.Core.Entities;

namespace UdemyAuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}