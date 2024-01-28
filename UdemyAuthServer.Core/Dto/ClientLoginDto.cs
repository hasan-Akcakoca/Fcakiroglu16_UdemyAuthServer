using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.Dto
{
    public class ClientLoginDto
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}