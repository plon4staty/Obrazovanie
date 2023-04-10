using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazovanie
{
     public  class CheckUsers
    {
        public string Login { get; set; }   

        public bool IsAdmin { get;}

        public string Status => IsAdmin ? "admin" : "mendjer";

        public CheckUsers(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
