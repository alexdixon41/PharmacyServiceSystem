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

        //initialize instances of each UserControl so they are only created once
        private ReceiveNoticeForm newNoticesForm = new ReceiveNoticeForm();
        private PrescriptionsForm prescriptionsForm = new PrescriptionsForm();        
        private RefillForm refillForm = new RefillForm();
        private PatientRecordsForm patientRecordsForm = new PatientRecordsForm();

        //Notices button click event
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

        //Prescriptions button click event
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

        //Refill Requests button click event
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

        //Patient Records button click event
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
        
        /// <summary>
        /// Update notices, prescriptions, and refill requests from the database and display the number of each with status New
        /// </summary>
        private void showUnread()
        {
            Notice.retrieveNotices();
            Prescription.retrieveNewPrescriptions();
            RefillRequest.retrieveRefillRequests();
            newNoticesButton.Text = "Notices  (" + Notice.unread + ")";
            newPrescriptionsButton.Text = "Prescriptions  (" + Prescription.NewPrescriptionCount + ")";
            newRefillRequestsButton.Text = "Refill Requests  (" + RefillRequest.NewRefillRequestCount + ")";
        }  

        //show the number of notices, prescriptions, and refill requests with status New when main menu is loaded
        private void MainMenu_Load(object sender, EventArgs e)
        {
            showUnread();
        }

        //logout of the system
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
