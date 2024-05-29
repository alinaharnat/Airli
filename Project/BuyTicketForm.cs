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
        private Flights curFlight;
        public Flights CurFlights{ get; set; }
        public BuyTicketForm()
        {
            InitializeComponent();
        }
        public BuyTicketForm(Flights flight)
        {
            curFlight = flight;
            InitializeComponent();
        }

        private void BuyTicketForm_Load(object sender, EventArgs e)
        {
            InformationLabel.Text = curFlight.GetInfoAboutFlight(); 
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {

        }
    }
}
