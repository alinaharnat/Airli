using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Users
    {
        public List<User> UsersList = new List<User>();    
        public Users() { }
    }
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
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
        public void ChangePassword(string newPassword)
        {
            if(password == newPassword)
            {
                MessageBox.Show("Новий пароль не може співпадати зі старим.");
            }else if(newPassword.Length < 8)
            {
                MessageBox.Show("Довжина пароля має бути не менше 8 символів.");
            }
            else
            {
                password = newPassword;
            }
        }
        public void ChangeFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void ChangeLastName(string newLastName) 
        {
            lastName = newLastName;
        }
    }
}
