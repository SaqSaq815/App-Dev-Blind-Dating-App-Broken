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
    public partial class Welcome : Form
    {

        // Main HelperClass reference
        HelperClass h = new HelperClass();
        public Welcome()
        {
            InitializeComponent();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            newUserRegistration newUserForm = new newUserRegistration(h);
            newUserForm.ShowDialog();
            this.Close();
        }

        private void alreadyMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(h);
            login.ShowDialog();
            this.Close();
        }
    }
}
