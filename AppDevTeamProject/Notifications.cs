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
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void notificationsViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            matchProfile mpf = new matchProfile();
            mpf.ShowDialog();
            this.Close();
            
        }

        private void notificationsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
