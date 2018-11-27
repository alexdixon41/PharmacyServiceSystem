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
        private string name;
        private string officeName;
        private string officeNumber;
        private int id;
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

        public static ArrayList displayDoctors()
        {
            return doctors;
        }

    }

}
