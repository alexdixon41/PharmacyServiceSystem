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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewPrescriptionForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RefillForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PatientRecordsForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PrescriptionsForm().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ReceiveNoticeForm().Show();
        }
    }
}
