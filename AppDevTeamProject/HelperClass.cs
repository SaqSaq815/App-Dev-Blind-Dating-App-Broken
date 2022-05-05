using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppDevTeamProject
{
    // Class to manages User class to the form class
    class HelperClass
    {
        // Arrays of members
        Database db;

        // Not a good design if we have a huge databse
        // Return true if userId and userPass exist
        public bool VerifyUser(int id, int pass)
        {

            foreach (User x in db.members)
            {
                if (x.ID == id)
                {
                    if (x.Password.Equals(pass))
                    {
                        return true;
                    }
                    break;
                }
            }
            return false;
        }

    }
}
