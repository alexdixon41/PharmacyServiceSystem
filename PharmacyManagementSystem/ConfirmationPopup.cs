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

        public ConfirmationPopup(String primaryText, String secondaryText)
        {
            this.primaryText = primaryText;
            this.secondaryText = secondaryText;
            InitializeComponent();
        }

        private void ConfirmationPopup_Load(object sender, EventArgs e)
        {
            primaryLabel.Text = primaryText;
            this.Width = primaryLabel.Width + 40;
            secondaryLabel.Text = secondaryText;
            secondaryLabel.MaximumSize = new Size(this.Width - 40, 0);                         
        }
    }
}
