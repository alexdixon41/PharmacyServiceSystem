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
    public partial class ConfirmationPopup : Form
    {
        String primaryText;
        String secondaryText;
        int actionCode;

        public ConfirmationPopup(String primaryText, String secondaryText, int actionCode)
        {
            this.primaryText = primaryText;
            this.secondaryText = secondaryText;
            this.actionCode = actionCode;
            InitializeComponent();
        }

        private void ConfirmationPopup_Load(object sender, EventArgs e)
        {
            primaryLabel.Text = primaryText;
            this.Width = primaryLabel.Width + 40;
            secondaryLabel.Text = secondaryText;
            secondaryLabel.MaximumSize = new Size(this.Width - 40, 0);                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.actionCode) {
                case 0:       //active status
                    //change the prescription status to active
                    break;
                case 1:
                    //change the prescription status to ready
                    SendPickupNotice pickupNotice = new SendPickupNotice("Your prescription is ready. You may pick up"
                        + " your prescription between 08:00 am and 06:00 pm Monday through Friday.");
                    pickupNotice.ShowDialog();
                    break;
                case 2:
                    //TODO change the prescription status to complete
                    break;
                case 3:
                    //TODO change the prescription status to deleted
                    break;
            }
        }
    }
}
