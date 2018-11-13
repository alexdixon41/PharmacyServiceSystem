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
    public partial class ReceiveNoticeForm : UserControl
    {
        public ReceiveNoticeForm()
        {
            InitializeComponent();
        }

        private void ViewNoticeButton_Click(object sender, EventArgs e)
        {
            noticeListPanel.Hide();
            noticeDetailPanel.Show();
        }

        private void ReceiveNoticeForm_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            foreach (Notice notice in Notice.displayNotices())
            {
                noticesListView.Items.Add(notice.Type);
                noticesListView.Items[i].SubItems.Add(notice.SentDate);
                noticesListView.Items[i].SubItems.Add(notice.Sender);
                noticesListView.Items[i].SubItems.Add(notice.Message);
                i++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            noticeDetailPanel.Hide();
            noticeListPanel.Show();
        }
    }
}
