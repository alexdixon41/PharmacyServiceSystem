using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class Prescription
    {              
        public const int SEARCH_BY_PATIENT = 0;
        public const int SEARCH_BY_DOCTOR = 1;        

        private int id;
        private string date;
        private string patientName;
        private string prescriberName;
        private string status;
        private int refills;
        private int patientId;
        private ArrayList medicines;
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
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public string PatientName
        {
            get
            {
                return patientName;
            }

            set
            {
                patientName = value;
            }
        }
        public string PrescriberName
        {
            get
            {
                return prescriberName;
            }

            set
            {
                prescriberName = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        public int Refills
        {
            get
            {
                return refills;
            }

            set
            {
                refills = value;
            }
        }    
        public int PatientId
        {
            get
            {
                return patientId;
            }

            set
            {
                patientId = value;
            }
        }
        public ArrayList Medicines
        {
            get
            {
                return medicines;
            }

            set
            {
                medicines = value;
            }
        }

        public static int NewPrescriptionCount
        {
            get
            {
                return newPrescriptionCount;
            }

            set
            {
                newPrescriptionCount = value;
            }
        }
        private static int newPrescriptionCount;
        private static ArrayList prescriptions = new ArrayList();


        public static ArrayList displayPrescriptions()
        {
            return prescriptions;
        }

        public static ArrayList retrievePrescriptionDetails(int selectedPrescriptionIndex)
        {
            DataTable patientTable = new DataTable();
            DataTable prescriptionDetailTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT DATE_FORMAT(pr.dateFilled, \"%Y-%m-%d\") AS 'date', m.name, m.quantity, m.dosage, m.route, m.instructions, m.prescriptionID " +
                            "FROM DixonPatient pa JOIN DixonPrescription pr ON pr.patientID = pa.patientID " +
                            "JOIN DixonMedicine m ON m.prescriptionID = pr.id WHERE pa.patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Prescription prescription = (Prescription)prescriptions[selectedPrescriptionIndex];
                cmd.Parameters.AddWithValue("@id", prescription.PatientId);
                
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(patientTable);
                
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
            return medicines;
        }

        public static void retrieveNewPrescriptions()
        {
            prescriptions.Clear();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT pr.id, pr.dateFilled, pr.refills, pr.prescriptionStatus, pa.name AS patientName, pa.patientID, doc.name AS doctorName " +
                "FROM(DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID JOIN DixonDoctor doc ON pr.doctorID = doc.id) " +
                "WHERE pr.prescriptionStatus = 'New' AND pr.pharmacyID = @id; ";                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", User.Id);                               
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            int newCount = 0;
            foreach (DataRow row in table.Rows)
            {
                Prescription newPrescription = new Prescription();
                newPrescription.Date = row["dateFilled"].ToString();
                newPrescription.Refills = (int)row["refills"];
                newPrescription.Status = row["prescriptionStatus"].ToString();
                newPrescription.PatientName = row["patientName"].ToString();
                newPrescription.PatientId = (int)row["patientID"];
                newPrescription.PrescriberName = row["doctorName"].ToString();
                newPrescription.Id = (int)row["id"];
                if (newPrescription.Status.Equals("New"))
                    newCount++;
                prescriptions.Add(newPrescription);
            }
            newPrescriptionCount = newCount;
        }

        /// <summary>
        /// Execute SQL query to retrieve prescriptions matching user's search parameters
        /// </summary>
        public static ArrayList retrievePrescriptions(int searchTypeCode, string searchKey)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                if (searchTypeCode == SEARCH_BY_DOCTOR)
                {
                    sql = "SELECT pa.name AS PatientName, doc.name AS DoctorName, pr.dateFilled, pr.prescriptionStatus, pr.refills " +
                    "FROM DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID " +
                    "JOIN DixonDoctor doc ON pr.doctorID = doc.id JOIN DixonPharmacy ph ON pr.pharmacyID = ph.id " +
                    "WHERE doc.name LIKE '" + searchKey + "%' AND ph.id = @id;";
                }
                else
                {
                    sql = "SELECT pa.name AS PatientName, doc.name AS DoctorName, pr.dateFilled, pr.prescriptionStatus, pr.refills " +
                    "FROM DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID " +
                    "JOIN DixonDoctor doc ON pr.doctorID = doc.id JOIN DixonPharmacy ph ON pr.pharmacyID = ph.id " +
                    "WHERE pa.name LIKE '" + searchKey + "%' AND ph.id = @id;";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", User.Id);                     
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            ArrayList prescriptions = new ArrayList();
            foreach (DataRow row in table.Rows)
            {
                Prescription newPrescription = new Prescription();
                newPrescription.PatientName = row["PatientName"].ToString();
                newPrescription.PrescriberName = row["DoctorName"].ToString();
                newPrescription.Date = row["dateFilled"].ToString();
                newPrescription.Status = row["prescriptionStatus"].ToString();
                newPrescription.Refills = (int)row["refills"];
                prescriptions.Add(newPrescription);
            }
            return prescriptions;
        }        
    }
}
