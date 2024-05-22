using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Project
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        //Add function forgot password
        
        string path = @"C:\\Users\\alina\\OneDrive\\Робочий стіл\\Project C#\\Project\\Project\\InformationAboutUsers.json";
        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new RegistrationForm();
            form.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (TryLoginUser(emailTextBox.Text, passwordTextBox.Text))
            {
                User curUser = new User();
                curUser.Email = emailTextBox.Text;
                var profileForm = new UserProfile(curUser);
                Hide();
                var form = new SearchFlightsForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неправильна поштова адреса або пароль.");
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {

            if (!Validation.ValidateEmail(emailTextBox.Text))
            {
                emailTextBox.ForeColor = Color.Red;
                MessageBox.Show("Неправильний формат поштової адреси.");

            }
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTextBox.ForeColor == Color.Red)
            {
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (!Validation.ValidateLength(8, passwordTextBox.Text))
            {
                passwordTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина пароля має бути не менше 8 символів.");


            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.ForeColor == Color.Red)
            {
                passwordTextBox.ForeColor = Color.Black;
            }
        }
        public bool TryLoginUser(string email, string password)
        {
            try
            {
                string data = File.ReadAllText(path);
                var users = JsonConvert.DeserializeObject<List<User>>(data);
                var newUser = users.FirstOrDefault(user => user.Email == email);
                if (newUser != null && newUser.Password == password)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка.");
                return false;
            }
        }
    }
}
