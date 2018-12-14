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

        private Notice selectedNotice;

        //display notices in the notices listview
        public void populateList()
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

        //View Notice button click event
        private void ViewNoticeButton_Click(object sender, EventArgs e)
        {
            if (!(noticesListView.SelectedIndices.Count == 0))
            {
                selectedNotice = (Notice)Notice.displayNotices()[noticesListView.SelectedIndices[0]];
                typeTextBox.Text = selectedNotice.Type;
                dateTextBox.Text = selectedNotice.SentDate;
                fromTextBox.Text = selectedNotice.Sender;
                messageTextBox.Text = selectedNotice.Message;
                noticeListPanel.Hide();
                noticeDetailPanel.Show();
                selectedNotice.updateStatus();
            }
        }

        //populate list when the UserControl is first loaded
        private void ReceiveNoticeForm_Load(object sender, EventArgs e)
        {
            populateList();
        }        

        //return to the list of notices
        private void backButton_Click(object sender, EventArgs e)
        {
            Notice.retrieveNotices();
            populateList();
            noticeDetailPanel.Hide();
            noticeListPanel.Show();
        }
    }
}
