namespace PharmacyManagementSystem
{
    partial class NewPrescriptionForm
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
            this.newPrescriptionsPanel = new System.Windows.Forms.Panel();
            this.prescriptionDetailButton = new System.Windows.Forms.Button();
            this.newPrescriptionsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prescriptionDetailsListView = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allergyInformationListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.medicineHistoryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.newPrescriptionsPanel.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPrescriptionsPanel
            // 
            this.newPrescriptionsPanel.Controls.Add(this.prescriptionDetailButton);
            this.newPrescriptionsPanel.Controls.Add(this.newPrescriptionsListBox);
            this.newPrescriptionsPanel.Controls.Add(this.label1);
            this.newPrescriptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPrescriptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.newPrescriptionsPanel.Name = "newPrescriptionsPanel";
            this.newPrescriptionsPanel.Size = new System.Drawing.Size(1006, 529);
            this.newPrescriptionsPanel.TabIndex = 1;
            // 
            // prescriptionDetailButton
            // 
            this.prescriptionDetailButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionDetailButton.Location = new System.Drawing.Point(797, 27);
            this.prescriptionDetailButton.Name = "prescriptionDetailButton";
            this.prescriptionDetailButton.Size = new System.Drawing.Size(197, 35);
            this.prescriptionDetailButton.TabIndex = 2;
            this.prescriptionDetailButton.Text = "View Prescription";
            this.prescriptionDetailButton.UseVisualStyleBackColor = true;
            this.prescriptionDetailButton.Click += new System.EventHandler(this.prescriptionDetailButton_Click);
            // 
            // newPrescriptionsListBox
            // 
            this.newPrescriptionsListBox.FormattingEnabled = true;
            this.newPrescriptionsListBox.ItemHeight = 16;
            this.newPrescriptionsListBox.Location = new System.Drawing.Point(12, 68);
            this.newPrescriptionsListBox.Name = "newPrescriptionsListBox";
            this.newPrescriptionsListBox.Size = new System.Drawing.Size(982, 452);
            this.newPrescriptionsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Prescriptions";
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.groupBox2);
            this.prescriptionDetailPanel.Controls.Add(this.groupBox1);
            this.prescriptionDetailPanel.Controls.Add(this.label2);
            this.prescriptionDetailPanel.Controls.Add(this.changeStatusButton);
            this.prescriptionDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(1006, 529);
            this.prescriptionDetailPanel.TabIndex = 2;
            this.prescriptionDetailPanel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prescriptionDetailsListView);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(505, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(489, 462);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prescription Details";
            // 
            // prescriptionDetailsListView
            // 
            this.prescriptionDetailsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriptionDetailsListView.Location = new System.Drawing.Point(13, 108);
            this.prescriptionDetailsListView.Name = "prescriptionDetailsListView";
            this.prescriptionDetailsListView.Size = new System.Drawing.Size(467, 348);
            this.prescriptionDetailsListView.TabIndex = 1;
            this.prescriptionDetailsListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionDetailsListView.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rx Number: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allergyInformationListBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.medicineHistoryListBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(480, 462);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // allergyInformationListBox
            // 
            this.allergyInformationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allergyInformationListBox.FormattingEnabled = true;
            this.allergyInformationListBox.ItemHeight = 16;
            this.allergyInformationListBox.Location = new System.Drawing.Point(13, 308);
            this.allergyInformationListBox.Name = "allergyInformationListBox";
            this.allergyInformationListBox.Size = new System.Drawing.Size(458, 148);
            this.allergyInformationListBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Allergy Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Medicine History";
            // 
            // medicineHistoryListBox
            // 
            this.medicineHistoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicineHistoryListBox.FormattingEnabled = true;
            this.medicineHistoryListBox.ItemHeight = 16;
            this.medicineHistoryListBox.Location = new System.Drawing.Point(13, 108);
            this.medicineHistoryListBox.Name = "medicineHistoryListBox";
            this.medicineHistoryListBox.Size = new System.Drawing.Size(458, 148);
            this.medicineHistoryListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "New Prescription";
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusButton.Location = new System.Drawing.Point(735, 12);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(259, 35);
            this.changeStatusButton.TabIndex = 18;
            this.changeStatusButton.Text = "Change Prescription Status";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            // 
            // NewPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.prescriptionDetailPanel);
            this.Controls.Add(this.newPrescriptionsPanel);
            this.Name = "NewPrescriptionForm";
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.NewPrescriptionForm_Load);
            this.newPrescriptionsPanel.ResumeLayout(false);
            this.newPrescriptionsPanel.PerformLayout();
            this.prescriptionDetailPanel.ResumeLayout(false);
            this.prescriptionDetailPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel newPrescriptionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox newPrescriptionsListBox;
        private System.Windows.Forms.Button prescriptionDetailButton;
        private System.Windows.Forms.Panel prescriptionDetailPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView prescriptionDetailsListView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox allergyInformationListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox medicineHistoryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeStatusButton;
    }
}