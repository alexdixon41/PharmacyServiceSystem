using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    class Notice
    {
        private string type;
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        private string message;
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }               
        }
        private string sentDate;
        public string SentDate
        {
            get
            {
                return sentDate;
            }

            set
            {
                sentDate = value;
            }
        }
        private string sender;
        public string Sender
        {
            get
            {
                return sender;
            }

            set
            {
                sender = value;
            }
        }
        private string receiver;
        public string Receiver
        {
            get
            {
                return receiver;
            }

            set
            {
                receiver = value;
            }
        }
        private string status;
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
        private int id;
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

        public static int Unread
        {
            get
            {
                return unread;
            }

            set
            {
                unread = value;
            }
        }
        private static int unread;
        private static ArrayList notices = new ArrayList();       

        public static ArrayList displayNotices()
        {
            return notices;
        }   

        public static void retrieveNotices()
        {
            ArrayList noticeList = new ArrayList();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "";
                switch (User.Type)
                {
                    case User.PHARMACIST_USER_TYPE:
                        sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, n.sentDate, n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE pharmacyReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";
                        break;
                    case User.PATIENT_USER_TYPE:
                        sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, n.sentDate, n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE patientReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";
                        break;
                    case User.DOCTOR_USER_TYPE:
                        sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, n.sentDate, n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE doctorReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";
                        break;
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

            int unreadCount = 0;
            foreach (DataRow row in table.Rows)
            {
                Notice newNotice = new Notice();
                newNotice.Id = (int)row["noticeId"];
                newNotice.Type = row["noticeType"].ToString();
                newNotice.Status = row["noticeStatus"].ToString();                
                newNotice.SentDate = row["sentDate"].ToString();
                newNotice.Message = row["message"].ToString();
                if (row["docName"] != null)
                    newNotice.Sender = row["docName"].ToString();
                else if (row["paName"] != null)
                    newNotice.Sender = row["paName"].ToString();
                else if (row["phName"] != null)
                    newNotice.Sender = row["phName"].ToString();
                if (newNotice.Status.Equals("New"))
                    unreadCount++;
                noticeList.Add(newNotice);
            }
            notices =  noticeList;
            Notice.Unread = unreadCount;
        }

        public void updateStatus()
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE DixonNotice SET noticeStatus = 'Received' WHERE noticeID = @id";            
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
    }
}
