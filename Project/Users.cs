using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Project
{
    public class Users
    {
        public Users()
        {
            UsersList = new List<User>();
        }

        public List<User> UsersList { get; set; }
    }
}

