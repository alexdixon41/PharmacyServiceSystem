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
                return Id;
            }

            set
            {
                id = value;
            }
        }
        private static ArrayList notices = new ArrayList();
        
        public static ArrayList displayNotices()
        {
            return notices;
        }   

        //TODO only retrieve notices where the current user is the receiver
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
                string sql = "SELECT * FROM DixonNotice";

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
                Notice newNotice = new Notice();
                newNotice.Id = (int)row["noticeId"];
                newNotice.Type = row["noticeType"].ToString();
                newNotice.Status = row["noticeStatus"].ToString();
                newNotice.SentDate = row["sentDate"].ToString();
                newNotice.Sender = row["sender"].ToString();
                newNotice.Message = row["message"].ToString();
                noticeList.Add(newNotice);
            }
            notices =  noticeList;
        }
    }
}
