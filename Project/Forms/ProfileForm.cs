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
       private  Users users ;
        Flights flights = new Flights();

        private User currentUser;
        public User CurrentUser { get { return currentUser; } set { currentUser = value; } }
        
        public ProfileForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;

        }
        public ProfileForm(User user, Users allUsers)
        {
            users = allUsers;
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
            var form = new SearchFlightsForm(currentUser, users);
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                var selectedIteam = (Order)selectedRow.DataBoundItem;

                SaveTextFile(selectedIteam.InfoOrder);
            }
           

        }
        private void SaveTextFile(string infoOrder)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Зберегти інформацію про бронювання";
                saveFileDialog.FileName = "Ticket.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                       
                        File.WriteAllText(filePath, infoOrder);

                        MessageBox.Show("Інформація успішно збережена.", "Збереження файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Виникла помилка.");
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new SearchFlightsForm(currentUser,users);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
