﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Project
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            
        }
        //Add validation of first/last name using  MaskedTextBox
        //change email validation
        string path = @"C:\\Users\\alina\\OneDrive\\Робочий стіл\\Project C#\\Project\\Project\\InformationAboutUsers.json";
        private void registrationButton_Click(object sender, EventArgs e)
        {
            if(lastNameTextBox.Text.Length < 2 || firstNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Довжина прізвища та імені має бути щонайменше 2 символи.");
            }else if(passwordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Довжина пароля має бути не менше 8 символів.");
            }else if (firstNameTextBox.Text.Length == 0 || lastNameTextBox.Text.Length == 0 || emailTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заповніть всі обов'язкові поля.");
            }else if (!Validation.ValidateEmail(emailTextBox.Text))
            {
                MessageBox.Show("Неправильний формат поштової адреси.");
            }
            else
            {
                if (CheckEmail(emailTextBox.Text, path))
                {
                    MessageBox.Show("Користувач з такою поштовою адресою вже існує.");
                }
                else
                {
                    var user = new User(emailTextBox.Text, passwordTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                    if (user.SaveUser(path))
                    {
                        Hide();
                        var form = new SearchFlightsForm();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Помилка реєстрації.");
                    }
                }
            }
           
        }
        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!Validation.ValidateLength(2, lastNameTextBox.Text))
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

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!Validation.ValidateLength(2, firstNameTextBox.Text))
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
       
        public bool CheckEmail(string email, string path)
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
    }
}
