using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTeamProject
{
    // Class to manages User class to the form class
    class HelperClass
    {
        // Arrays of members
        private int[] userId;
        private string[] userPass;


        // Not a good design if we have a huge databse
        // Return true if userId and userPass exist
        public bool VerifyUser(int id, int pass)
        {
            for(int i = 0; i < userId.Length; i++)
            {
                if(userId[i] == id )
                {
                    for(int j = 0; j < userPass.Length; j++)
                    {
                        if (userPass[j].Equals(pass))
                        {
                            return true;
                        }
                        break;
                    }
                }
                
            }
            return false;
        }


    }
}
