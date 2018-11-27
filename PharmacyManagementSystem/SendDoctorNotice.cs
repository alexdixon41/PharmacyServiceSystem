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
    public partial class SendDoctorNotice : Form
    {
        private string defaultMessage;
        private int receiverID;

        public SendDoctorNotice(string defaultMessage, int receiverID)
        {
            this.defaultMessage = defaultMessage;
            this.receiverID = receiverID;
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {                       
            Notice.sendNotice(receiverID, messageBox.Text, Notice.SEND_CASE_DISCUSSION_NOTICE_TYPE);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SendDoctorNotice_Load(object sender, EventArgs e)
        {
            messageBox.Text = defaultMessage;
        }
    }
}
