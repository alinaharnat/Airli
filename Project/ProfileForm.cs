using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProfileForm : Form
    {
        private User currentUser;
        public User CurrentUser { get; set; }
        
        public ProfileForm()
        {
            InitializeComponent();

        }
        public ProfileForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            ShowUserInfo();
        }
        public  void ShowUserInfo()
        {
            curUserLastName.Text = currentUser.LastName;
            curUserFirstName.Text = currentUser.FirstName;
            curUserEmail.Text = currentUser.Email;
            curUserPassword.Text = currentUser.Password;
        }
        string path = @"C:\\Users\\alina\\OneDrive\\Робочий стіл\\Project C#\\Project\\Project\\InformationAboutUsers.json";

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (!User.ChangeUserInformation(currentUser,curUserEmail.Text, currentUser.LastName, currentUser.FirstName, currentUser.Password, path))
            {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currentUser.HistoryOfOrders;
        }
    }
}
