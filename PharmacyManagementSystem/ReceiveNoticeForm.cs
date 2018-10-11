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
    public partial class ReceiveNoticeForm : Form
    {
        public ReceiveNoticeForm()
        {
            InitializeComponent();
        }

        private void newNoticeButton_Click(object sender, EventArgs e)
        {
            newNoticeButton.Hide();
            String[] strings = new String[] {"Dr. Doolittle          Alex Dixon",
                                            "Dr. Dingleberry     Ethen Holzapfel"};
            foreach (String s in strings)
            {
                noticeListBox.Items.Add(s);
            }
            noticeListPanel.Show();
        }

        private void ViewNoticeButton_Click(object sender, EventArgs e)
        {
            noticeListPanel.Hide();
            noticeDetailPanel.Show();
        }
    }
}
