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

        public Login()
        {
            InitializeComponent();
        }        

        //login button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            if (User.authenticate(textBox1.Text, textBox2.Text))        //check authentication before proceeding to main menu
            {
                loginSuccess = true;                                    //set to true so main menu will be launched
                this.Close();                                           //close login window
            }   
            else
            {
                new AlertDialog("Incorrect username or password").ShowDialog();       //alert if authentication failed
            }         
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Select();                             //position the cursor in the username textbox
        }
    }
}
