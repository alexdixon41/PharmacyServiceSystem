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
    public partial class RefillForm : UserControl
    {
        public RefillForm()
        {
            InitializeComponent();
        }

        private RefillRequest selectedRefillRequest;

        public void populateList()
        {
            newRefillRequestsListView.Items.Clear();
            int i = 0;
            foreach (RefillRequest request in RefillRequest.displayRefillRequests())
            {
                newRefillRequestsListView.Items.Add(request.Status);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Date);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.PatientName);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.PrescriberName);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.Refills.ToString());
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.RemainingRefills.ToString());
                i++;
            }
        }

        private void viewRefillRequestsButton_Click(object sender, EventArgs e)
        {
            if (!(newRefillRequestsListView.SelectedIndices.Count == 0))
            {
                selectedRefillRequest = (RefillRequest)RefillRequest.displayRefillRequests()[newRefillRequestsListView.SelectedIndices.IndexOf(0)];
                listView1.Items.Clear();
                listView2.Items.Clear();
            
                selectedRefillRequest.Prescription.retrieveMedicines();
                Patient patient = selectedRefillRequest.Prescription.retrievePatientDetails();
                
                int i = 0;
                foreach (Medicine medicine in patient.MedicineHistory)
                {
                    listView1.Items.Add(medicine.Date);
                    listView1.Items[i].SubItems.Add(medicine.Name);
                    listView1.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView1.Items[i].SubItems.Add(medicine.Dosage);
                    i++;
                }
                i = 0;
                foreach (Medicine medicine in selectedRefillRequest.Prescription.Medicines)
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
                dateLabel.Text = selectedRefillRequest.Date;
                statusLabel.Text = selectedRefillRequest.Status;
                refillsLabel.Text = "" + selectedRefillRequest.Prescription.Refills;
                remainingLabel.Text = "" + selectedRefillRequest.Prescription.RemainingRefills;
                allergyTextBox.Text = patient.Allergies;                

                //Disable or enable Accept and Deny buttons depending on RefillRequest status
                if (selectedRefillRequest.Status.ToLower().Equals("new"))
                {
                    acceptButton.Enabled = true;
                    rejectButton.Enabled = true;
                }
                else
                {
                    acceptButton.Enabled = false;
                    rejectButton.Enabled = false;
                }

                newRefillRequestsPanel.Hide();
                prescriptionDetailPanel.Show();
            }
        }    

        private void backButton_Click(object sender, EventArgs e)
        {
            RefillRequest.retrieveRefillRequests();
            populateList();            
            prescriptionDetailPanel.Hide();
            newRefillRequestsPanel.Show();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (selectedRefillRequest.Prescription.RemainingRefills == 0)
            {
                new AlertDialog("There are no remaining refills for this prescription.").ShowDialog();
            }
            else if (new ConfirmationPopup("Accept this refill request?", "Note: This will update the prescription status to Active.")
                .ShowDialog() == DialogResult.OK)
            {
                selectedRefillRequest.changeStatus(RefillRequest.ACCEPTED_STATUS_CODE);
                selectedRefillRequest.Prescription.changeStatus(Prescription.ACTIVE_STATUS_CODE);
                selectedRefillRequest.Prescription.updateRefills();
                remainingLabel.Text = "" + (selectedRefillRequest.Prescription.RemainingRefills);
                statusLabel.Text = "Accepted";

                //notify patient that their refill request was accepted
                Notice.sendNotice(selectedRefillRequest.Prescription.PatientId,
                    "Your refill request was accepted. We will notify you when your prescription is ready for pickup", 
                    Notice.SEND_REFILL_REQUEST_ACCEPT_NOTICE_TYPE);

                //disable buttons                
                acceptButton.Enabled = false;
                rejectButton.Enabled = false;
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Deny this refill request?", "Note: This cannot be undone.").ShowDialog() == DialogResult.OK) {
                selectedRefillRequest.changeStatus(RefillRequest.DENIED_STATUS_CODE);
                statusLabel.Text = "Denied";

                //notify patient that their refill request was denied
                Notice.sendNotice(selectedRefillRequest.Prescription.PatientId,
                    "Your refill request was denied. Please contact your doctor about receiving a new prescription.",
                    Notice.SEND_REFILL_REQUEST_REJECT_NOTICE_TYPE);

                acceptButton.Enabled = false;
                rejectButton.Enabled = false;     
            }
        }
    }
}
