using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Doctor
    {
        private static List<Doctor> doctors = new List<Doctor>();

        public static void retrieveDoctors()
        {
            // SQL here, store results in doctors List
        }

        public static List<Doctor> displayDoctors()
        {
            return doctors;
        }

    }

}
