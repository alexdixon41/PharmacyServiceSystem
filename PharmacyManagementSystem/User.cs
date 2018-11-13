using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    /// <summary>
    /// A user of the system. Manages user login to control what data the user can access.
    /// </summary>
    class User
    {
        public const int PHARMACIST_USER_TYPE = 0;
        public const int DOCTOR_USER_TYPE = 1;
        public const int PATIENT_USER_TYPE = 2;

        private static int type;
        private static int id;
        public static int Type
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
        public static int Id
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

        public static Boolean authenticate(int userType, string u, string p)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                switch(userType)
                {
                    case PHARMACIST_USER_TYPE:
                        sql = "SELECT pharmacy.id, pharmacist.pword FROM DixonPharmacist pharmacist JOIN DixonPharmacy pharmacy " +
                            "ON pharmacist.pharmacyID = pharmacy.id WHERE username = @u";
                        break;
                    case DOCTOR_USER_TYPE:
                        sql = "SELECT id, pword FROM DixonDoctor WHERE username = @u";
                        break;
                    case PATIENT_USER_TYPE:
                        sql = "SELECT id, pword FROM DixonPatient WHERE username = @u";
                        break;
                    default:
                        sql = "";
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", u);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);                
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (table.Rows.Count == 1)
            {
                string inputPass;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] hashedBytes = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(p));
                    inputPass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                }
                if (table.Rows[0]["pword"].ToString() == inputPass)
                {
                    User.Id = (int)table.Rows[0]["id"];
                    User.Type = userType;
                    return true;
                }
            }
            return false;
        }

        
    }
}
