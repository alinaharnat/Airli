﻿using Newtonsoft.Json;
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
        //private User currentUser;
        private User currentUser;
        public SearchFlightsForm()
        {
            InitializeComponent();
            
        }
        public SearchFlightsForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;


        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        List<Flights> listFlights = new List<Flights>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView.Show();
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
                var selectedIteam = (Flights)selectedRow.DataBoundItem;
                var form = new BuyTicketForm(selectedIteam,currentUser);
                form.Show();
            }
        }
    }
}
