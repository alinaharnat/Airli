using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;




namespace Project
{
    public class Users
    {
        public List<User> UsersList { get; set; }
        public Users() 
        {
           UsersList = new List<User>();
        }

        
        public void SaveUsersData(string path)
        {
           
                var jsonStr = JsonSerializer.Serialize(this);
                File.WriteAllText(path, jsonStr);
           
        }

        public Users LoadUsersData(string path)
        {
            var jsonStr = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Users>(jsonStr);
        }

        //Searching user
        //
        public bool CheckEmail(string email, string path)
        {
            foreach (var user in UsersList)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        
        public User LoginUser(string email, string password, string path)
        {
                foreach (var user in UsersList)
                {
                    if (user.Email == email && user.Password == password )
                    {
                        return user;
                    }
                }
          return null; 
        }
        public void AddUser(User user, string path)
        {
            UsersList.Add(user);
            SaveUsersData(path);
        }
        //
        public  bool ChangeUserInformation(User curUser,  string email, string password, string lastName, string firstName, string path)
        {
           
             if (Validation.ValidateName(lastName, 2) &&
             Validation.ValidateName(firstName, 2) &&
             Validation.ValidateLength(8, password))
                {
                    foreach (var u in UsersList)
                    {
                        if (u.Email == email)
                        {
                            //var user = new User(email, password, lastName, firstName);

                            u.Password = password;
                            u.FirstName = firstName;
                            u.LastName = lastName;
                            curUser = u;
                            SaveUsersData(path);
                            return true;
                        }
                    }
                }
                return false;
            }

        public void ChangeHistory(User curUser, string path)
        {

            foreach (var user in UsersList)
            {
                if (user.Email == curUser.Email)
                {
                    user.HistoryOfOrders = curUser.HistoryOfOrders;
                    SaveUsersData(path);
                }
            }
        }
    }
        //
       
        //


    }

