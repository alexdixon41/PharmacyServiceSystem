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
            newPrescriptionsPanel.Hide();
            prescriptionDetailPanel.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prescriptionDetailPanel.Hide();
            newPrescriptionsPanel.Show();
        }
    }
}
