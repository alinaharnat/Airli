
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Project
{
  
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        public List<Order> HistoryOfOrders = new List<Order>();

        public List<Order> unpaidUserOrders = new List<Order>();
       
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
      
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
   
        public User()
        {

        }
        public User(string email, string password, string lastName,string firstName)
        {
            this.email = email;
            this.password = password;
            this.lastName = lastName;
            this.firstName = firstName;
            HistoryOfOrders = new List<Order>();
        }
    }
}
