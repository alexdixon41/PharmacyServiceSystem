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
        private string type;            //the type of notice
        private string message;         //message content of the notice
        private string sentDate;        //date when the notice was sent
        private string sender;          //name of the message sender
        private string receiver;        //name of the message recipient
        private string status;          //status of the notice (New or Received)
        private int id;                 //id of the notice

        //public properties
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

        public const int SEND_PICKUP_NOTICE_TYPE = 0;                   //notify patient when prescription is ready for pickup
        public const int SEND_CASE_DISCUSSION_NOTICE_TYPE = 1;          //notify doctor to discuss a case
        public const int SEND_REFILL_REQUEST_ACCEPT_NOTICE_TYPE = 2;    //notify patient when refill request accepted
        public const int SEND_REFILL_REQUEST_REJECT_NOTICE_TYPE = 3;    //notify patient when refill request denied


        public static int unread;        //number of New notices
        private static ArrayList notices = new ArrayList();       

        //return list of notices
        public static ArrayList displayNotices()
        {
            return notices;
        }   

        /// <summary>
        /// Retrieve all notices for the current user.
        /// </summary>
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
                string sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, " +
                            "DATE_FORMAT(n.sentDate, \"%m-%d-%Y\") AS 'sentDate', n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE pharmacyReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";                                 

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
                    unreadCount++;                      //increment count of new notices if this notice is new 
                noticeList.Add(newNotice);
            }
            notices =  noticeList;
            Notice.unread = unreadCount;
        }

        /// <summary>
        /// Change the status of a notice to Received.
        /// </summary>
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

        /// <summary>
        /// Add a notice of the specified type to the database with the specified recipient and message content
        /// </summary>
        /// <param name="receiverID">The recipient of the notice</param>
        /// <param name="message">The message content of the notice</param>
        /// <param name="noticeType">The type of notice</param>
        public static void sendNotice(int receiverID, string message, int noticeType)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                MySqlCommand cmd;
                switch (noticeType)
                {
                    case SEND_CASE_DISCUSSION_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, doctorReceiver)
                        VALUES ('Case Discussion', 'New', CURRENT_DATE, @message, @pharmID, @docID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@docID", receiverID);
                        break;
                    case SEND_PICKUP_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Pickup', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("patientID", receiverID);
                        break;
                    case SEND_REFILL_REQUEST_ACCEPT_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Refill Request Accepted', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@patientID", receiverID);
                        break;
                    case SEND_REFILL_REQUEST_REJECT_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Refill Request Denied', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@patientID", receiverID);
                        break;
                    default:
                        sql = "";
                        cmd = new MySqlCommand(sql, conn);
                        break;
                }                
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
