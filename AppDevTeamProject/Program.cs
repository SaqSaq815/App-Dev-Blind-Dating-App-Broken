using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            //Application.Run(new Welcome());
            Application.Run(new TestControl());
=======
            Application.Run(new Welcome());
            //Application.Run(new TestControl());
>>>>>>> Stashed changes
=======
            Application.Run(new Welcome());
            //Application.Run(new TestControl());
>>>>>>> Stashed changes
        }
    }
}
