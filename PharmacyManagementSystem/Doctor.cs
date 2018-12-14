using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Doctor
    {
        private string name;                               //name of the doctor
        private string officeName;                         //name of the office the doctor works for
        private string officeNumber;                       //office number of the doctor
        private int id;                                    //id of the doctor

        //public properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        } 
        public string OfficeName
        {
            get
            {
                return officeName;
            }

            set
            {
                officeName = value;
            }
        }
        public string OfficeNumber
        {
            get
            {
                return officeNumber;
            }

            set
            {
                officeNumber = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private static ArrayList doctors = new ArrayList();     
                

        /// <summary>
        /// Retrieve doctors from the database matching the specified name
        /// </summary>
        /// <param name="searchKey">The name string to search for</param>
        public static void retrieveDoctors(string searchKey)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql =
                    @"SELECT doc.name, doc.id, doc.officeName, ph.officeNumber 
                    FROM DixonDoctor doc LEFT OUTER JOIN DixonPhoneNumber ph ON doc.phoneNumber = ph.id
                    WHERE doc.name LIKE @search1 OR doc.name LIKE @search2;"; 
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@search1", searchKey + "%");
                cmd.Parameters.AddWithValue("@search2", "% " + searchKey + "%");
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            doctors.Clear();
            foreach (DataRow row in table.Rows)
            {                
                Doctor doctor = new Doctor();
                doctor.Name = row["name"].ToString();
                doctor.Id = (int)row["id"];
                doctor.OfficeName = row["officeName"].ToString();
                doctor.OfficeNumber = row["officeNumber"].ToString();
                doctors.Add(doctor);
            }
        }

        /// <summary>
        /// Return the list of doctors retrieved from the search.
        /// </summary>
        /// <returns></returns>
        public static ArrayList displayDoctors()
        {
            return doctors;
        }

    }

}
