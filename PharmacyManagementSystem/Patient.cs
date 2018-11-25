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

        private string name;
        private string birthDate;
        private int familyDoctorId;
        private int id;
        private string cellNumber;
        private string homeNumber;
        private string officeNumber;
        private string address;
        private string allergies;
        private string maritalStatus;
        private string disorders;
        private string notes;        
        private ArrayList medicineHistory = new ArrayList();
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
        public string Allergies
        {
            get
            {
                return allergies;
            }

            set
            {
                allergies = value;
            }
        }
        public string MaritalStatus
        {
            get
            {
                return maritalStatus;
            }

            set
            {
                maritalStatus = value;
            }
        }
        public string Disorders
        {
            get
            {
                return disorders;
            }

            set
            {
                disorders = value;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
        public ArrayList MedicineHistory
        {
            get
            {
                return medicineHistory;
            }

            set
            {
                medicineHistory = value;
            }
        }
        

        public static ArrayList displayPatients()
        {
            return patients;
        }

        public static void retrievePatients(string name)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT name, DATE_FORMAT(birthDate, \"%m-%d-%Y\") AS birthDate, patientID FROM DixonPatient WHERE name LIKE '" + name + "%' OR name LIKE '% " + name + "%';";
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

            patients.Clear();
            foreach (DataRow row in table.Rows)
            {
                Patient newPatient = new Patient();
                newPatient.Name = row["name"].ToString();
                newPatient.birthDate = row["birthDate"].ToString();
                newPatient.Id = (int)row["patientID"];
                patients.Add(newPatient);
            }
        }

        public void retrieveMedicineHistory()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT m.name, DATE_FORMAT(pr.dateFilled, \"%m-%d-%Y\") AS dateFilled, m.quantity, m.dosage, m.route, " +
                            "m.instructions, m.prescriptionID " +
                            "FROM DixonPatient pa JOIN DixonPrescription pr ON pr.patientID = pa.patientID " +
                            "JOIN DixonMedicine m ON m.prescriptionID = pr.id WHERE pa.patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            MedicineHistory.Clear();
            foreach (DataRow row in table.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Date = row["dateFilled"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicine.PrescriptionID = (int)row["prescriptionID"];
                medicineHistory.Add(medicine);
            }
        }

        public void retrieveMedicalRecord()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT maritalStatus, disorders, allergies, notes " +
                        "FROM DixonMedicalRecord WHERE patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaritalStatus = reader["maritalStatus"].ToString();
                    Disorders = reader["disorders"].ToString();
                    Allergies = reader["allergies"].ToString();
                    Notes = reader["notes"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();        
            Console.WriteLine("Done");
        }

    }
}
