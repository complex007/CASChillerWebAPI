using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWebAPI.Models
{
    public class Login
    {
        public int Id { get; set; }
       
        public bool Status { get; set; }
        
        public string AppName { get; set; }
        public string Token { get; set; }
        public List<Modules> Modules { get; set; }
    }
}