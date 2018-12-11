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
    public partial class PrescriptionsForm : UserControl
    {
        public PrescriptionsForm()
        {
            InitializeComponent();
        }

        private Prescription selectedPrescription;

        public void populateList()
        {
            prescriptionsListView.Items.Clear();
            int i = 0;
            foreach (Prescription prescription in Prescription.displayPrescriptions())
            {
                prescriptionsListView.Items.Add(prescription.Status);
                prescriptionsListView.Items[i].SubItems.Add(prescription.Date);
                prescriptionsListView.Items[i].SubItems.Add(prescription.PatientName);
                prescriptionsListView.Items[i].SubItems.Add(prescription.PrescriberName);
                prescriptionsListView.Items[i].SubItems.Add(prescription.Refills.ToString());
                i++;
            }
        }

        private void prescriptionSearchBox_Click(object sender, EventArgs e)
        {
            prescriptionSearchBox.Text = "";
            prescriptionSearchBox.ForeColor = Color.Black;
        }

        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (!(prescriptionsListView.SelectedIndices.Count == 0))
            {
                selectedPrescription = (Prescription)Prescription.displayPrescriptions()[prescriptionsListView.SelectedIndices[0]];
                listView1.Items.Clear();
                listView2.Items.Clear();
               
                selectedPrescription.retrieveMedicines();
                Patient patient = selectedPrescription.retrievePatientDetails();

                //Display medicine history information
                int i = 0;
                foreach (Medicine medicine in patient.MedicineHistory)
                {
                    listView1.Items.Add(medicine.Date);
                    listView1.Items[i].SubItems.Add(medicine.Name);
                    listView1.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView1.Items[i].SubItems.Add(medicine.Dosage);
                    i++;
                }

                //Display medicine information for this prescription
                i = 0;
                foreach (Medicine medicine in selectedPrescription.Medicines)
                {
                    listView2.Items.Add(medicine.Name);
                    listView2.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView2.Items[i].SubItems.Add(medicine.Dosage);
                    listView2.Items[i].SubItems.Add(medicine.Route);
                    listView2.Items[i].SubItems.Add(medicine.Instructions);
                    i++;
                }

                //Display patient information    
                generalListView.Items.Clear();            
                generalListView.Items.Add("Name: " + patient.Name);               
                generalListView.Items.Add("Date of Birth: " + patient.BirthDate);
                generalListView.Items.Add("Height: " + patient.Height);
                generalListView.Items.Add("Weight: " + patient.Weight);
                generalListView.Items.Add("Body Mass Index: " + patient.BodyMassIndex);
                dateLabel.Text = selectedPrescription.Date;
                statusLabel.Text = selectedPrescription.Status;
                refillsLabel.Text = "" + selectedPrescription.Refills;
                remainingLabel.Text = "" + selectedPrescription.RemainingRefills;
                allergyTextBox.Text = patient.Allergies;

                //Gray out status button for current status
                if (selectedPrescription.Status.Equals("Active"))
                {
                    activeStatusButton.Enabled = false;
                    readyStatusButton.Enabled = true;
                    completeStatusButton.Enabled = false;
                    deletedStatusButton.Enabled = true;
                }
                else if (selectedPrescription.Status.Equals("Ready"))
                {
                    readyStatusButton.Enabled = false;
                    activeStatusButton.Enabled = false;
                    completeStatusButton.Enabled = true;
                    deletedStatusButton.Enabled = true;
                }
                else if (selectedPrescription.Status.Equals("Complete"))
                {
                    completeStatusButton.Enabled = false;
                    activeStatusButton.Enabled = false;
                    readyStatusButton.Enabled = false;
                    deletedStatusButton.Enabled = true;
                }
                else if (selectedPrescription.Status.Equals("Deleted"))
                {
                    deletedStatusButton.Enabled = false;
                    activeStatusButton.Enabled = false;
                    readyStatusButton.Enabled = false;
                    completeStatusButton.Enabled = false;
                }
                else
                {
                    activeStatusButton.Enabled = true;
                    readyStatusButton.Enabled = true;
                    completeStatusButton.Enabled = true;
                    deletedStatusButton.Enabled = true;                    
                }

                prescriptionListPanel.Hide();
                prescriptionDetailPanel.Show();
            }
        }

        private void activeStatusButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Change the status of this prescription to Active?", "").ShowDialog() == DialogResult.OK)
            {
                selectedPrescription.changeStatus(Prescription.ACTIVE_STATUS_CODE);
                statusLabel.Text = "Active";
                activeStatusButton.Enabled = false;
                readyStatusButton.Enabled = true;
                completeStatusButton.Enabled = false;
                new AlertDialog("Prescription status changed successfully.").ShowDialog();
            }            
        }

        private void readyStatusButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Change the status of this prescription to Ready?",
                                      "Note: This will send a notice to the patient.").ShowDialog() == DialogResult.OK)
            {
                //Notify the patient
                Notice.sendNotice(selectedPrescription.PatientId, "Your prescription is ready to be picked up.", Notice.SEND_PICKUP_NOTICE_TYPE);
                selectedPrescription.changeStatus(Prescription.READY_STATUS_CODE);
                statusLabel.Text = "Ready for Pickup";
                readyStatusButton.Enabled = false;
                activeStatusButton.Enabled = false;
                completeStatusButton.Enabled = true;
                new AlertDialog("Prescription status changed successfully.").ShowDialog();
            }            
        }

        private void completeStatusButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Change the status of this prescription to Complete?", "").ShowDialog() == DialogResult.OK)
            {
                selectedPrescription.changeStatus(Prescription.COMPLETE_STATUS_CODE);
                statusLabel.Text = "Complete";
                completeStatusButton.Enabled = false;
                activeStatusButton.Enabled = false;
                readyStatusButton.Enabled = false;
            }
        }

        private void deletedStatusButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Are you sure you want to delete this prescription?",
                                                    "Note: This can not be undone.").ShowDialog() == DialogResult.OK)
            {
                selectedPrescription.changeStatus(Prescription.DELETED_STATUS_CODE);
                statusLabel.Text = "Deleted";
                deletedStatusButton.Enabled = false;
                activeStatusButton.Enabled = false;
                readyStatusButton.Enabled = false;
                completeStatusButton.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (prescriptionSearchBox.Text.Equals("Search for a prescription"))
            {
                Prescription.retrieveNewPrescriptions();
                populateList();
            }
            else
            {
                if (prescriptionSearchBox.Text.Equals("Search for a prescription"))
                    prescriptionSearchBox.Text = "";
                if (radioButton2.Checked)
                    Prescription.retrievePrescriptions(Prescription.SEARCH_BY_PATIENT, prescriptionSearchBox.Text);
                else
                    Prescription.retrievePrescriptions(Prescription.SEARCH_BY_DOCTOR, prescriptionSearchBox.Text);

                populateList();
            }
            prescriptionDetailPanel.Hide();
            prescriptionListPanel.Show();
        }  

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (prescriptionSearchBox.Text.Equals("Search for a prescription"))
                prescriptionSearchBox.Text = "";
            if (radioButton2.Checked)
                Prescription.retrievePrescriptions(Prescription.SEARCH_BY_PATIENT, prescriptionSearchBox.Text);
            else
                Prescription.retrievePrescriptions(Prescription.SEARCH_BY_DOCTOR, prescriptionSearchBox.Text);

            populateList();
        }

        private void PrescriptionsForm_Load(object sender, EventArgs e)
        {
            populateList();
        }
    }
}
