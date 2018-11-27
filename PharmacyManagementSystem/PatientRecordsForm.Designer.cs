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
            this.patientSearchListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientRecordPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.maritalStatusLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.allergyTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateFilled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disordersTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.doctorNoticeButton = new System.Windows.Forms.Button();
            this.doctorSearchPanel = new System.Windows.Forms.Panel();
            this.sendDoctorNoticeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.doctorSearchBackButton = new System.Windows.Forms.Button();
            this.doctorSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.doctorSearchListView = new System.Windows.Forms.ListView();
            this.docName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientSearchPanel.SuspendLayout();
            this.patientRecordPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.patientSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientSearchPanel.Controls.Add(this.searchBox);
            this.patientSearchPanel.Controls.Add(this.patientSearchButton);
            this.patientSearchPanel.Controls.Add(this.patientSearchSelectButton);
            this.patientSearchPanel.Controls.Add(this.patientSearchLabel);
            this.patientSearchPanel.Controls.Add(this.patientSearchListView);
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
            this.searchBox.Location = new System.Drawing.Point(168, 88);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1067, 34);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search for a patient";
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.AutoSize = true;
            this.patientSearchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchButton.Location = new System.Drawing.Point(27, 83);
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
            this.patientSearchSelectButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchSelectButton.Location = new System.Drawing.Point(1033, 14);
            this.patientSearchSelectButton.Name = "patientSearchSelectButton";
            this.patientSearchSelectButton.Size = new System.Drawing.Size(202, 48);
            this.patientSearchSelectButton.TabIndex = 3;
            this.patientSearchSelectButton.Text = "Select Patient";
            this.patientSearchSelectButton.UseVisualStyleBackColor = true;
            this.patientSearchSelectButton.Click += new System.EventHandler(this.patientSearchSelectButton_Click);
            // 
            // patientSearchListView
            // 
            this.patientSearchListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientSearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthDate});
            this.patientSearchListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchListView.FullRowSelect = true;
            this.patientSearchListView.Location = new System.Drawing.Point(27, 131);
            this.patientSearchListView.Name = "patientSearchListView";
            this.patientSearchListView.Size = new System.Drawing.Size(1208, 451);
            this.patientSearchListView.TabIndex = 6;
            this.patientSearchListView.UseCompatibleStateImageBehavior = false;
            this.patientSearchListView.View = System.Windows.Forms.View.Details;
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
            // patientRecordPanel
            // 
            this.patientRecordPanel.Controls.Add(this.nameLabel);
            this.patientRecordPanel.Controls.Add(this.maritalStatusLabel);
            this.patientRecordPanel.Controls.Add(this.birthDateLabel);
            this.patientRecordPanel.Controls.Add(this.label2);
            this.patientRecordPanel.Controls.Add(this.label1);
            this.patientRecordPanel.Controls.Add(this.tableLayoutPanel2);
            this.patientRecordPanel.Controls.Add(this.backButton);
            this.patientRecordPanel.Controls.Add(this.doctorNoticeButton);
            this.patientRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientRecordPanel.Location = new System.Drawing.Point(0, 0);
            this.patientRecordPanel.Name = "patientRecordPanel";
            this.patientRecordPanel.Size = new System.Drawing.Size(1244, 594);
            this.patientRecordPanel.TabIndex = 1;
            this.patientRecordPanel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(100, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(303, 44);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Medical Records";
            // 
            // maritalStatusLabel
            // 
            this.maritalStatusLabel.AutoSize = true;
            this.maritalStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maritalStatusLabel.Location = new System.Drawing.Point(169, 131);
            this.maritalStatusLabel.Name = "maritalStatusLabel";
            this.maritalStatusLabel.Size = new System.Drawing.Size(0, 28);
            this.maritalStatusLabel.TabIndex = 24;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateLabel.Location = new System.Drawing.Point(159, 90);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(0, 28);
            this.birthDateLabel.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Marital Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Date of Birth: ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 199);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1205, 383);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.allergyTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 194);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 189);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Allergies";
            // 
            // allergyTextBox
            // 
            this.allergyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allergyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergyTextBox.Location = new System.Drawing.Point(3, 32);
            this.allergyTextBox.Multiline = true;
            this.allergyTextBox.Name = "allergyTextBox";
            this.allergyTextBox.ReadOnly = true;
            this.allergyTextBox.Size = new System.Drawing.Size(590, 154);
            this.allergyTextBox.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 185);
            this.panel4.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateFilled,
            this.columnHeader1,
            this.quantity,
            this.dosage});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(4, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 149);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dateFilled
            // 
            this.dateFilled.Text = "Date";
            this.dateFilled.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 100;
            // 
            // dosage
            // 
            this.dosage.Text = "Dosage";
            this.dosage.Width = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Medicine History";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disordersTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(605, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 185);
            this.panel1.TabIndex = 2;
            // 
            // disordersTextBox
            // 
            this.disordersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disordersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disordersTextBox.Location = new System.Drawing.Point(3, 33);
            this.disordersTextBox.Multiline = true;
            this.disordersTextBox.Name = "disordersTextBox";
            this.disordersTextBox.ReadOnly = true;
            this.disordersTextBox.Size = new System.Drawing.Size(590, 149);
            this.disordersTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Disorders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notesTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(605, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 186);
            this.panel2.TabIndex = 3;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(3, 32);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(590, 154);
            this.notesTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Notes";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::PharmacyManagementSystem.Properties.Resources.icons8_left_32;
            this.backButton.Location = new System.Drawing.Point(19, 18);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 40);
            this.backButton.TabIndex = 12;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // doctorNoticeButton
            // 
            this.doctorNoticeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorNoticeButton.AutoSize = true;
            this.doctorNoticeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNoticeButton.Location = new System.Drawing.Point(929, 14);
            this.doctorNoticeButton.Name = "doctorNoticeButton";
            this.doctorNoticeButton.Size = new System.Drawing.Size(303, 48);
            this.doctorNoticeButton.TabIndex = 11;
            this.doctorNoticeButton.Text = "Send Notice to Doctor";
            this.doctorNoticeButton.UseVisualStyleBackColor = true;
            this.doctorNoticeButton.Click += new System.EventHandler(this.doctorNoticeButton_Click);
            // 
            // doctorSearchPanel
            // 
            this.doctorSearchPanel.Controls.Add(this.sendDoctorNoticeButton);
            this.doctorSearchPanel.Controls.Add(this.label5);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchBackButton);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchBox);
            this.doctorSearchPanel.Controls.Add(this.searchButton);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchListView);
            this.doctorSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.doctorSearchPanel.Name = "doctorSearchPanel";
            this.doctorSearchPanel.Size = new System.Drawing.Size(1244, 594);
            this.doctorSearchPanel.TabIndex = 4;
            this.doctorSearchPanel.Visible = false;
            // 
            // sendDoctorNoticeButton
            // 
            this.sendDoctorNoticeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendDoctorNoticeButton.AutoSize = true;
            this.sendDoctorNoticeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendDoctorNoticeButton.Location = new System.Drawing.Point(1033, 14);
            this.sendDoctorNoticeButton.Name = "sendDoctorNoticeButton";
            this.sendDoctorNoticeButton.Size = new System.Drawing.Size(199, 48);
            this.sendDoctorNoticeButton.TabIndex = 15;
            this.sendDoctorNoticeButton.Text = "Select Doctor";
            this.sendDoctorNoticeButton.UseVisualStyleBackColor = true;
            this.sendDoctorNoticeButton.Click += new System.EventHandler(this.sendDoctorNoticeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 44);
            this.label5.TabIndex = 14;
            this.label5.Text = "Send Doctor Notice";
            // 
            // doctorSearchBackButton
            // 
            this.doctorSearchBackButton.AutoSize = true;
            this.doctorSearchBackButton.BackColor = System.Drawing.Color.Transparent;
            this.doctorSearchBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.doctorSearchBackButton.FlatAppearance.BorderSize = 0;
            this.doctorSearchBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorSearchBackButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchBackButton.Image = global::PharmacyManagementSystem.Properties.Resources.icons8_left_32;
            this.doctorSearchBackButton.Location = new System.Drawing.Point(19, 18);
            this.doctorSearchBackButton.Name = "doctorSearchBackButton";
            this.doctorSearchBackButton.Size = new System.Drawing.Size(75, 40);
            this.doctorSearchBackButton.TabIndex = 13;
            this.doctorSearchBackButton.UseVisualStyleBackColor = false;
            this.doctorSearchBackButton.Click += new System.EventHandler(this.doctorSearchBackButton_Click);
            // 
            // doctorSearchBox
            // 
            this.doctorSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.doctorSearchBox.Location = new System.Drawing.Point(168, 87);
            this.doctorSearchBox.Name = "doctorSearchBox";
            this.doctorSearchBox.Size = new System.Drawing.Size(1064, 34);
            this.doctorSearchBox.TabIndex = 3;
            this.doctorSearchBox.Text = "Search for a Doctor";
            this.doctorSearchBox.Click += new System.EventHandler(this.doctorSearchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(27, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 42);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // doctorSearchListView
            // 
            this.doctorSearchListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorSearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.docName,
            this.officeName,
            this.officeNumber});
            this.doctorSearchListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchListView.FullRowSelect = true;
            this.doctorSearchListView.Location = new System.Drawing.Point(27, 131);
            this.doctorSearchListView.MultiSelect = false;
            this.doctorSearchListView.Name = "doctorSearchListView";
            this.doctorSearchListView.Size = new System.Drawing.Size(1205, 451);
            this.doctorSearchListView.TabIndex = 16;
            this.doctorSearchListView.UseCompatibleStateImageBehavior = false;
            this.doctorSearchListView.View = System.Windows.Forms.View.Details;
            // 
            // docName
            // 
            this.docName.Text = "Name";
            this.docName.Width = 200;
            // 
            // officeName
            // 
            this.officeName.Text = "Office Name";
            this.officeName.Width = 200;
            // 
            // officeNumber
            // 
            this.officeNumber.Text = "Office Number";
            this.officeNumber.Width = 180;
            // 
            // PatientRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doctorSearchPanel);
            this.Controls.Add(this.patientRecordPanel);
            this.Controls.Add(this.patientSearchPanel);
            this.Name = "PatientRecordsForm";
            this.Size = new System.Drawing.Size(1244, 594);
            this.patientSearchPanel.ResumeLayout(false);
            this.patientSearchPanel.PerformLayout();
            this.patientRecordPanel.ResumeLayout(false);
            this.patientRecordPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.doctorSearchPanel.ResumeLayout(false);
            this.doctorSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label patientSearchLabel;
        private System.Windows.Forms.Panel patientSearchPanel;
        private System.Windows.Forms.Button patientSearchSelectButton;
        private System.Windows.Forms.Panel patientRecordPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button patientSearchButton;
        private System.Windows.Forms.Button doctorNoticeButton;
        private System.Windows.Forms.Panel doctorSearchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox doctorSearchBox;
        private System.Windows.Forms.ListView patientSearchListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox allergyTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader dateFilled;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader dosage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox disordersTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maritalStatusLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Button doctorSearchBackButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendDoctorNoticeButton;
        private System.Windows.Forms.ListView doctorSearchListView;
        private System.Windows.Forms.ColumnHeader docName;
        private System.Windows.Forms.ColumnHeader officeName;
        private System.Windows.Forms.ColumnHeader officeNumber;
    }
}