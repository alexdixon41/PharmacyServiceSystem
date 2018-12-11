﻿using System;
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
        public const int ACTIVE_STATUS_CODE = 2;
        public const int READY_STATUS_CODE = 3;
        public const int COMPLETE_STATUS_CODE = 4;
        public const int DELETED_STATUS_CODE = 5;

        private int id;
        private string date;
        private string patientName;
        private string prescriberName;
        private string status;
        private int refills;
        private int remainingRefills;
        private int patientId;      
        private string patientBirthDate;  
        private ArrayList medicines = new ArrayList();
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
        public int RemainingRefills
        {
            get
            {
                return remainingRefills;
            }

            set
            {
                remainingRefills = value;
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
        public string PatientBirthDate
        {
            get
            {
                return patientBirthDate;
            }

            set
            {
                patientBirthDate = value;
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

        public Patient retrievePatientDetails()
        {
            Patient patient = new Patient();
            patient.Id = PatientId;
            patient.Name = PatientName;
            patient.BirthDate = PatientBirthDate;
            patient.retrieveMedicalRecord();
            patient.retrieveMedicineHistory();                        
            return patient;
        }

        /// <summary>
        /// Adds list of medicines to the Medicines property of prescription.
        /// </summary>
        public void retrieveMedicines()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT m.name, m.quantity, m.dosage, m.route, m.instructions " +
                            "FROM DixonPrescription pr JOIN DixonMedicine m ON m.prescriptionID = pr.id " +
                            "WHERE pr.id = @id;";
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

            ArrayList medicines = new ArrayList();
            foreach (DataRow row in table.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicines.Add(medicine);
            }
            Medicines = medicines;
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
                string sql = @"SELECT pr.id, DATE_FORMAT(pr.dateFilled, ""%m-%d-%Y"") AS 'dateFilled', pr.refills, 
                pr.remainingRefills, pr.prescriptionStatus, pa.name AS patientName, pa.patientID, 
                DATE_FORMAT(pa.birthDate, ""%m-%d-%Y"") AS 'birthDate', doc.name AS doctorName 
                FROM(DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID JOIN DixonDoctor doc ON pr.doctorID = doc.id) 
                WHERE pr.pharmacyID = @id AND pr.prescriptionStatus != 'Deleted' ORDER BY pr.prescriptionStatus DESC, pr.dateFilled; ";                
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
                newPrescription.RemainingRefills = (int)row["remainingRefills"];
                newPrescription.Status = row["prescriptionStatus"].ToString();
                newPrescription.PatientName = row["patientName"].ToString();
                newPrescription.PatientId = (int)row["patientID"];
                newPrescription.PatientBirthDate = row["birthDate"].ToString();
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
        public static void retrievePrescriptions(int searchTypeCode, string searchKey)
        {
            prescriptions.Clear();
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
                    sql = @"SELECT pr.id, DATE_FORMAT(pr.dateFilled, ""%m-%d-%Y"") AS 'dateFilled', pr.refills, 
                    pr.remainingRefills, pr.prescriptionStatus, pa.name AS patientName, pa.patientID, 
                    DATE_FORMAT(pa.birthDate, ""%m-%d-%Y"") AS 'birthDate', doc.name AS doctorName 
                    FROM(DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID 
                    JOIN DixonDoctor doc ON pr.doctorID = doc.id JOIN DixonPharmacy ph ON pr.pharmacyID = ph.id
                    WHERE (doc.name LIKE @searchKey1 OR doc.name LIKE @searchKey2) AND ph.id = @id;";
                }
                else
                {
                    sql = @"SELECT pr.id, DATE_FORMAT(pr.dateFilled, ""%m-%d-%Y"") AS 'dateFilled', pr.refills, 
                    pr.remainingRefills, pr.prescriptionStatus, pa.name AS patientName, pa.patientID, 
                    DATE_FORMAT(pa.birthDate, ""%m-%d-%Y"") AS 'birthDate', doc.name AS doctorName 
                    FROM DixonPrescription pr JOIN DixonPatient pa ON pr.patientID = pa.patientID 
                    JOIN DixonDoctor doc ON pr.doctorID = doc.id JOIN DixonPharmacy ph ON pr.pharmacyID = ph.id
                    WHERE (pa.name LIKE @searchKey1 OR pa.name LIKE @searchKey2) AND ph.id = @id;";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", User.Id);
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

            foreach (DataRow row in table.Rows)
            {
                Prescription newPrescription = new Prescription();
                newPrescription.Date = row["dateFilled"].ToString();
                newPrescription.Refills = (int)row["refills"];
                newPrescription.RemainingRefills = (int)row["remainingRefills"];
                newPrescription.Status = row["prescriptionStatus"].ToString();
                newPrescription.PatientName = row["patientName"].ToString();
                newPrescription.PatientId = (int)row["patientID"];
                newPrescription.PatientBirthDate = row["birthDate"].ToString();
                newPrescription.PrescriberName = row["doctorName"].ToString();
                newPrescription.Id = (int)row["id"];
                prescriptions.Add(newPrescription);
            }            
        }     
        
        public void changeStatus(int newStatusCode)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "";
                switch (newStatusCode)
                {
                    case ACTIVE_STATUS_CODE:
                        sql = "UPDATE DixonPrescription SET prescriptionStatus = 'Active' WHERE id = @id;";
                        break;
                    case READY_STATUS_CODE:
                        sql = "UPDATE DixonPrescription SET prescriptionStatus = 'Ready' WHERE id = @id;";
                        break;
                    case COMPLETE_STATUS_CODE:
                        sql = "UPDATE DixonPrescription SET prescriptionStatus = 'Complete' WHERE id = @id;";
                        break;
                    case DELETED_STATUS_CODE:
                        sql = "UPDATE DixonPrescription SET prescriptionStatus = 'Deleted' WHERE id = @id;";
                        break;
                }
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }   

        public void updateRefills()
        {
            RemainingRefills -= 1;
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE DixonPrescription SET remainingRefills = @refills WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@refills", RemainingRefills);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}
