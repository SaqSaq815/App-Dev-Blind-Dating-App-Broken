﻿using System;
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
        HelperClass h = new HelperClass();
        public Login()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
            this.Hide();
            Profile prof = new Profile();
            prof.ShowDialog();
            this.Close();
=======
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


    
>>>>>>> Stashed changes

            string username = loginUsernameTextBox.Text;
            string pwd = loginPasswordTextbox.Text;
            
            if(h.VerifyUser(username, pwd))
            {
              

            }


    

        }



       
    }
}
