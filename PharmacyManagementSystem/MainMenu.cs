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
        PrescriptionsForm prescriptionsForm = new PrescriptionsForm();        
        RefillForm refillForm = new RefillForm();
        PatientRecordsForm patientRecordsForm = new PatientRecordsForm();

        private void newNoticesButton_Click(object sender, EventArgs e)
        {
            Notice.retrieveNotices();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }     
            splitContainer1.Panel2.Controls.Add(newNoticesForm);
            newNoticesForm.populateList();
            newNoticesForm.Dock = DockStyle.Fill;
            newNoticesForm.Show();
        }

        private void newPrescriptionsButton_Click(object sender, EventArgs e)
        {
            Prescription.retrieveNewPrescriptions();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(prescriptionsForm);
            prescriptionsForm.populateList();
            prescriptionsForm.Dock = DockStyle.Fill;
            prescriptionsForm.Show();                       
        }

        private void newRefillRequestsButton_Click(object sender, EventArgs e)
        {
            RefillRequest.retrieveRefillRequests();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(refillForm);
            refillForm.populateList();
            refillForm.Dock = DockStyle.Fill;
            refillForm.Show();
        }         

        private void patientRecordsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(patientRecordsForm);
            patientRecordsForm.Dock = DockStyle.Fill;
            patientRecordsForm.Show();
        }       

        private void MainMenu_Load(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = 500;
            newNoticesButton.Text += "  (" + Notice.Unread + ")";          
            newPrescriptionsButton.Text += "  (" + Prescription.NewPrescriptionCount + ")";
            newRefillRequestsButton.Text += "  (" + RefillRequest.NewRefillRequestCount + ")";
        }
    }
}
