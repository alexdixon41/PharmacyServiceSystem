namespace PharmacyManagementSystem
{
    partial class PrescriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewPrescriptionsButton = new System.Windows.Forms.Button();
            this.newPrescriptionsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newPrescriptionsListBox = new System.Windows.Forms.ListBox();
            this.patientRecordButton = new System.Windows.Forms.Button();
            this.patientDetailPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientPrescriptionsListBox = new System.Windows.Forms.ListBox();
            this.prescriptionDetailButton = new System.Windows.Forms.Button();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.refillStatusButton = new System.Windows.Forms.Button();
            this.prescriptionDetailListView = new System.Windows.Forms.ListView();
            this.newPrescriptionsPanel.SuspendLayout();
            this.patientDetailPanel.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPrescriptionsButton
            // 
            this.viewPrescriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPrescriptionsButton.Location = new System.Drawing.Point(13, 13);
            this.viewPrescriptionsButton.Name = "viewPrescriptionsButton";
            this.viewPrescriptionsButton.Size = new System.Drawing.Size(230, 32);
            this.viewPrescriptionsButton.TabIndex = 0;
            this.viewPrescriptionsButton.Text = "View New Prescriptions";
            this.viewPrescriptionsButton.UseVisualStyleBackColor = true;
            this.viewPrescriptionsButton.Click += new System.EventHandler(this.viewPrescriptionsButton_Click);
            // 
            // newPrescriptionsPanel
            // 
            this.newPrescriptionsPanel.Controls.Add(this.patientRecordButton);
            this.newPrescriptionsPanel.Controls.Add(this.newPrescriptionsListBox);
            this.newPrescriptionsPanel.Controls.Add(this.label1);
            this.newPrescriptionsPanel.Location = new System.Drawing.Point(12, 12);
            this.newPrescriptionsPanel.Name = "newPrescriptionsPanel";
            this.newPrescriptionsPanel.Size = new System.Drawing.Size(762, 459);
            this.newPrescriptionsPanel.TabIndex = 1;
            this.newPrescriptionsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Prescriptions";
            // 
            // newPrescriptionsListBox
            // 
            this.newPrescriptionsListBox.FormattingEnabled = true;
            this.newPrescriptionsListBox.ItemHeight = 16;
            this.newPrescriptionsListBox.Location = new System.Drawing.Point(9, 99);
            this.newPrescriptionsListBox.Name = "newPrescriptionsListBox";
            this.newPrescriptionsListBox.Size = new System.Drawing.Size(529, 276);
            this.newPrescriptionsListBox.TabIndex = 1;
            // 
            // patientRecordButton
            // 
            this.patientRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRecordButton.Location = new System.Drawing.Point(308, 381);
            this.patientRecordButton.Name = "patientRecordButton";
            this.patientRecordButton.Size = new System.Drawing.Size(230, 32);
            this.patientRecordButton.TabIndex = 2;
            this.patientRecordButton.Text = "Display Patient Records";
            this.patientRecordButton.UseVisualStyleBackColor = true;
            this.patientRecordButton.Click += new System.EventHandler(this.patientRecordButton_Click);
            // 
            // patientDetailPanel
            // 
            this.patientDetailPanel.Controls.Add(this.prescriptionDetailButton);
            this.patientDetailPanel.Controls.Add(this.patientPrescriptionsListBox);
            this.patientDetailPanel.Controls.Add(this.label5);
            this.patientDetailPanel.Controls.Add(this.label4);
            this.patientDetailPanel.Controls.Add(this.label3);
            this.patientDetailPanel.Controls.Add(this.label2);
            this.patientDetailPanel.Location = new System.Drawing.Point(12, 12);
            this.patientDetailPanel.Name = "patientDetailPanel";
            this.patientDetailPanel.Size = new System.Drawing.Size(762, 459);
            this.patientDetailPanel.TabIndex = 2;
            this.patientDetailPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DOB: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Medicine History";
            // 
            // patientPrescriptionsListBox
            // 
            this.patientPrescriptionsListBox.FormattingEnabled = true;
            this.patientPrescriptionsListBox.ItemHeight = 16;
            this.patientPrescriptionsListBox.Location = new System.Drawing.Point(16, 175);
            this.patientPrescriptionsListBox.Name = "patientPrescriptionsListBox";
            this.patientPrescriptionsListBox.Size = new System.Drawing.Size(521, 196);
            this.patientPrescriptionsListBox.TabIndex = 4;
            // 
            // prescriptionDetailButton
            // 
            this.prescriptionDetailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionDetailButton.Location = new System.Drawing.Point(292, 377);
            this.prescriptionDetailButton.Name = "prescriptionDetailButton";
            this.prescriptionDetailButton.Size = new System.Drawing.Size(245, 32);
            this.prescriptionDetailButton.TabIndex = 5;
            this.prescriptionDetailButton.Text = "Display Prescription Details";
            this.prescriptionDetailButton.UseVisualStyleBackColor = true;
            this.prescriptionDetailButton.Click += new System.EventHandler(this.prescriptionDetailButton_Click);
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.prescriptionDetailListView);
            this.prescriptionDetailPanel.Controls.Add(this.refillStatusButton);
            this.prescriptionDetailPanel.Controls.Add(this.label6);
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(12, 12);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(762, 459);
            this.prescriptionDetailPanel.TabIndex = 3;
            this.prescriptionDetailPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rx #: ";
            // 
            // refillStatusButton
            // 
            this.refillStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillStatusButton.Location = new System.Drawing.Point(317, 367);
            this.refillStatusButton.Name = "refillStatusButton";
            this.refillStatusButton.Size = new System.Drawing.Size(220, 32);
            this.refillStatusButton.TabIndex = 2;
            this.refillStatusButton.Text = "Change Refill Status";
            this.refillStatusButton.UseVisualStyleBackColor = true;
            // 
            // prescriptionDetailListView
            // 
            this.prescriptionDetailListView.Location = new System.Drawing.Point(21, 86);
            this.prescriptionDetailListView.Name = "prescriptionDetailListView";
            this.prescriptionDetailListView.Size = new System.Drawing.Size(516, 275);
            this.prescriptionDetailListView.TabIndex = 3;
            this.prescriptionDetailListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionDetailListView.View = System.Windows.Forms.View.List;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.prescriptionDetailPanel);
            this.Controls.Add(this.patientDetailPanel);
            this.Controls.Add(this.newPrescriptionsPanel);
            this.Controls.Add(this.viewPrescriptionsButton);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            this.newPrescriptionsPanel.ResumeLayout(false);
            this.newPrescriptionsPanel.PerformLayout();
            this.patientDetailPanel.ResumeLayout(false);
            this.patientDetailPanel.PerformLayout();
            this.prescriptionDetailPanel.ResumeLayout(false);
            this.prescriptionDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewPrescriptionsButton;
        private System.Windows.Forms.Panel newPrescriptionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox newPrescriptionsListBox;
        private System.Windows.Forms.Button patientRecordButton;
        private System.Windows.Forms.Panel patientDetailPanel;
        private System.Windows.Forms.Button prescriptionDetailButton;
        private System.Windows.Forms.ListBox patientPrescriptionsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel prescriptionDetailPanel;
        private System.Windows.Forms.Button refillStatusButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView prescriptionDetailListView;
    }
}