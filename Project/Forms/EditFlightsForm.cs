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
using System.Text.Encodings.Web;
using System.IO;
namespace Project
{
    public partial class EditFlightsForm : Form
    {
        Flights flights = new Flights();
        Flight flightForEditing = new Flight();
        public EditFlightsForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;


        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\DataSources\AvaliableFlights.json";
        private void button1_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);
            if (Validation.ValidateLength(2, DepartureCityBox.Text) && Validation.ValidateLength(2, DestinationCityBox.Text))
            {
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
                flights.AddFlight(flight, path);
                MessageBox.Show("Новий рейс успішно додано.");
            }
            else
            {
                MessageBox.Show("Заповніть всі неохідні поля.");
            }
        }

      
        private void RemoveInvalidFlightsButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви справді хочете видалити всі завершені рейси?",  "",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                flights.DeleteInvalidFlights(path);
                MessageBox.Show("Всі завершені рейси видалено.");
            }
        }

        private void EditFlightsButton_Click(object sender, EventArgs e)
        {
            button1.Hide();
            RemoveInvalidFlightsButton.Show();
            FinshEditingutton.Show();
            SearchButton.Show();
            EditFlightsButton.Hide();
            EditButton.Show();
            DeleteButton.Show();
            SaveButton.Show();  

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
            MessageBox.Show("Дані успішно оновлено.");

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
        List<Flight> listFlights = new List<Flight>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);

           
            var from = fromCityTextBox.Text;
            var to = toCityTextBox.Text;
            var date = dateTimePicker1.Value.Date;
            var id = Convert.ToInt32(searchIdUpDown.Value);
            bool anywhen = anywhenСheckBox.Checked;
            bool straight = straightCheckBox.Checked;
           
            listFlights = flights.SearchFlightsForEditing(from, to, date,id, anywhen, straight, path);


            if (listFlights.Count != 0)
            {
                dataGridView.DataSource = listFlights;
                dataGridView.Show();
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
            DeleteButton.Hide();
            EditButton.Show();
            SaveButton.Hide();
            dataGridView.Hide();
            button1.Show();
        }

        private void AddFlightsForm_Load(object sender, EventArgs e)
        {
            EditButton.Hide();
            SearchButton.Hide();
            DeleteButton.Hide();
            RemoveInvalidFlightsButton.Hide();
            FinshEditingutton.Hide();
            dataGridView.Hide();
            SaveButton.Hide();
            flightTimePicker.CustomFormat = "00:00";
            TimePicker.CustomFormat = "00:00";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToFile(dataGridView);
        }
        public void SaveDataGridViewToFile(DataGridView dataGridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Зберегти результати пошуку";
                saveFileDialog.FileName = "results.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        StringBuilder sb = new StringBuilder();

                       
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            sb.Append(column.HeaderText + "\t");
                        }
                        sb.AppendLine();

                 
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    sb.Append(cell.Value?.ToString() + "\t");
                                }
                                sb.AppendLine();
                            }
                        }

                        File.WriteAllText(filePath, sb.ToString());

                        MessageBox.Show("Дані успішно збережено.", "Збереження файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show($"Виникла помилка.");
                    }
                }
            }
        }

        private void sortPriceUp_Click(object sender, EventArgs e)
        {
            listFlights = listFlights.OrderBy(x => x.DateTime).ToList();
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
    }
}
