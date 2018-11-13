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
            Prescription.retrievePrescriptionDetails(listView4.SelectedIndices.IndexOf(0));
            newPrescriptionsPanel.Hide();
            prescriptionDetailPanel.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
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
    }
}
