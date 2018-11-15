using System;
using System.Collections;
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
            if (!(noticesListView.SelectedIndices.Count == 0))
            {
                Notice notice = (Notice)Notice.displayNotices()[noticesListView.SelectedIndices[0]];
                typeTextBox.Text = notice.Type;
                dateTextBox.Text = notice.SentDate;
                fromTextBox.Text = notice.Sender;
                messageTextBox.Text = notice.Message;
                noticeListPanel.Hide();
                noticeDetailPanel.Show();
                notice.updateStatus();
            }
        }

        private void ReceiveNoticeForm_Load(object sender, EventArgs e)
        {
            noticesListView.Items.Clear();     
            int i = 0;
            foreach (Notice notice in Notice.displayNotices())
            {
                noticesListView.Items.Add(notice.Type);
                noticesListView.Items[i].SubItems.Add(notice.SentDate);
                noticesListView.Items[i].SubItems.Add(notice.Status);
                noticesListView.Items[i].SubItems.Add(notice.Sender);
                noticesListView.Items[i].SubItems.Add(notice.Message);
                i++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Notice.retrieveNotices();
            noticesListView.Items.Clear();
            int i = 0;
            foreach (Notice notice in Notice.displayNotices())
            {
                noticesListView.Items.Add(notice.Type);
                noticesListView.Items[i].SubItems.Add(notice.SentDate);
                noticesListView.Items[i].SubItems.Add(notice.Status);
                noticesListView.Items[i].SubItems.Add(notice.Sender);
                noticesListView.Items[i].SubItems.Add(notice.Message);
                i++;
            }
            noticeDetailPanel.Hide();
            noticeListPanel.Show();
        }
    }
}
