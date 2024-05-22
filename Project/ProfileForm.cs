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
    public partial class ProfileForm : Form
    {
        private User currentUser;
        public User CurrentUser { get; set; }
        public ProfileForm()
        {
            InitializeComponent();

        }
        public ProfileForm(User user)
        {
            currentUser = user;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
