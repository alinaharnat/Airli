using System.Text.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;


namespace Project
{
    public partial class SearchFlightsForm : Form
    {
        Flights flights = new Flights();
        private User currentUser;
        public SearchFlightsForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;

        }
        public SearchFlightsForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;


        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        List<Flight> listFlights = new List<Flight>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);

            dataGridView.Show();
            var from = fromCityTextBox.Text;
            var to = toCityTextBox.Text;
            var date = datePicker.Value.Date;
            bool anywhen = anywhenСheckBox.Checked;
            bool straight = straightCheckBox.Checked;   
  
            listFlights = flights.SearchAvailableFlights(from, to, date, anywhen, straight, path);
             
           
            if (listFlights.Count != 0)
            {
                dataGridView.DataSource = listFlights;
            }
            else
            {
                dataGridView.Hide();
                MessageBox.Show("Рейсів не знайдено.");
            }

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

            datePicker.CustomFormat = "dd-MM-yyyy";

        }

        private void SearchFlightsForm_Load(object sender, EventArgs e)
        {
            datePicker.CustomFormat = " ";
            datePicker.Format = DateTimePickerFormat.Custom;
            dataGridView.Hide();
        }

        private void sortPriceUp_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderBy(x => x.Price).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }

        private void sortPriceDown_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderByDescending(x => x.Price).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }

        private void numberOfSeatsUp_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderBy(x => x.NumberOfAvailableSeats).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }

        private void numberOtSeatsDown_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderByDescending(x => x.NumberOfAvailableSeats).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ProfileForm(currentUser);
            form.Show();
        }



        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                var selectedIteam = (Flight)selectedRow.DataBoundItem;
                this.Hide();
                var form = new BuyTicketForm(selectedIteam, currentUser);
                form.Show();
            }
        }

        private void dateSortButton_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderBy(x => x.DateTime).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }
    }
}