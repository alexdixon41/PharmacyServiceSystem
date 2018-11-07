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
            panel3.Hide();
            String s1 = "1112233     Example Drug A     New            9/18/2018";
            String s2 = "3216549     Example Drug B     Complete    7/20/2018";
            String s3 = "Name: Warfarin";
            String s4 = "Dosage: 50mg";
            String s5 = "Frequency: Twice daily";
            String s6 = "Route: By mouth";
            medicineHistoryListBox.Items.Add(s1);
            medicineHistoryListBox.Items.Add(s2);
            prescriptionDetailsListView.Items.Add(s3);
            prescriptionDetailsListView.Items.Add(s4);
            prescriptionDetailsListView.Items.Add(s5);
            prescriptionDetailsListView.Items.Add(s6);
            panel2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String s1 = "Alex      1112233     9/19/2018 07:30";
            String s2 = "Ethen    3216549     9/21/2018 16:15";
            newRefillRequestsListBox.Items.Add(s1);
            newRefillRequestsListBox.Items.Add(s2);
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
