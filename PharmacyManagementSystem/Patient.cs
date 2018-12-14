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
        private static ArrayList patients = new ArrayList();      //list of patients

        private string name;                                      //name of the patient
        private string birthDate;                                 //birth date of the patient
        private int familyDoctorId;                               //id of the patient's family doctor
        private int id;                                           //id of the patient
        private string cellNumber;                                //cell phone number of the patient
        private string homeNumber;                                //home phone number of the patient
        private string officeNumber;                              //office phone number of the patient
        private string address;                                   //address of the patient
        private string allergies;                                 //list of the patient's allergies
        private string maritalStatus;                             //marital status of the patient
        private string disorders;                                 //list of the patient's disorders
        private string notes;                                     //notes about the patient 
        private int weight;                                       //weight of the patient
        private int height;                                       //height of the patient
        private double bodyMassIndex;                             //body mass index of the patient
        private ArrayList medicineHistory = new ArrayList();      //list of medicines the patient has had in the past

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
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }    
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
        public double BodyMassIndex
        {
            get
            {
                return bodyMassIndex;
            }

            set
            {
                bodyMassIndex = value;
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

        //return the list of patients
        public static ArrayList displayPatients()
        {
            return patients;
        }

        /// <summary>
        /// Retrieve all patients with name matching the searchKey string.
        /// </summary>
        /// <param name="searchKey">The search string input by the user</param>
        public static void retrievePatients(string searchKey)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT name, DATE_FORMAT(birthDate, ""%m-%d-%Y"") AS birthDate, patientID FROM DixonPatient 
                            WHERE name LIKE @searchKey1 OR name LIKE @searchKey2;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@searchKey1", "" + searchKey + "%");
                cmd.Parameters.AddWithValue("@searchKey2", "% " + searchKey + "%");
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

        /// <summary>
        /// Retrieve all previous medicines the patient has had from the database.
        /// </summary>
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

            MedicineHistory.Clear();                  //remove medicines from medicineHistory before adding all of them
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

        /// <summary>
        /// Retrieve the medical record information for the patient from the database.
        /// </summary>
        public void retrieveMedicalRecord()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT height, weight, maritalStatus, disorders, allergies, notes " +
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
                    Height = (int)reader["height"];
                    Weight = (int)reader["weight"];
                    BodyMassIndex = Weight * .45 / (Height * Height * .000625);
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
