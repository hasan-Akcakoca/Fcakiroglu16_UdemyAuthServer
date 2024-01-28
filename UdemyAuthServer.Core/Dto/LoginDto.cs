using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.Dto
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}