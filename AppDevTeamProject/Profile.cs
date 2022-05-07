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

        public HelperClass h;
        public USER currentUser;
        public Profile(USER usr, HelperClass h)
        {
            InitializeComponent();
            currentUser = usr;
            this.h = h;


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

        private void Profile_Load(object sender, EventArgs e)
        {
           

            profilePhotoPictureBox.Image =
               (Image)(Properties.Resources.ResourceManager.GetObject(currentUser.Avatar));


            firstNameTextBox.Text = currentUser.FirstName;
            lastNameTextBox.Text = currentUser.LastName;
            ageTextBox.Text = currentUser.Age.ToString();
            genderTextBox.Text = currentUser.Gender;
            locationTextBox.Text = currentUser.Location;
            foreach( string trait in currentUser.Traits)
            {
                traitsTextBox.Text += trait.ToUpper() + Environment.NewLine;
            }
            foreach (string like in currentUser.Likes)
            {
                likesTextBox.Text += like.ToUpper() + Environment.NewLine;
            }
            bioLabel.Text = currentUser.Bio;
            currentLoginLabel.Text = currentUser.Usernmae;
        }
    }
}
