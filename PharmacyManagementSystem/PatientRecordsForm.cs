using System;
using System.Collections;
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
    public partial class PatientRecordsForm : UserControl
    {
        public PatientRecordsForm()
        {
            InitializeComponent();
        }

        private void patientSearchSelectButton_Click(object sender, EventArgs e)
        {
            patientSearchPanel.Hide();
            patientRecordPanel.Show();
        }

        private void doctorNoticeButton_Click(object sender, EventArgs e)
        {
            patientRecordPanel.Hide();
            doctorSearchPanel.Show();            
        }

        private void doctorSearchBox_Click(object sender, EventArgs e)
        {
            doctorSearchBox.Text = "";
            doctorSearchBox.ForeColor = Color.Black;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SendDoctorNotice sendNotice = new SendDoctorNotice("We would like to discuss Alex Dixon's case with you. "
                + "Please contact us soon so we can discuss this case. Thank you.");
            sendNotice.ShowDialog();
        }

        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals("Search for a patient"))
                searchBox.Text = "";
            listView1.Items.Clear();
            int i = 0;     
            foreach (Patient patient in Patient.retrievePatients(searchBox.Text))
            {
                listView1.Items.Add(patient.Name);
                listView1.Items[i].SubItems.Add(patient.BirthDate);
                i++;
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
            searchBox.ForeColor = Color.Black;
        }
    }
}
