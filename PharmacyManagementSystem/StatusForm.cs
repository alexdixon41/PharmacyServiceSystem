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
    public partial class StatusForm : Form
    {
        Form confirmationPopup;


        public StatusForm()
        {
            InitializeComponent();
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            changeStatusButton.Hide();
            String[] strings = new String[] {"Alex Dixon       Amoxicillin           09/27/2018   09:30",
                                            "Sidney Dixon   Spironolactone   08/15/2018   12:30"};
            foreach (String s in strings)
            {
                prescriptionListBox.Items.Add(s);
            }
            prescriptionListPanel.Show();
        }

        private void prescriptionSearchBox_Click(object sender, EventArgs e)
        {
            prescriptionSearchBox.Text = "";
            prescriptionSearchBox.ForeColor = Color.Black;
        }

        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
            prescriptionListPanel.Hide();
            String[] strings = new String[] {"Name: Amoxicillin", "Dosage: 50 mg",
                                            "Frequency: Twice daily", "Route: By mouth"};
            foreach (String s in strings)
            {
                prescriptionDetailListView.Items.Add(s);
            }           
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
    }
}
