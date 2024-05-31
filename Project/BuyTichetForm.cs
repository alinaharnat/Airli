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
    public partial class BuyTicketForm : Form
    {
        private  Flights curFlight;
        public User curUser;
        public Flights CurFlight { get; }
        public User CurUser { get; set; }
        public BuyTicketForm()
        {
            InitializeComponent();
        }
        public BuyTicketForm(Flights curFlight, User curUser)
        {
            InitializeComponent();
            this.curFlight = curFlight;
            this.curUser = curUser;
        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        string pathUser = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\InformationAboutUsers.json";
        private void BuyTichetForm_Load(object sender, EventArgs e)
        {
            curFlightInfo.Text = curFlight.GetInfoAboutFlight();
            handBaggageTextBox.Hide();
            registBaggageTextBox.Hide();
            messageLabel.Text = "";


        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if(GetCheckedSeatType() == "null")
            {
                MessageBox.Show("Оберіть клас місця.");
            }
            else if(numSeatsTextBox.Text.Length == 0)
            {
                MessageBox.Show("Оберіть кiлькість місць.");
            }
            else
            {
                var seats = Convert.ToInt32(numSeatsTextBox.Text);
                var numHB = Convert.ToInt32(numSeatsTextBox.Text);
                var numRB = Convert.ToInt32(numSeatsTextBox.Text);
                var order = new Order(curUser,curFlight,seats,GetCheckedSeatType(),numHB,numRB);
                Flights.ChangeFlightInformation(curFlight,path);
                User.ChangeHistory(curUser, pathUser);
                BuyPanel.Hide();
                messageLabel.Text = $"Замовлення успішно сформовано!\nЗагальна вартість замовлення:{order.TotalPrice}";



            }
        }

        private void EconomyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EconomyRadioButton.Checked)
            {
                if (curFlight.SeatsEconom == 0)
                {
                    EconomyRadioButton.Checked = false;
                    MessageBox.Show("Немає вільних місць.");
                }
            }
            
        }

        private void BuisinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BuisinessRadioButton.Checked)
            {
                if (curFlight.SeatsBuisiness == 0)
                {
                    BuisinessRadioButton.Checked = false;
                    MessageBox.Show("Немає вільних місць.");
                }
            }
        }

        private void FirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstRadioButton.Checked)
            {
                if (curFlight.SeatsFirst == 0)
                {
                    FirstRadioButton.Checked = false;
                    MessageBox.Show("Немає вільних місць.");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                handBaggageTextBox.Show();
            }
            else
            {
                handBaggageTextBox.Clear();
                handBaggageTextBox.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                registBaggageTextBox.Show();
            }
            else
            {
                registBaggageTextBox.Clear();
                registBaggageTextBox.Hide();
            }
        }

        private void handBaggageTextBox_Leave(object sender, EventArgs e)
        {
            if(!Validation.ValidateNumber(handBaggageTextBox.Text) || handBaggageTextBox.Text.Length<1 || handBaggageTextBox.Text.Length > 5)
            {
                MessageBox.Show("Значення має бути в межах від 1 до 5");
                handBaggageTextBox.Clear();
                checkBox1.Checked = false;
            }
        }

        private void registBaggageTextBox_Leave(object sender, EventArgs e)
        {
            if (!Validation.ValidateNumber(registBaggageTextBox.Text) || registBaggageTextBox.Text.Length < 1 || registBaggageTextBox.Text.Length > 5)
            {
                MessageBox.Show("Значення має бути в межах від 1 до 5");
                registBaggageTextBox.Clear();
                checkBox2.Checked = false;
            }
        }
        bool validNumberOfSeats = true;
        private void numSeatsTextBox_Leave(object sender, EventArgs e)
        {
            validNumberOfSeats = true;
            if (!Validation.ValidateNumber(numSeatsTextBox.Text))
            {
                MessageBox.Show("Кількість місць має бути числовим значенням.");
                numSeatsTextBox.Clear();
                validNumberOfSeats = false;
            }
            else
            {
                var value = Convert.ToInt32(numSeatsTextBox.Text);
                if(value < 0 || value == 0)
                {
                    MessageBox.Show("Значення не може бути від'ємним або дорівнювати нулю.");
                    numSeatsTextBox.Clear();
                    validNumberOfSeats = false;
                }
                else
                {

                    var t = GetCheckedSeatType();
                    switch(t)
                    {
                        case "econom":
                            if (value > curFlight.SeatsEconom)
                            {
                                MessageBox.Show("Немає даної кількості вільних місць.");
                                numSeatsTextBox.Clear();
                                validNumberOfSeats = false;
                            }
                            break;
                        case "business":
                            if (value > curFlight.SeatsBuisiness)
                            {
                                MessageBox.Show("Немає даної кількості вільних місць.");
                                numSeatsTextBox.Clear();
                                validNumberOfSeats = false;
                            }
                            break;
                        case "first":
                            if (value > curFlight.SeatsFirst)
                            {
                                MessageBox.Show("Немає даної кількості вільних місць.");
                                numSeatsTextBox.Clear();
                                validNumberOfSeats = false;
                            }
                            break;
                        default:
                            numSeatsTextBox.Clear();
                            MessageBox.Show("Оберіть клас місця.");
                            validNumberOfSeats = false;
                            break;
                    }
                }
            }
        }
        private string GetCheckedSeatType()
        {
            if (EconomyRadioButton.Checked)
            {
                return "econom";
            }
            if (BuisinessRadioButton.Checked)
            {
                return "business";
            }
            if (FirstRadioButton.Checked)
            {
                return "first";
            }
            return "null";
        }

        private void numSeatsTextBox_TextChanged(object sender, EventArgs e)
        {
            validNumberOfSeats = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
