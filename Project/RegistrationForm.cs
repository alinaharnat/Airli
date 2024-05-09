using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void registrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchEmail(emailTextBox.Text))
                {
                    MessageBox.Show("Користувач з такою поштовою адресою вже існує.");
                }
                else
                {
                    var user = new User(emailTextBox.Text, passwordTextBox.Text, lastNameTextBox.Text, firstNameTextBox.Text);
                    string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\Users.xml";
                    XDocument doc = XDocument.Load(path);
                    XElement userElement = new XElement("user",
                        new XElement("email", user.Email),
                        new XElement("password", user.Password),
                        new XElement("firstName", user.FirstName),
                        new XElement("lastName", user.LastName)
                    );
                    doc.Root.Add(userElement);
                    doc.Save(path);

                    var form = new SearchFlightsForm();
                    form.Show();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Помилка.");
            }
        }
        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateLength(2, lastNameTextBox.Text))
            {
                lastNameTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина прізвища має бути не менше 2 символів.");
                lastNameTextBox.Focus();
                lastNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateLength(2, firstNameTextBox.Text))
            {
                firstNameTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина імені має бути не менше 2 символів.");
                firstNameTextBox.Focus();
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateLength(5, emailTextBox.Text) || !Contains("@", emailTextBox.Text) || Contains(" ", emailTextBox.Text))
            {
                emailTextBox.ForeColor = Color.Red;
                MessageBox.Show("Неправильний формат поштової адреси.");
                emailTextBox.Focus();
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateLength(8, passwordTextBox.Text))
            {
                passwordTextBox.ForeColor = Color.Red;
                MessageBox.Show("Довжина пароля має бути не менше 8 символів.");
                passwordTextBox.Focus();
                passwordTextBox.ForeColor = Color.Black;

            }
        }

        public static bool ValidateLength(int length, string text)
        {
            return text.Length >= length;
        }
        public bool Contains(string item, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (item.Equals(text[i].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool SearchEmail(string email)
        {
            string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\Users.xml";
            XDocument doc = XDocument.Load(path);
            var emails = doc.Descendants("email");
            foreach (var e in emails)
            {
                if (e.Value == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
