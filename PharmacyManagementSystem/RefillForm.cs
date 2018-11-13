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

        private void button1_Click(object sender, EventArgs e)
        {
            newRefillRequestsPanel.Hide();
            prescriptionDetailPanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(RefillRequest request in RefillRequest.displayRefillRequests())
            {
                newRefillRequestsListBox.Items.Add(request.Date);                
                newRefillRequestsListBox.Items[i].SubItems.Add(request.Patient);
                newRefillRequestsListBox.Items[i].SubItems.Add(request.Prescriber);
                newRefillRequestsListBox.Items[i].SubItems.Add(request.Status);
                newRefillRequestsListBox.Items[i].SubItems.Add(request.Refills.ToString());
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
