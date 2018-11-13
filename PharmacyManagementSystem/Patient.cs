using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace PharmacyManagementSystem
{
    class Patient
    {
        private static ArrayList patients = new ArrayList();

        private String name;
        private String birthDate;
        private int familyDoctorId;
        private int id;
        private String cellNumber;
        private String homeNumber;
        private String officeNumber;
        private String address;
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
        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }
        public int FamilyDoctorId
        {
            get
            {
                return familyDoctorId;
            }

            set
            {
                familyDoctorId = value;
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
        public string CellNumber
        {
            get
            {
                return cellNumber;
            }

            set
            {
                cellNumber = value;
            }
        }    
        public string HomeNumber
        {
            get
            {
                return homeNumber;
            }

            set
            {
                homeNumber = value;
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
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public static Patient retrievePatientDetails(int patientId)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT p.name, p.patientID, p.birthDate, p.saddress1, p.saddress2, p.city, p.state, p.country, p.zip, d.id, n.cellNumber, n.homeNumber, n.officeNumber " +
                            "FROM DixonPatient p JOIN DixonDoctor d ON p.familyDoctor = d.id JOIN DixonPhoneNumber n ON p.phoneNumber = n.id " +
                            "WHERE p.patientID = @id; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", patientId);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            Patient newPatient = new Patient();
            newPatient.Name = table.Rows[0]["name"].ToString();
            newPatient.Id = (int)table.Rows[0]["patientId"];
            newPatient.BirthDate = table.Rows[0]["birthDate"].ToString();
            newPatient.FamilyDoctorId = (int)table.Rows[0]["id"];
            newPatient.Address = table.Rows[0]["saddress1"].ToString() + " " + table.Rows[0]["saddress2"].ToString() + " " + 
                table.Rows[0]["city"].ToString() + " " + table.Rows[0]["state"].ToString() + " " + 
                table.Rows[0]["country"].ToString() + " " + table.Rows[0]["zip"].ToString();
            newPatient.CellNumber = table.Rows[0]["cellNumber"].ToString();
            newPatient.HomeNumber = table.Rows[0]["homeNumber"].ToString();
            newPatient.OfficeNumber = table.Rows[0]["officeNumber"].ToString();

            return newPatient;
        }

        public static ArrayList retrievePatients(string name)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT name, birthDate FROM DixonPatient WHERE name LIKE '" + name + "%' OR name LIKE '% " + name + "%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            ArrayList patients = new ArrayList();
            foreach (DataRow row in table.Rows)
            {
                Patient newPatient = new Patient();
                newPatient.Name = row["name"].ToString();
                newPatient.birthDate = row["birthDate"].ToString();
                patients.Add(newPatient);
            }
            return patients;
        }

        public static ArrayList displayPatients()
        {
            return patients;
        }

    }
}
