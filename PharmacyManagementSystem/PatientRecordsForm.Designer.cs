namespace PharmacyManagementSystem
{
    partial class PatientRecordsForm
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
            this.patientSearchLabel = new System.Windows.Forms.Label();
            this.patientSearchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.patientSearchButton = new System.Windows.Forms.Button();
            this.patientSearchSelectButton = new System.Windows.Forms.Button();
            this.patientRecordPanel = new System.Windows.Forms.Panel();
            this.doctorNoticeButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorSearchPanel = new System.Windows.Forms.Panel();
            this.doctorSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.doctorSearchListView = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientSearchPanel.SuspendLayout();
            this.patientRecordPanel.SuspendLayout();
            this.doctorSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientSearchLabel
            // 
            this.patientSearchLabel.AutoSize = true;
            this.patientSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchLabel.Location = new System.Drawing.Point(19, 18);
            this.patientSearchLabel.Name = "patientSearchLabel";
            this.patientSearchLabel.Size = new System.Drawing.Size(269, 44);
            this.patientSearchLabel.TabIndex = 1;
            this.patientSearchLabel.Text = "Patient Search";
            // 
            // patientSearchPanel
            // 
            this.patientSearchPanel.Controls.Add(this.searchBox);
            this.patientSearchPanel.Controls.Add(this.patientSearchButton);
            this.patientSearchPanel.Controls.Add(this.patientSearchSelectButton);
            this.patientSearchPanel.Controls.Add(this.patientSearchLabel);
            this.patientSearchPanel.Controls.Add(this.listView1);
            this.patientSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.patientSearchPanel.Name = "patientSearchPanel";
            this.patientSearchPanel.Size = new System.Drawing.Size(1244, 594);
            this.patientSearchPanel.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBox.Location = new System.Drawing.Point(27, 87);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1067, 34);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search for a patient";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientSearchButton.AutoSize = true;
            this.patientSearchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchButton.Location = new System.Drawing.Point(1100, 82);
            this.patientSearchButton.Name = "patientSearchButton";
            this.patientSearchButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.patientSearchButton.Size = new System.Drawing.Size(135, 42);
            this.patientSearchButton.TabIndex = 2;
            this.patientSearchButton.Text = "Search";
            this.patientSearchButton.UseVisualStyleBackColor = true;
            this.patientSearchButton.Click += new System.EventHandler(this.patientSearchButton_Click);
            // 
            // patientSearchSelectButton
            // 
            this.patientSearchSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientSearchSelectButton.AutoSize = true;
            this.patientSearchSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchSelectButton.Location = new System.Drawing.Point(1033, 14);
            this.patientSearchSelectButton.Name = "patientSearchSelectButton";
            this.patientSearchSelectButton.Size = new System.Drawing.Size(202, 42);
            this.patientSearchSelectButton.TabIndex = 3;
            this.patientSearchSelectButton.Text = "Select Patient";
            this.patientSearchSelectButton.UseVisualStyleBackColor = true;
            this.patientSearchSelectButton.Click += new System.EventHandler(this.patientSearchSelectButton_Click);
            // 
            // patientRecordPanel
            // 
            this.patientRecordPanel.Controls.Add(this.doctorNoticeButton);
            this.patientRecordPanel.Controls.Add(this.label10);
            this.patientRecordPanel.Controls.Add(this.label9);
            this.patientRecordPanel.Controls.Add(this.label8);
            this.patientRecordPanel.Controls.Add(this.label7);
            this.patientRecordPanel.Controls.Add(this.label6);
            this.patientRecordPanel.Controls.Add(this.label5);
            this.patientRecordPanel.Controls.Add(this.label4);
            this.patientRecordPanel.Controls.Add(this.label2);
            this.patientRecordPanel.Controls.Add(this.label3);
            this.patientRecordPanel.Controls.Add(this.label1);
            this.patientRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientRecordPanel.Location = new System.Drawing.Point(0, 0);
            this.patientRecordPanel.Name = "patientRecordPanel";
            this.patientRecordPanel.Size = new System.Drawing.Size(1244, 594);
            this.patientRecordPanel.TabIndex = 1;
            this.patientRecordPanel.Visible = false;
            // 
            // doctorNoticeButton
            // 
            this.doctorNoticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNoticeButton.Location = new System.Drawing.Point(765, 485);
            this.doctorNoticeButton.Name = "doctorNoticeButton";
            this.doctorNoticeButton.Size = new System.Drawing.Size(229, 32);
            this.doctorNoticeButton.TabIndex = 11;
            this.doctorNoticeButton.Text = "Send Notice to Doctor";
            this.doctorNoticeButton.UseVisualStyleBackColor = true;
            this.doctorNoticeButton.Click += new System.EventHandler(this.doctorNoticeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Example other information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Other Information: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Example allergy information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Allergy Information: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "06/06/1998";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "555654123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alex Dixon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name: ";
            // 
            // doctorSearchPanel
            // 
            this.doctorSearchPanel.Controls.Add(this.doctorSearchBox);
            this.doctorSearchPanel.Controls.Add(this.searchButton);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchListView);
            this.doctorSearchPanel.Controls.Add(this.label11);
            this.doctorSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.doctorSearchPanel.Name = "doctorSearchPanel";
            this.doctorSearchPanel.Size = new System.Drawing.Size(1244, 594);
            this.doctorSearchPanel.TabIndex = 4;
            this.doctorSearchPanel.Visible = false;
            // 
            // doctorSearchBox
            // 
            this.doctorSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.doctorSearchBox.Location = new System.Drawing.Point(460, 99);
            this.doctorSearchBox.Name = "doctorSearchBox";
            this.doctorSearchBox.Size = new System.Drawing.Size(415, 27);
            this.doctorSearchBox.TabIndex = 3;
            this.doctorSearchBox.Text = "Search for a Doctor";
            this.doctorSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.doctorSearchBox.Click += new System.EventHandler(this.doctorSearchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(881, 96);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // doctorSearchListView
            // 
            this.doctorSearchListView.Location = new System.Drawing.Point(20, 132);
            this.doctorSearchListView.Name = "doctorSearchListView";
            this.doctorSearchListView.Size = new System.Drawing.Size(974, 326);
            this.doctorSearchListView.TabIndex = 1;
            this.doctorSearchListView.UseCompatibleStateImageBehavior = false;
            this.doctorSearchListView.View = System.Windows.Forms.View.List;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doctor Search";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthDate});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(27, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1208, 451);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 240;
            // 
            // birthDate
            // 
            this.birthDate.Text = "Date of Birth";
            this.birthDate.Width = 200;
            // 
            // PatientRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientSearchPanel);
            this.Controls.Add(this.doctorSearchPanel);
            this.Controls.Add(this.patientRecordPanel);
            this.Name = "PatientRecordsForm";
            this.Size = new System.Drawing.Size(1244, 594);
            this.patientSearchPanel.ResumeLayout(false);
            this.patientSearchPanel.PerformLayout();
            this.patientRecordPanel.ResumeLayout(false);
            this.patientRecordPanel.PerformLayout();
            this.doctorSearchPanel.ResumeLayout(false);
            this.doctorSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label patientSearchLabel;
        private System.Windows.Forms.Panel patientSearchPanel;
        private System.Windows.Forms.Button patientSearchSelectButton;
        private System.Windows.Forms.Panel patientRecordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button patientSearchButton;
        private System.Windows.Forms.Button doctorNoticeButton;
        private System.Windows.Forms.Panel doctorSearchPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView doctorSearchListView;
        private System.Windows.Forms.TextBox doctorSearchBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthDate;
    }
}