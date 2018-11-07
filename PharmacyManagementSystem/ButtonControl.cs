using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    partial class ButtonControl : UserControl
    {
        public Label buttonLabel = new Label();
        public Label badgeLabel = new Label();

        public ButtonControl()
        {
            this.buttonLabel = new System.Windows.Forms.Label();
            this.badgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Text = "Button Text";

            this.badgeLabel.Name = "badgeLabel";
            this.badgeLabel.Text = "Badge Count";

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.badgeLabel);
            this.Name = "buttonControl";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
