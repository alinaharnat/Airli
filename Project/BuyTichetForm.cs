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
        private User curUser;
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

        private void BuyTichetForm_Load(object sender, EventArgs e)
        {
            curFlightInfo.Text = curFlight.GetInfoAboutFlight();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
