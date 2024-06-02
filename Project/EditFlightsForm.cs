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
    public partial class EditFlightsForm : Form
    {
        Flights flights = new Flights();    

        public EditFlightsForm()
        {
            InitializeComponent();
        }

        private void EditFlightsForm_Load(object sender, EventArgs e)
        {
            dataGridView.Hide();

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
            var id = (int)IdUpDown.Value;
            bool anywhen = anywhenСheckBox.Checked;
            bool straight = straightCheckBox.Checked;

            listFlights = flights.SearchFlightsForEditing(from, to, date,id, anywhen, straight, path);


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

        private void dateSortButton_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderBy(x => x.DateTime).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = listFlights;
        }

        private void anywhenСheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
