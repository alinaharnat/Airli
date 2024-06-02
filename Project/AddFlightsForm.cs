using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddFlightsForm : Form
    {
        Flights flights = new Flights();
        Flight flightForEditing = new Flight();
        public AddFlightsForm()
        {
            InitializeComponent();
           
        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        private void button1_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);
            var flight = new Flight()
            {
                DepartureCity = DepartureCityBox.Text,
                DestinationCity = DestinationCityBox.Text,
                IntermediateLandingPoint = IntermediateLandingPointBox.Text,
                DateTime = datePicker.Value.Date + flightTimePicker.Value.TimeOfDay,
                Id = (int)idUpDown.Value,
                Price = (double)priceUpDown.Value,
                FlightDuration = TimePicker.Value.TimeOfDay,
                Carrier = CarrierBox.Text,
                SeatsEconom = (int)economUpDown.Value,
                SeatsBuisiness = (int)businessUpDown.Value,
                SeatsFirst = (int)firstUpDown.Value,
                NumberOfAvailableSeats = (int)economUpDown.Value + (int)businessUpDown.Value + (int)firstUpDown.Value,

            };
            flights.AddFlight(flight,path);
        }

      
        private void RemoveInvalidFlightsButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви справді хочете видалити всі пройшовші рейси?",  "",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                flights.DeleteInvalidFlights(path);
                MessageBox.Show("Всі пройшовші рейси видалено.");
            }
        }

        private void EditFlightsButton_Click(object sender, EventArgs e)
        {
            button1.Hide();
            RemoveInvalidFlightsButton.Show();
            FinshEditingutton.Show();
            SearchButton.Hide();


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                flightForEditing = (Flight)selectedRow.DataBoundItem;
                DepartureCityBox.Text = flightForEditing.DepartureCity;
                DestinationCityBox.Text = flightForEditing.DestinationCity;
                IntermediateLandingPointBox.Text = flightForEditing.IntermediateLandingPoint;
                datePicker.Value = flightForEditing.DateTime.Date;
                flightTimePicker.Value = DateTime.Today.Add(flightForEditing.DateTime.TimeOfDay);
                idUpDown.Value= flightForEditing.Id;
                priceUpDown.Value = (decimal)flightForEditing.Price;
                TimePicker.Value = DateTime.Today.Add(flightForEditing.FlightDuration);
                CarrierBox.Text = flightForEditing.Carrier;
                economUpDown.Value = flightForEditing.SeatsEconom;
                businessUpDown.Value =flightForEditing.SeatsBuisiness;
                firstUpDown.Value = flightForEditing.SeatsFirst;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            flightForEditing.DepartureCity = DepartureCityBox.Text;
            flightForEditing.DestinationCity = DestinationCityBox.Text;
            flightForEditing.IntermediateLandingPoint = IntermediateLandingPointBox.Text;
            flightForEditing.DateTime = datePicker.Value.Date + flightTimePicker.Value.TimeOfDay;
            flightForEditing.Id = (int)idUpDown.Value;
            flightForEditing.Price = (double)priceUpDown.Value;
            flightForEditing.FlightDuration = TimePicker.Value.TimeOfDay;
            flightForEditing.Carrier = CarrierBox.Text;
            flightForEditing.SeatsEconom = (int)economUpDown.Value;
            flightForEditing.SeatsBuisiness = (int)businessUpDown.Value;
            flightForEditing.SeatsFirst = (int)firstUpDown.Value;
            flightForEditing.NumberOfAvailableSeats = (int)economUpDown.Value + (int)businessUpDown.Value + (int)firstUpDown.Value;   
            
            flights.UpdateInfo(flightForEditing, path);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви справді хочете видалити рейс?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                flights.RemoveFlight(flightForEditing,path);
                MessageBox.Show("Рейс видалено.");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);

            dataGridView.Show();
            var from = fromCityTextBox.Text;
            var to = toCityTextBox.Text;
            var date = datePicker.Value.Date;
            var id = (int)searchIdUpDown.Value;
            bool anywhen = anywhenСheckBox.Checked;
            bool straight = straightCheckBox.Checked;
            var listFlights = new List<Flight>();
            listFlights = flights.SearchFlightsForEditing(from, to, date, id, anywhen, straight, path);


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

        private void FinshEditingutton_Click(object sender, EventArgs e)
        {
            FinshEditingutton.Hide();
            RemoveInvalidFlightsButton.Hide();
            SearchButton.Hide();

        }

        private void AddFlightsForm_Load(object sender, EventArgs e)
        {
            SearchButton.Hide();
       
            RemoveInvalidFlightsButton.Hide();
            FinshEditingutton.Hide();
            dataGridView.Hide();
        }

        
    }
}
