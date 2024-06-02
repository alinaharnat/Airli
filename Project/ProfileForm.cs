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
            SaveButton.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveButton.Show();
            SaveTextFile(dataGridView);

        }
        //saving to file
        public void SaveDataGridViewToTextFile(DataGridView dataGV, string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    
                    for (int i = 0; i < dataGV.Columns.Count; i++)
                    {
                        sw.Write(dataGV.Columns[i].HeaderText);
                        if (i < dataGV.Columns.Count - 1)
                        {
                            sw.Write("     "); 
                        }
                    }
                    sw.WriteLine();

                    
                    for (int i = 0; i < dataGV.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGV.Columns.Count; j++)
                        {
                            sw.Write(dataGV.Rows[i].Cells[j].Value?.ToString());
                            if (j < dataGV.Columns.Count - 1)
                            {
                                sw.Write("\t");
                            }
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Дані збережено успішно!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        public void SaveTextFile(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                sfd.FileName = "data.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveDataGridViewToTextFile(dgv, sfd.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new SearchFlightsForm(currentUser);
            form.Show();
        }
    }
}
