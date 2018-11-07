using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Patient
    {
        private static List<Patient> patients = new List<Patient>();

        public static void retrievePatients()
        {
            //SQL here, store results to patients List
        }

        public static List<Patient> displayPatients()
        {
            return patients;
        }

    }
}
