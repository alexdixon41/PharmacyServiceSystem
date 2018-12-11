using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Login : Form
    {
        public static bool loginSuccess = false;

        private int userType = -1;

        public Login()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.authenticate(User.PHARMACIST_USER_TYPE, textBox1.Text, textBox2.Text))
            {
                loginSuccess = true;
                this.Close();               
            }   
            else
            {
                new AlertDialog("Incorrect username or password").ShowDialog();
            }         
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
