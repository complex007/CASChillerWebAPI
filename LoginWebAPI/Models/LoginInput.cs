using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWebAPI.Models
{
    public class LoginInput
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Appname { get; set; }
    }
}