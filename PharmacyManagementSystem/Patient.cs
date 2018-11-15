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
        private string allergies;        
        private ArrayList medicineHistory;
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

        /// <summary>
        /// Gets information about the patient of the selected prescription.
        /// </summary>
        /// <param name="selectedPrescriptionIndex">The index of the prescriptions list where the selected prescription
        /// is located.</param>
        /// <returns></returns>
        public static Patient retrievePatientDetails(int selectedPrescriptionIndex)
        {
            Patient patient = new Patient();
            DataTable patientTable = new DataTable();
            DataTable prescriptionDetailTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT DATE_FORMAT(pr.dateFilled, \"%m-%d-%Y\") AS 'date', m.name, m.quantity, m.dosage, " +
                            "m.route, m.instructions, m.prescriptionID " +
                            "FROM DixonPatient pa JOIN DixonPrescription pr ON pr.patientID = pa.patientID " +
                            "JOIN DixonMedicine m ON m.prescriptionID = pr.id WHERE pa.patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Prescription prescription = (Prescription)Prescription.displayPrescriptions()[selectedPrescriptionIndex];
                cmd.Parameters.AddWithValue("@id", prescription.PatientId);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(patientTable);

                sql = "SELECT p.name, p.patientID, p.birthDate, p.saddress1, p.saddress2, p.city, p.state, " +
                            "p.country, p.zip, p.allergies, d.id, n.cellNumber, n.homeNumber, n.officeNumber " +
                            "FROM DixonPatient p JOIN DixonDoctor d ON p.familyDoctor = d.id JOIN DixonPhoneNumber n ON p.phoneNumber = n.id " +
                            "WHERE p.patientID = @id; ";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", prescription.PatientId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    patient.Name = reader["name"].ToString();
                    patient.Id = (int)reader["patientID"];
                    patient.BirthDate = reader["birthDate"].ToString();
                    patient.Address = reader["saddress1"].ToString() + " " + reader["saddress2"].ToString() + " " +
                                reader["city"].ToString() + " " + reader["state"].ToString() + " " +
                                reader["country"].ToString() + " " + reader["zip"].ToString();
                    patient.Allergies = reader["allergies"].ToString();
                    patient.CellNumber = reader["cellNumber"].ToString();
                    patient.HomeNumber = reader["homeNumber"].ToString();
                    patient.OfficeNumber = reader["officeNumber"].ToString();
                    patient.FamilyDoctorId = (int)reader["id"];
                }

                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            ArrayList medicines = new ArrayList();
            foreach (DataRow row in patientTable.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicine.PrescriptionID = (int)row["prescriptionID"];
                medicine.Date = row["date"].ToString();
                medicines.Add(medicine);
            }
            patient.MedicineHistory = medicines;
            return patient;
        }
       
        public static ArrayList displayPatients()
        {
            return patients;
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

        public void retrieveMedicineHistory()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT m.name, m.quantity, m.dosage, m.route, m.instructions, m.prescriptionID " +
                            "FROM DixonPatient pa JOIN DixonPrescription pr ON pr.patientID = pa.patientID " +
                            "JOIN DixonMedicine m ON m.prescriptionID = pr.id WHERE pa.patientID = 1;";
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
           
            foreach (DataRow row in table.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicine.PrescriptionID = (int)row["prescriptionID"];
                medicineHistory.Add(medicine);
            }
        }

    }
}
