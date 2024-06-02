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
using System.Text.Json;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class BuyTicketForm : Form
    {
        Flights flights = new Flights();
        Users users = new Users();

        private  Flight curFlight;
        private User curUser;
        public Flight CurFlight { get; set; }
        public User CurUser { get; set; }
        public BuyTicketForm()
        {
            InitializeComponent();
        }
        public BuyTicketForm(Flight flight, User user)
        {
            InitializeComponent();
            curFlight = flight;
            curUser = user;
        }
        string path = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\AvaliableFlights.json";
        string pathUser = @"C:\Users\alina\OneDrive\Робочий стіл\Project C#\Project\Project\InformationAboutUsers.json";
        private void BuyTichetForm_Load(object sender, EventArgs e)
        {
            curFlightInfo.Text = curFlight.GetInfoAboutFlight();
            numSeatsUpDown.Hide();
            numHBUpDown.Hide();
            numRBUpDown.Hide();
            messageLabel.Text = "";


        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            flights = flights.GetAvailableFlights(path);
            users = users.LoadUsersData(pathUser);

            if(GetCheckedSeatType() == "null")
            {
                MessageBox.Show("Оберіть клас місця.");
            }else
            
            if(numSeatsUpDown.Value == 0 )
            {
                MessageBox.Show("Оберіть кiлькість місць.");
            }
            else
            {
                int seats = (int)numSeatsUpDown.Value; 
                int numHB = (int)numHBUpDown.Value;
                int numRB =(int)numRBUpDown.Value; ;
               
                var order = new Order(curFlight, seats, GetCheckedSeatType(), numHB, numRB);
                
                
                flights.UpdateInfo(curFlight, path);
                curUser.HistoryOfOrders.Add(order);

                users.ChangeHistory(curUser, pathUser);
            
                curFlightInfo.Text = curFlight.GetInfoAboutFlight();
                buyPanel1.Hide();
                
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
                else if(curFlight.SeatsEconom < numSeatsUpDown.Value)
                {
                    EconomyRadioButton.Checked = false;
                    MessageBox.Show("Немає даної кількості вільних місць.");
                }
                else
                {
                    numSeatsUpDown.Show();
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
                else if (curFlight.SeatsBuisiness < numSeatsUpDown.Value)
                {
                    BuisinessRadioButton.Checked = false;
                    MessageBox.Show("Немає даної кількості вільних місць.");
                }
                else
                {
                    numSeatsUpDown.Show();
                }
            }
            
        }

        private void FirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
            if (FirstRadioButton.Checked)
            {
                if (curFlight.SeatsFirst == 0 )
                {
                    FirstRadioButton.Checked = false;
                    MessageBox.Show("Немає вільних місць.");
                }else if(curFlight.SeatsFirst < numSeatsUpDown.Value)
                {
                    FirstRadioButton.Checked = false;
                   
                    MessageBox.Show("Немає даної кількості вільних місць.");
                }
                else
                {
                    numSeatsUpDown.Show();
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numHBUpDown.Show();
            }
            else
            {
                numHBUpDown.Value = 0;
                numHBUpDown.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                numRBUpDown.Show();
            }
            else
            {
                numRBUpDown.Value = 0;
                numRBUpDown.Hide();
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

        private void numSeatsUpDown_ValueChanged(object sender, EventArgs e)
        {
           
            var t = GetCheckedSeatType();
            switch (t)
            {
                case "econom":
                    if (numSeatsUpDown.Value > curFlight.SeatsEconom)
                    {
                        MessageBox.Show("Немає даної кількості вільних місць.");
                        numSeatsUpDown.Value = 0;
                        

                    }
                    break;
                case "business":
                    if (numSeatsUpDown.Value > curFlight.SeatsBuisiness)
                    {
                        MessageBox.Show("Немає даної кількості вільних місць.");
                        numSeatsUpDown.Value = 0;

                    }
                    break;
                case "first":
                    if (numSeatsUpDown.Value > curFlight.SeatsFirst)
                    {
                        MessageBox.Show("Немає даної кількості вільних місць.");
                        numSeatsUpDown.Value = 0;

                    }
                    break;
                
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            
                this.Close();
                var form = new SearchFlightsForm(curUser);
                form.Show();
            
            

        }
    }
}
