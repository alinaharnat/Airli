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
using System.Globalization;


namespace Project
{
    public partial class SearchFlightsForm : Form
    {
        public SearchFlightsForm()
        {
            InitializeComponent();


        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        List<Flights> listFlights = new List<Flights>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var from = fromCityTextBox.Text;
            var to = toCityTextBox.Text;
            var date = datePicker.Value.Date;
            if (!anywhenСheckBox.Checked)
            {
                listFlights = Flights.SearchAvailableFlights(from, to, date, false,path);
            }else if (anywhenСheckBox.Checked)
            {
                listFlights = Flights.SearchAvailableFlights(from, to, date, true, path);
            }
            if(listFlights.Count != 0)
            {
                listFlights = listFlights.OrderBy(x => x.DateTime).ToList();
                dataGridView.DataSource = listFlights;
            }
            else
            {
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
        }
        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DepartureCity"});
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DestinationCity" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IntermediateLandingPoint" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateTime" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FlightDuration" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Carrier" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NumberOfAvailableSeats" });
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
            var form = new ProfileForm();
            form.Show();
        }
    }
}
