using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalyDemoEx
{
    internal class Roles
    {
        public string Login {  get; set; }
        public string Password { get; set; }
        public bool Role { get; }

        public Roles(string login, bool role) 
        {
            Login = login;
            Role = role;
        }
    }
}
