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
        private static int id;
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

        /// <summary>
        /// Check the login credentials entered by the user against the credentials in the database
        /// </summary>
        /// <param name="u">Username entered by the user</param>
        /// <param name="p">Password entered by the user</param>
        /// <returns></returns>
        public static Boolean authenticate(string u, string p)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT pharmacy.id, pharmacist.pword FROM DixonPharmacist pharmacist JOIN DixonPharmacy pharmacy " +
                            "ON pharmacist.pharmacyID = pharmacy.id WHERE username = @u";                         
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
                    return true;
                }
            }
            return false;
        }        
    }
}
