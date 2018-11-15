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

        private void viewRefillRequestsButton_Click(object sender, EventArgs e)
        {
            if (!(newRefillRequestsListView.SelectedIndices.Count == 0))
            {
                newRefillRequestsPanel.Hide();
                prescriptionDetailPanel.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(RefillRequest request in RefillRequest.displayRefillRequests())
            {
                newRefillRequestsListView.Items.Add(request.Date);                
                newRefillRequestsListView.Items[i].SubItems.Add(request.Patient);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescriber);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Status);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Refills.ToString());
                i++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prescriptionDetailPanel.Hide();
            newRefillRequestsPanel.Show();
        }
    }
}
