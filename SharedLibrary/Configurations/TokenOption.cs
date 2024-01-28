using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Configurations
{
    public class TokenOption
    {
        public List<String> Audience { get; set; }
        public string Issuer { get; set; }

        public int AccessTokenExpiration { get; set; }
        public int RefreshTokenExpiration { get; set; }

        public string SecurityKey { get; set; }
    }
}