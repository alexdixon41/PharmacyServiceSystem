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

        private Patient selectedPatient;                 //the patient selected in the listview after select button pressed

        //Select button click event
        private void patientSearchSelectButton_Click(object sender, EventArgs e)
        {
            if (!(patientSearchListView.SelectedIndices.Count == 0))         //verify that a patient was selected
            {                
                selectedPatient = (Patient)Patient.displayPatients()[patientSearchListView.SelectedIndices.IndexOf(0)];     //get the selected patient from the list of patients being display               
                listView1.Items.Clear();
                allergyTextBox.Clear();
                disordersTextBox.Clear();
                notesTextBox.Clear();
                selectedPatient.retrieveMedicalRecord();            //retrieve the selected patient's medical record
                selectedPatient.retrieveMedicineHistory();          //retrieve the selected patient's medicine history

                int i = 0;
                foreach (Medicine medicine in selectedPatient.MedicineHistory)        //add each medicine to the medicine history listview
                {
                    listView1.Items.Add(medicine.Date);
                    listView1.Items[i].SubItems.Add(medicine.Name);
                    listView1.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView1.Items[i].SubItems.Add(medicine.Dosage);
                    i++;
                }

                //display medical record information
                nameLabel.Text = selectedPatient.Name;
                birthDateLabel.Text = selectedPatient.BirthDate;
                maritalStatusLabel.Text = selectedPatient.MaritalStatus;
                allergyTextBox.Text = selectedPatient.Allergies;
                disordersTextBox.Text = selectedPatient.Disorders;
                notesTextBox.Text = selectedPatient.Notes;

                patientSearchPanel.Hide();
                patientRecordPanel.Show();
            }
        }

        //show the doctor search panel
        private void doctorNoticeButton_Click(object sender, EventArgs e)
        {
            patientRecordPanel.Hide();
            doctorSearchPanel.Show();            
        }

        //clear the search box default text and change the text color to black when text box clicked
        private void doctorSearchBox_Click(object sender, EventArgs e)
        {
            doctorSearchBox.Text = "";
            doctorSearchBox.ForeColor = Color.Black;
        }

        //search for patients
        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            Patient.retrievePatients(searchBox.Text);         //retrieve patients for search parameters
            patientSearchListView.Items.Clear();
            if (!(searchBox.Text.Equals("Search for a patient") || searchBox.Text.Equals("")))
            {
                int i = 0;
                foreach (Patient patient in Patient.displayPatients())         //display all patients returned by the search
                {
                    patientSearchListView.Items.Add(patient.Name);
                    patientSearchListView.Items[i].SubItems.Add(patient.BirthDate);
                    i++;
                }
            }
        }

        //clear the search box default text and change the text color to black when text box clicked
        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
            searchBox.ForeColor = Color.Black;
        }

        //return to the patient search panel
        private void backButton_Click(object sender, EventArgs e)
        {
            patientSearchListView.Items.Clear();
            patientRecordPanel.Hide();
            patientSearchPanel.Show();
        }

        //return to the patient records panel
        private void doctorSearchBackButton_Click(object sender, EventArgs e)
        {
            doctorSearchPanel.Hide();
            patientRecordPanel.Show();
        }

        //send a case discussion notice to the doctor about the selected patient
        private void sendDoctorNoticeButton_Click(object sender, EventArgs e)
        {
            
            if (!(doctorSearchListView.SelectedIndices.Count == 0))
            {                
                Doctor selectedDoctor = (Doctor)Doctor.displayDoctors()[doctorSearchListView.SelectedIndices[0]];                
                SendDoctorNotice sendNotice = new SendDoctorNotice("We would like to discuss " + selectedPatient.Name + "'s case with you. "
                    + "Please contact us soon so we can discuss this case. Thank you.", selectedDoctor.Id);
                sendNotice.ShowDialog();
                if (sendNotice.DialogResult == DialogResult.OK)
                    new AlertDialog("The notice was sent to the doctor.").ShowDialog();
            }                            
        }

        //search for a doctor
        private void searchButton_Click(object sender, EventArgs e)
        {
            doctorSearchListView.Items.Clear();

            if (doctorSearchBox.Text.Equals("Search for a Doctor"))
                doctorSearchBox.Text = "";
            Doctor.retrieveDoctors(doctorSearchBox.Text);        //retrieve doctors matching search parameters

            int i = 0;
            foreach (Doctor doctor in Doctor.displayDoctors())   //display doctors returned by search
            {
                doctorSearchListView.Items.Add(doctor.Name);
                doctorSearchListView.Items[i].SubItems.Add(doctor.OfficeName);
                doctorSearchListView.Items[i].SubItems.Add(doctor.OfficeNumber);
                i++;
            }

        }
    }
}
