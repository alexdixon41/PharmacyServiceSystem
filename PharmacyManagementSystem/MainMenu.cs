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

        private ReceiveNoticeForm newNoticesForm = new ReceiveNoticeForm();
        private PrescriptionsForm prescriptionsForm = new PrescriptionsForm();        
        private RefillForm refillForm = new RefillForm();
        private PatientRecordsForm patientRecordsForm = new PatientRecordsForm();

        private void newNoticesButton_Click(object sender, EventArgs e)
        {            
            showUnread();
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
            showUnread();
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
            showUnread();
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
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(patientRecordsForm);
            patientRecordsForm.Dock = DockStyle.Fill;
            patientRecordsForm.Show();
        }     
        
        private void showUnread()
        {
            Notice.retrieveNotices();
            Prescription.retrieveNewPrescriptions();
            RefillRequest.retrieveRefillRequests();
            newNoticesButton.Text = "Notices  (" + Notice.Unread + ")";
            newPrescriptionsButton.Text = "Prescriptions  (" + Prescription.NewPrescriptionCount + ")";
            newRefillRequestsButton.Text = "Refill Requests  (" + RefillRequest.NewRefillRequestCount + ")";
        }  

        private void MainMenu_Load(object sender, EventArgs e)
        {
            showUnread();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
