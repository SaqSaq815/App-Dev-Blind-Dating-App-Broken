using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void profileLogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileNotificationsBtn_Click(object sender, EventArgs e)
        {
         
            Notifications notif = new Notifications();
            notif.ShowDialog();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matchProfile mpf = new matchProfile();
            mpf.ShowDialog();
        }
    }
}
