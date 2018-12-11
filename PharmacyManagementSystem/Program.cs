using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
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
            Application.Run(new Login());

            if (Login.loginSuccess)
            {
                //TODO [TEAM PROJECT] Add cases for other user types
                if (User.Type == User.PHARMACIST_USER_TYPE)
                {
                    Notice.retrieveNotices();
                    Prescription.retrieveNewPrescriptions();
                    RefillRequest.retrieveRefillRequests();
                    Application.Run(new MainMenu());
                }
                
            }
        }
    }
}
