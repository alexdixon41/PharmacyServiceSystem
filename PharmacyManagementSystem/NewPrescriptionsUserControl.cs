using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class NewPrescriptionsUserControl : UserControl
    {
        public NewPrescriptionsUserControl()
        {
            InitializeComponent();
        }

        private void viewPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (!(listView4.SelectedIndices.Count == 0))
            {
                listView1.Items.Clear();
                listView2.Items.Clear();
                Patient patient = Patient.retrievePatientPrescriptionDetails(listView4.SelectedIndices.IndexOf(0));
                Prescription prescription = Prescription.retrievePrescriptionDetails(listView4.SelectedIndices.IndexOf(0));
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
                foreach (Medicine medicine in prescription.Medicines)
                {
                    listView2.Items.Add(medicine.Name);
                    listView2.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView2.Items[i].SubItems.Add(medicine.Dosage);
                    listView2.Items[i].SubItems.Add(medicine.Route);
                    listView2.Items[i].SubItems.Add(medicine.Instructions);
                    i++;
                }
                nameLabel.Text = patient.Name;
                birthDateLabel.Text = patient.BirthDate;
                dateLabel.Text = prescription.Date;
                statusLabel.Text = prescription.Status;
                refillsLabel.Text = "" + prescription.Refills;
                remainingLabel.Text = "" + prescription.RemainingRefills;
                allergyTextBox.Text = patient.Allergies;
                newPrescriptionsPanel.Hide();
                prescriptionDetailPanel.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Prescription.retrieveNewPrescriptions();
            listView4.Items.Clear();
            int i = 0;
            foreach (Prescription prescription in Prescription.displayPrescriptions())
            {
                listView4.Items.Add(prescription.Date);
                listView4.Items[i].SubItems.Add(prescription.PatientName);
                listView4.Items[i].SubItems.Add(prescription.PrescriberName);
                listView4.Items[i].SubItems.Add(prescription.Status);
                listView4.Items[i].SubItems.Add(prescription.Refills.ToString());
                i++;
            }
            prescriptionDetailPanel.Hide();
            newPrescriptionsPanel.Show();
        }

        private void NewPrescriptionsUserControl_Load(object sender, EventArgs e)
        {            
            int i = 0;
            foreach (Prescription prescription in Prescription.displayPrescriptions())
            {
                listView4.Items.Add(prescription.Date);
                listView4.Items[i].SubItems.Add(prescription.PatientName);
                listView4.Items[i].SubItems.Add(prescription.PrescriberName);
                listView4.Items[i].SubItems.Add(prescription.Status);
                listView4.Items[i].SubItems.Add(prescription.Refills.ToString());
                i++;
            }
        }
             
        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Change the status of this prescription to Active?", "").ShowDialog()
                == DialogResult.OK)
            {
                Prescription prescription = (Prescription)Prescription.displayPrescriptions()[listView4.SelectedIndices.IndexOf(0)];
                prescription.changeStatus(Prescription.ACTIVE_STATUS_CODE);
                new AlertDialog("Prescription status changed successfully").ShowDialog();
            }
        }
    }
}
