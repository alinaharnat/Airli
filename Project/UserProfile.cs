using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project
{
    public partial class UserProfile : Form
    {
        private User currentUser;
        public UserProfile()
        {
            InitializeComponent();
        }
        public UserProfile(User user)
        {
           currentUser = user;
        }
        string path = @"C:\\Users\\alina\\OneDrive\\Робочий стіл\\Project C#\\Project\\Project\\InformationAboutUsers.json";
        //string data = File.ReadAllText(path);
        //var users = JsonConvert.DeserializeObject<List<User>>(data);
        //var newUser = users.FirstOrDefault(user => user.Email == email);
    }
}
