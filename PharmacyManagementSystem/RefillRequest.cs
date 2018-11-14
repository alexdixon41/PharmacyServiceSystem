using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace PharmacyManagementSystem
{
    public class RefillRequest
    {
        private string date;
        private string status;
        private string patient;
        private string prescriber;
        private int refills;
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
        public string Patient
        {
            get
            {
                return patient;
            }

            set
            {
                patient = value;
            }
        }
        public string Prescriber
        {
            get
            {
                return prescriber;
            }

            set
            {
                prescriber = value;
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

        public static int NewRefillRequestCount
        {
            get
            {
                return newRefillRequestCount;
            }

            set
            {
                newRefillRequestCount = value;
            }
        }
        private static int newRefillRequestCount;
        private static ArrayList refillRequests = new ArrayList();
        

        public static ArrayList displayRefillRequests()
        {
            return refillRequests;
        }

        public static void retrieveRefillRequests()
        {
            ArrayList noticeList = new ArrayList();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT re.dateRequested, re.refillRequestStatus, pa.name AS patientName, doc.name, pr.refills " +
                        "FROM DixonRefillRequest re JOIN DixonPrescription pr ON re.prescriptionID = pr.id " +
                        "JOIN DixonPatient pa ON re.patientID = pa.patientID JOIN DixonDoctor doc ON pr.doctorID = doc.id " +
                        "WHERE re.refillRequestStatus = 'New' AND pr.pharmacyID = @id;";

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
                RefillRequest request = new RefillRequest();
                request.Date = row["dateRequested"].ToString();
                request.Status = row["refillRequestStatus"].ToString();
                request.Patient = row["patientName"].ToString();
                request.Prescriber = row["name"].ToString();
                request.Refills = (int)row["refills"];
                if (request.Status.Equals("New"))
                    newCount++;
                refillRequests.Add(request);
            }
            newRefillRequestCount = newCount;
        }

    }

}