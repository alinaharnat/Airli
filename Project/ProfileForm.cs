using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Project
{
    public partial class ProfileForm : Form
    {
        Users users = new Users();
        Flights flights = new Flights();

        private User currentUser;
        public User CurrentUser { get { return currentUser; } set { currentUser = value; } }
        
        public ProfileForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;

        }
        public ProfileForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            ShowUserInfo();
            dataGridView.AutoGenerateColumns = false;
        }
        public  void ShowUserInfo()
        {
            curUserLastName.Text = currentUser.LastName;
            curUserFirstName.Text = currentUser.FirstName;
            curUserEmail.Text = currentUser.Email;
            curUserPassword.Text = currentUser.Password;
        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\InformationAboutUsers.json";

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            users = users.LoadUsersData(path);
            if (!users.ChangeUserInformation(currentUser, currentUser.Email, curUserPassword.Text, curUserLastName.Text, curUserFirstName.Text, path))
            {
                ShowUserInfo();
                MessageBox.Show("Введені дані не відповідають вимогам.");
            }
            else
            {
                MessageBox.Show("Інформацію оновлено.");
            }


        }

        private void curUserLastName_TextChanged(object sender, EventArgs e)
        {
           currentUser.LastName = curUserLastName.Text;
        }

        private void curUserFirstName_TextChanged(object sender, EventArgs e)
        {
           currentUser.FirstName = curUserFirstName.Text;
        }

        private void curUserPassword_TextChanged(object sender, EventArgs e)
        {
           currentUser.Password = curUserPassword.Text;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new SearchFlightsForm(currentUser);
            form.Show();
        }

       

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
            dataGridView.DataSource = currentUser.HistoryOfOrders;
           
          
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            dataGridView.Hide();
        }
    }
}
