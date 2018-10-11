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
    public partial class PrescriptionForm : Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void viewPrescriptionsButton_Click(object sender, EventArgs e)
        {
            viewPrescriptionsButton.Hide();
            String[] strings = new String[] {"Alex Dixon        11122333      09/26/2018    07:30",
                "Sidney Dixon    32165987      09/24/2018     09:45" };
            foreach (String s in strings)
            {
                newPrescriptionsListBox.Items.Add(s);
            }
            newPrescriptionsPanel.Show();
        }

        private void patientRecordButton_Click(object sender, EventArgs e)
        {
            newPrescriptionsPanel.Hide();
            String[] strings = new String[] { "1112233     Example Drug A     New            9/18/2018",
                                                "3216549     Example Drug B     Complete    7/20/2018"};
            foreach (String s in strings)
            {
                patientPrescriptionsListBox.Items.Add(s);
            }
            patientDetailPanel.Show();
        }

        private void prescriptionDetailButton_Click(object sender, EventArgs e)
        {
            patientDetailPanel.Hide();
            String[] strings = new String[] { "Name: Amoxicillin", "Dosage: 50 mg",
                                            "Frequency: Twice daily", "Route: By mouth" };
            foreach (String s in strings)
            {
                prescriptionDetailListView.Items.Add(s);
            }
            prescriptionDetailPanel.Show();
        }
    }
}
