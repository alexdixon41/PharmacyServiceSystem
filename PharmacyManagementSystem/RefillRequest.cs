﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace PharmacyManagementSystem
{
    public class RefillRequest
    {
        private string date;                                               //date when the refill was requested
        private string status;                                             //status of the refill request
        private string id;                                                 //id of the refill request
        private Prescription prescription;                                 //prescription that a refill was requested for

        //public properties
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
        public string Id
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
        internal Prescription Prescription
        {
            get
            {
                return prescription;
            }

            set
            {
                prescription = value;
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

        //constant codes for acceptance or denial of refill request
        public const int ACCEPTED_STATUS_CODE = 0;
        public const int DENIED_STATUS_CODE = 1;

        //display the list of refill requests
        public static ArrayList displayRefillRequests()
        {
            return refillRequests;
        }

        /// <summary>
        /// Retrieve all new refill requests for the pharmacy of the pharmacist user.
        /// </summary>
        public static void retrieveRefillRequests()
        {
            refillRequests.Clear();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT DATE_FORMAT(re.dateRequested, ""%m-%d-%Y"") AS dateRequested, re.refillRequestStatus, 
                        re.id, pa.name AS patientName, pa.patientID, DATE_FORMAT(pa.birthDate, ""%Y-%m-%d"") AS birthDate, 
                        doc.name, pr.refills, pr.remainingRefills, pr.id AS 'pid'
                        FROM DixonRefillRequest re JOIN DixonPrescription pr ON re.prescriptionID = pr.id 
                        JOIN DixonPatient pa ON re.patientID = pa.patientID JOIN DixonDoctor doc ON pr.doctorID = doc.id 
                        WHERE pr.pharmacyID = @id AND re.refillRequestStatus = 'New'
                        ORDER BY re.refillRequestStatus DESC, dateRequested DESC;";

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
                request.Prescription = new Prescription();
                request.Date = row["dateRequested"].ToString();
                request.Status = row["refillRequestStatus"].ToString();
                request.Id = row["id"].ToString();
                request.Prescription.PatientName = row["patientName"].ToString();
                request.Prescription.PatientBirthDate = row["birthDate"].ToString();               
                request.Prescription.PrescriberName = row["name"].ToString();
                request.Prescription.Refills = (int)row["refills"];
                request.Prescription.RemainingRefills = (int)row["remainingRefills"];                
                request.Prescription.Id = (int)row["pid"];
                request.Prescription.PatientId = (int)row["patientID"];
                if (request.Status.Equals("New"))
                    newCount++;
                refillRequests.Add(request);
            }
            newRefillRequestCount = newCount;
        }

        /// <summary>
        /// Change the status of a prescription.
        /// </summary>
        /// <param name="newStatusCode">The specified status for the new status of the refill request</param>
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
                    case ACCEPTED_STATUS_CODE:
                        sql = "UPDATE DixonRefillRequest SET refillRequestStatus = 'Accepted' WHERE id = @id;";
                        break;
                    case DENIED_STATUS_CODE:
                        sql = "UPDATE DixonRefillRequest SET refillRequestStatus = 'Denied' WHERE id = @id;";
                        break;                    
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();

                sql = "UPDATE DixonPrescription SET canRequestRefill = TRUE WHERE id = @id;";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Prescription.Id);
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