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

        ReceiveNoticeForm newNoticesForm = new ReceiveNoticeForm();
        NewPrescriptionsUserControl newPrescriptions = new NewPrescriptionsUserControl();
        PrescriptionsForm searchPrescriptionsForm = new PrescriptionsForm();        
        RefillForm refillForm = new RefillForm();
        PatientRecordsForm patientRecordsForm = new PatientRecordsForm();
        ReceiveNoticeForm noticesForm = new ReceiveNoticeForm();

        private void newNoticesButton_Click(object sender, EventArgs e)
        {       
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }     
            splitContainer1.Panel2.Controls.Add(newNoticesForm);
            newNoticesForm.Dock = DockStyle.Fill;
            newNoticesForm.Show();
        }

        private void newPrescriptionsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(newPrescriptions);
            newPrescriptions.Dock = DockStyle.Fill;
            newPrescriptions.Show();
        }

        private void newRefillRequestsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(refillForm);
            refillForm.Dock = DockStyle.Fill;
            refillForm.Show();
        } 

        private void prescriptionsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(searchPrescriptionsForm);
            searchPrescriptionsForm.Dock = DockStyle.Fill;
            searchPrescriptionsForm.Show();
        }

        private void patientRecordsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            patientRecordsForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(patientRecordsForm);
            patientRecordsForm.FormBorderStyle = FormBorderStyle.None;
            patientRecordsForm.Dock = DockStyle.Fill;
            patientRecordsForm.Show();
        }

        private void noticesButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(noticesForm);
            noticesForm.Dock = DockStyle.Fill;
            noticesForm.Show();
            Console.WriteLine(noticesForm.Width);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = 500;
        }
    }
}
