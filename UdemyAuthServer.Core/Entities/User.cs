using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.Entities
{
    public class User : IdentityUser
    {
        public string City { get; set; }
    }
}