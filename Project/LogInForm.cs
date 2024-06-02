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
        Users users = new Users();
        public LogInForm()
        {
            InitializeComponent();
        }
        

        string path = @"C:\\Users\\alina\\OneDrive\\Робочий стіл\\Project C#\\Project\\Project\\InformationAboutUsers.json";
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RegistrationForm();
            form.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            users = users.LoadUsersData(path);
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;

            if(email == "alina@gmail.com"&& password == "12345678")
            {
                this.Hide();
                var form = new AddFlightsForm();
                form.Show();
            }
            else
            {  
                if (users.LoginUser(email, password, path) != null)
                {
                    var newUser = users.LoginUser(email, password, path);
                    Hide();
                    var form = new SearchFlightsForm(newUser);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Неправильна поштова адреса або пароль.");
                }
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
    }
}
