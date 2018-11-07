using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Prescription
    {      
        private static List<Prescription> prescriptions = new List<Prescription>();

        private const int SEARCH_BY_PATIENT = 0;
        private const int SEARCH_BY_DOCTOR = 1;

        public static List<Prescription> prescriptionSearch(int searchTypeCode)
        {
            retrievePrescriptions(searchTypeCode);
            return displayPrescriptions();
        }

        /// <summary>
        /// Execute SQL query to retrieve prescriptions matching user's search parameters
        /// </summary>
        public static void retrievePrescriptions(int searchTypeCode)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                if (searchTypeCode == SEARCH_BY_DOCTOR)
                {
                    sql = "SELECT * FROM dixonprescription";
                }
                else
                {
                    sql = "SELECT * FROM dixonprescription WHERE ";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                /*cmd.Parameters.AddWithValue("@phyId", phyID);         // add parameter values to SQL query
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

        }

        public static List<Prescription> displayPrescriptions()
        {
            return prescriptions;
        }
    }
}
