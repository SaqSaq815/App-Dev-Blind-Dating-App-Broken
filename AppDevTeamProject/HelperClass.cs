using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    // Class to manages User class to the form class
    class HelperClass
    {

        private static Root database = Database.LoadDb();

        public List<USER> users = database.USER;

        // Not a good design if we have a huge databse
        // Return true if userId and userPass exist
        public bool VerifyUser(string username, string pass)
        {
         foreach(var v in users)
            {
                if(v.Usernmae == username)
                {
                    if (v.Password.Equals(pass))
                    {
                        return true;               
                    }
                }
            }
            return false;
        }

        public void loadDataToProfile(TextBox text)
        {
            text.Text = users.Count.ToString();
        }
    }
}
