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
        String defaultMessage;

        public SendDoctorNotice(String defaultMessage)
        {
            this.defaultMessage = defaultMessage;
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ConfirmationPopup deliveryConfirmation = new ConfirmationPopup("The notice was delivered to the doctor.", "", 5);
            deliveryConfirmation.ShowDialog();
            this.Close();
        }

        private void SendDoctorNotice_Load(object sender, EventArgs e)
        {
            defaultMessageBox.Text = defaultMessage;
        }
    }
}
