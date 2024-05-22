using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project
{
    public partial class SearchFlightsForm : Form
    {
        public SearchFlightsForm()
        {
            InitializeComponent();
            datePicker.CustomFormat = " "; 
            datePicker.Format = DateTimePickerFormat.Custom;
        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var from = fromCityTextBox.Text;
            var to = toCityTextBox.Text;
            var date = datePicker.Value.Date;
            var flights = Flights.GetAvaliableFlights(path);

            var res = new List<Flights>();
            foreach (var flight in flights)
            {
                if (flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) &&
                    flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) &&
                    flight.DateTime.Date == date)
                {
                    res.Add(flight);
                }
            }
            dataGridView.DataSource = res;
        }
        

        private void SearchFlightsForm_Load(object sender, EventArgs e)
        {

        }
 
    }
}
