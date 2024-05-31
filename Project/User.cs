using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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
        //private int bonus;
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
        }
        
        public static bool CheckEmail(string email, string path)
        {
            string j = File.ReadAllText(path);
            var users = JsonConvert.DeserializeObject<List<User>>(j);
            foreach (var user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool SaveUser(User user, string path)
        {
            try
            {
                string jsonData = File.ReadAllText(path);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                users.Add(user);
                string data = JsonConvert.SerializeObject(users);
                File.WriteAllText(path, data);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //add validation
        public static List<User> GetData(string path)
        {
            string data = File.ReadAllText(path);
            var users = JsonConvert.DeserializeObject<List<User>>(data);
            return users;
        }


        public static User LoginUser(string email, string password, string path)
        {
            try
            {
                var users = GetData(path);

                foreach (var user in users)
                {
                    if (user.Email == email)
                    {
                        if (user.Password == password)
                        {
                            return user;
                        }
                        break;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка.");
                return null;
            }
        }
        public static bool ChangeUserInformation(User curUser,string email, string lastName, string firstName, string password, string path)
        {
            if(Validation.ValidateName(firstName,2) || Validation.ValidateName(lastName,2) || Validation.ValidateLength(8, password)) 
            {
                var users = GetData(path);
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Email.Equals(email))
                    {
                        var newUser = new User(email, password, lastName, firstName);
                        users[i] = newUser;
                        curUser = newUser;
                        string data = JsonConvert.SerializeObject(users);
                        File.WriteAllText(path, data);
                        return true;
                    }
                }
            }
            return false;
        }
        public static void ChangeHistory(User curUser,string path)
        {
           
                var users = GetData(path);
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Email == curUser.Email)
                    {
                        
                        users[i] = curUser;
                        string data = JsonConvert.SerializeObject(users);
                        File.WriteAllText(path, data);
                      
                    }
                }

        }
    }
}
