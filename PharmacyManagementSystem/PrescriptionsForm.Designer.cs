namespace PharmacyManagementSystem
{
    partial class PrescriptionsForm
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
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.prescriptionListPanel = new System.Windows.Forms.Panel();
            this.prescriptionSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectPrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.deletedStatusButton = new System.Windows.Forms.Button();
            this.completeStatusButton = new System.Windows.Forms.Button();
            this.readyStatusButton = new System.Windows.Forms.Button();
            this.activeStatusButton = new System.Windows.Forms.Button();
            this.prescriptionDetailListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.prescriptionListPanel.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusButton.Location = new System.Drawing.Point(13, 13);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(276, 38);
            this.changeStatusButton.TabIndex = 0;
            this.changeStatusButton.Text = "Change Prescription Status";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // prescriptionListPanel
            // 
            this.prescriptionListPanel.Controls.Add(this.prescriptionSearchBox);
            this.prescriptionListPanel.Controls.Add(this.searchButton);
            this.prescriptionListPanel.Controls.Add(this.selectPrescriptionButton);
            this.prescriptionListPanel.Controls.Add(this.prescriptionListBox);
            this.prescriptionListPanel.Controls.Add(this.label1);
            this.prescriptionListPanel.Location = new System.Drawing.Point(12, 12);
            this.prescriptionListPanel.Name = "prescriptionListPanel";
            this.prescriptionListPanel.Size = new System.Drawing.Size(766, 448);
            this.prescriptionListPanel.TabIndex = 1;
            this.prescriptionListPanel.Visible = false;
            // 
            // prescriptionSearchBox
            // 
            this.prescriptionSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionSearchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.prescriptionSearchBox.Location = new System.Drawing.Point(175, 55);
            this.prescriptionSearchBox.Name = "prescriptionSearchBox";
            this.prescriptionSearchBox.Size = new System.Drawing.Size(283, 27);
            this.prescriptionSearchBox.TabIndex = 4;
            this.prescriptionSearchBox.Text = "Search for a prescription";
            this.prescriptionSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prescriptionSearchBox.Click += new System.EventHandler(this.prescriptionSearchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(464, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 32);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // selectPrescriptionButton
            // 
            this.selectPrescriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrescriptionButton.Location = new System.Drawing.Point(352, 404);
            this.selectPrescriptionButton.Name = "selectPrescriptionButton";
            this.selectPrescriptionButton.Size = new System.Drawing.Size(200, 32);
            this.selectPrescriptionButton.TabIndex = 2;
            this.selectPrescriptionButton.Text = "Select Prescription";
            this.selectPrescriptionButton.UseVisualStyleBackColor = true;
            this.selectPrescriptionButton.Click += new System.EventHandler(this.selectPrescriptionButton_Click);
            // 
            // prescriptionListBox
            // 
            this.prescriptionListBox.FormattingEnabled = true;
            this.prescriptionListBox.ItemHeight = 16;
            this.prescriptionListBox.Location = new System.Drawing.Point(24, 90);
            this.prescriptionListBox.Name = "prescriptionListBox";
            this.prescriptionListBox.Size = new System.Drawing.Size(528, 308);
            this.prescriptionListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prescription Search";
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.statusGroupBox);
            this.prescriptionDetailPanel.Controls.Add(this.prescriptionDetailListView);
            this.prescriptionDetailPanel.Controls.Add(this.label2);
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(12, 12);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(766, 448);
            this.prescriptionDetailPanel.TabIndex = 2;
            this.prescriptionDetailPanel.Visible = false;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.deletedStatusButton);
            this.statusGroupBox.Controls.Add(this.completeStatusButton);
            this.statusGroupBox.Controls.Add(this.readyStatusButton);
            this.statusGroupBox.Controls.Add(this.activeStatusButton);
            this.statusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.Location = new System.Drawing.Point(559, 91);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(179, 252);
            this.statusGroupBox.TabIndex = 4;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "New Status";
            // 
            // deletedStatusButton
            // 
            this.deletedStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedStatusButton.ForeColor = System.Drawing.Color.Crimson;
            this.deletedStatusButton.Location = new System.Drawing.Point(6, 211);
            this.deletedStatusButton.Name = "deletedStatusButton";
            this.deletedStatusButton.Size = new System.Drawing.Size(167, 35);
            this.deletedStatusButton.TabIndex = 6;
            this.deletedStatusButton.Text = "Deleted";
            this.deletedStatusButton.UseVisualStyleBackColor = true;
            this.deletedStatusButton.Click += new System.EventHandler(this.deletedStatusButton_Click);
            // 
            // completeStatusButton
            // 
            this.completeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeStatusButton.Location = new System.Drawing.Point(6, 119);
            this.completeStatusButton.Name = "completeStatusButton";
            this.completeStatusButton.Size = new System.Drawing.Size(167, 35);
            this.completeStatusButton.TabIndex = 5;
            this.completeStatusButton.Text = "Complete";
            this.completeStatusButton.UseVisualStyleBackColor = true;
            this.completeStatusButton.Click += new System.EventHandler(this.completeStatusButton_Click);
            // 
            // readyStatusButton
            // 
            this.readyStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyStatusButton.Location = new System.Drawing.Point(6, 78);
            this.readyStatusButton.Name = "readyStatusButton";
            this.readyStatusButton.Size = new System.Drawing.Size(167, 35);
            this.readyStatusButton.TabIndex = 4;
            this.readyStatusButton.Text = "Ready";
            this.readyStatusButton.UseVisualStyleBackColor = true;
            this.readyStatusButton.Click += new System.EventHandler(this.readyStatusButton_Click);
            // 
            // activeStatusButton
            // 
            this.activeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatusButton.Location = new System.Drawing.Point(6, 37);
            this.activeStatusButton.Name = "activeStatusButton";
            this.activeStatusButton.Size = new System.Drawing.Size(167, 35);
            this.activeStatusButton.TabIndex = 3;
            this.activeStatusButton.Text = "Active";
            this.activeStatusButton.UseVisualStyleBackColor = true;
            this.activeStatusButton.Click += new System.EventHandler(this.activeStatusButton_Click);
            // 
            // prescriptionDetailListView
            // 
            this.prescriptionDetailListView.Location = new System.Drawing.Point(30, 91);
            this.prescriptionDetailListView.Name = "prescriptionDetailListView";
            this.prescriptionDetailListView.Size = new System.Drawing.Size(523, 252);
            this.prescriptionDetailListView.TabIndex = 1;
            this.prescriptionDetailListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionDetailListView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rx #: ";
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.prescriptionListPanel);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.prescriptionDetailPanel);
            this.Name = "PrescriptionsForm";
            this.Text = "StatusForm";
            this.prescriptionListPanel.ResumeLayout(false);
            this.prescriptionListPanel.PerformLayout();
            this.prescriptionDetailPanel.ResumeLayout(false);
            this.prescriptionDetailPanel.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.Panel prescriptionListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox prescriptionListBox;
        private System.Windows.Forms.Button selectPrescriptionButton;
        private System.Windows.Forms.TextBox prescriptionSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel prescriptionDetailPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView prescriptionDetailListView;
        private System.Windows.Forms.Button activeStatusButton;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.Button readyStatusButton;
        private System.Windows.Forms.Button completeStatusButton;
        private System.Windows.Forms.Button deletedStatusButton;
    }
}