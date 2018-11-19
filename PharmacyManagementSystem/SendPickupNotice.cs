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
    public partial class SendPickupNotice : Form
    {
        String defaultMessage;

        public SendPickupNotice(String defaultMessage)
        {
            this.defaultMessage = defaultMessage;
            InitializeComponent();
        }

        private void customMessageBox_Click(object sender, EventArgs e)
        {
            customMessageBox.Text = "";
            customMessageBox.ForeColor = Color.Black;
        }

        private void SendPickupNotice_Load(object sender, EventArgs e)
        {
            defaultMessageBox.Text = defaultMessage;
            customMessageBox.Select();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ConfirmationPopup deliveryPopup = new ConfirmationPopup("The notice was delivered to the patient.", "");
            deliveryPopup.ShowDialog();
            this.Close();
        }
    }
}
