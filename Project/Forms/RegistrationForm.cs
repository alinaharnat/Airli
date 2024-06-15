using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;



namespace Project
{
    public partial class RegistrationForm : Form
    {
        private Users users;
        public RegistrationForm(Users allUsers)
        {
            users = allUsers;
            InitializeComponent();
        }

        string path = @"C:\Users\alina\OneDr*/ive\Робочий стіл\Project C#\Project\Project\DataSources\InformationAboutUsers.json";

        private void registrationButton_Click(object sender, EventArgs e)
        {
            //users = users.LoadUsersData(path);

            var lastName = lastNameTextBox.Text;
            var firstName = firstNameTextBox.Text;
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;

            if (!Validation.ValidateName(firstName,2) || !Validation.ValidateName(lastName, 2))
            {
                MessageBox.Show("Довжина прізвища та імені має бути щонайменше 2 символи.");
            }else if(password.Length < 8)
            {
                MessageBox.Show("Довжина пароля має бути не менше 8 символів.");
            }else if (firstName.Length == 0 || lastName.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Заповніть всі обов'язкові поля.");
            }else if (!Validation.ValidateEmail(emailTextBox.Text))
            {
                MessageBox.Show("Неправильний формат поштової адреси.");
            }
            else
            {
                if (users.CheckEmail(email, path))
                {
                    MessageBox.Show("Користувач з такою поштовою адресою вже існує.");
                }
                else
                {
                    var user = new User(email, password, firstName, lastName);
                    users.AddUser(user,path);
                    //users.SaveUsersData(path);
                    Hide();
                    var form = new SearchFlightsForm(user, users);
                    form.Show();
                }
                   
            }
        }
        //LastNameTextBox
        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateName(lastNameTextBox.Text,2))
            {
                lastNameTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина прізвища має бути не менше 2 символів.");
               
            }
        }
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.ForeColor == Color.Red)
            {
                lastNameTextBox.ForeColor = Color.Black;
            }
        }
       //
        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateName(firstNameTextBox.Text,2))
            {
                firstNameTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина імені має бути не менше 2 символів.");
            }
        }
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.ForeColor == Color.Red)
            {
                firstNameTextBox.ForeColor = Color.Black;
            }
        }
        //
        private void emailTextBox_Validating(object sender, CancelEventArgs e)
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
        //
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LogInForm();
            form.Show();
        }
    }
}
