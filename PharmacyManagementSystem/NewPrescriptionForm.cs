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
    public partial class NewPrescriptionForm : Form
    {
        public NewPrescriptionForm()
        {
            InitializeComponent();
        }    

        private void prescriptionDetailButton_Click(object sender, EventArgs e)
        {
            newPrescriptionsPanel.Hide();
            String[] stringybois = new string[] {"1112233     Example Drug A     New            9/18/2018",
                                            "3216549     Example Drug B     Complete    7/20/2018" };
            String[] strings = new String[] { "Name: Amoxicillin", "Dosage: 50 mg",
                                            "Frequency: Twice daily", "Route: By mouth" };
            foreach (String s in stringybois)
            {
                medicineHistoryListBox.Items.Add(s);
            }
            foreach (String s in strings)
            {
                prescriptionDetailsListView.Items.Add(s);
            }
            prescriptionDetailPanel.Show();
        }

        private void NewPrescriptionForm_Load(object sender, EventArgs e)
        {
            String[] strings = new String[] {"Alex Dixon        11122333      09/26/2018    07:30",
                "Sidney Dixon    32165987      09/24/2018     09:45" };
            foreach (String s in strings)
            {
                newPrescriptionsListBox.Items.Add(s);
            }
        }
    }
}
