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
    public partial class Login : Form
    {
        // Helper Class object
<<<<<<< Updated upstream
        HelperClass h = new HelperClass();
        public Login()
=======
        HelperClass h;
        public Login(HelperClass helperClass)
>>>>>>> Stashed changes
        {
            InitializeComponent();
            h = helperClass;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.Hide();
            Profile prof = new Profile();
            prof.ShowDialog();
            this.Close();
=======
=======
>>>>>>> Stashed changes
            alertInvalidAccountLabel.Visible = false;
            string username = loginUsernameTextBox.Text;
            string pwd = loginPasswordTextbox.Text;
            
            if(h.VerifyUser(username, pwd))
            {

                this.Hide();
                Profile prof = new Profile(h.loadCurrentUser(), h);
                prof.ShowDialog();
                this.Close();
              
            }
            else
            {
                alertInvalidAccountLabel.Visible = true;
            }


    
<<<<<<< Updated upstream
>>>>>>> Stashed changes

            string username = loginUsernameTextBox.Text;
            string pwd = loginPasswordTextbox.Text;
            
            if(h.VerifyUser(username, pwd))
            {
              

            }


    
=======
>>>>>>> Stashed changes

        }



       
    }
}
