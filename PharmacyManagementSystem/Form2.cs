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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void viewRecordsButton_Click(object sender, EventArgs e)
        {
            viewRecordsButtonPanel.Hide();
            String[] strings = new String[] { "Alex Dixon", "Ethen Holzapfel", "Kuang-Nan Chang" };
            foreach (String s in strings)
            {
                patientSearchListBox.Items.Add(s);
            }
            patientSearchPanel.Show();
        }

        private void patientSearchSelectButton_Click(object sender, EventArgs e)
        {
            patientSearchPanel.Hide();
            patientRecordPanel.Show();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = Color.Black;
        }

        private void doctorNoticeButton_Click(object sender, EventArgs e)
        {
            SendDoctorNotice sendNotice = new SendDoctorNotice("We would like to discuss Alex Dixon's case with you. "
                + "Please contact us soon so we can discuss this case. Thank you.");
            sendNotice.ShowDialog();
        }
    }
}
