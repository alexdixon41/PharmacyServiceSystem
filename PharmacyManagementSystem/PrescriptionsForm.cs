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
    public partial class PrescriptionsForm : UserControl
    {
        Form confirmationPopup;


        public PrescriptionsForm()
        {
            InitializeComponent();
        }

        private void prescriptionSearchBox_Click(object sender, EventArgs e)
        {
            prescriptionSearchBox.Text = "";
            prescriptionSearchBox.ForeColor = Color.Black;
        }

        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
            prescriptionListPanel.Hide();
                     
            prescriptionDetailPanel.Show();
        }

        private void activeStatusButton_Click(object sender, EventArgs e)
        {
            confirmationPopup = new ConfirmationPopup("Change the status of this prescription to Active?", "", 0);
            confirmationPopup.ShowDialog();
        }

        private void readyStatusButton_Click(object sender, EventArgs e)
        {
            confirmationPopup = new ConfirmationPopup("Change the status of this prescription to Ready?",
                                                    "Note: This will send a notice to the patient.", 1);
            confirmationPopup.ShowDialog();
        }

        private void completeStatusButton_Click(object sender, EventArgs e)
        {
            confirmationPopup = new ConfirmationPopup("Change the status of this prescription to Complete?", "", 2);
            confirmationPopup.ShowDialog();
        }

        private void deletedStatusButton_Click(object sender, EventArgs e)
        {
            confirmationPopup = new ConfirmationPopup("Change the status of this prescription to Deleted?",
                                                    "Note: This can not be undone.", 3);
            confirmationPopup.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prescriptionDetailPanel.Hide();
            prescriptionListPanel.Show();
        }

        private void PrescriptionsForm_Load(object sender, EventArgs e)
        {
        }
    }
}
