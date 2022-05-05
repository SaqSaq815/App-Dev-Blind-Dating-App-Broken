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
    public partial class matchProfile : Form
    {
        public matchProfile()
        {
            InitializeComponent();
        }

        private void mpReportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for reporting.Proper action is now taken in place", "REPORTED" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void thumbsDownBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You accepted the match up! Enjoy your date!", "ACCPET MATCH!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thumbsUpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You declined the match up! Check out your other match up", "DECLINED MATCH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            Profile prof = new Profile();
            prof.ShowDialog();
            this.Close();
        }
    }
}
