using Newtonsoft.Json.Linq;
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
    public partial class AddFlightsForm : Form
    {
        Flights flights = new Flights();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
              flights.DeleteInvalidFlights(path);
        }
    }
}
