using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Login
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool verifyLogin()
        {
            //make db connection and check if user and password match
            return true;
        }
    }
    
}
