﻿namespace PharmacyManagementSystem
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
            this.prescriptionListPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.prescriptionSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectPrescriptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.deletedStatusButton = new System.Windows.Forms.Button();
            this.completeStatusButton = new System.Windows.Forms.Button();
            this.readyStatusButton = new System.Windows.Forms.Button();
            this.activeStatusButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prescriber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prescriptionListPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prescriptionListPanel
            // 
            this.prescriptionListPanel.Controls.Add(this.groupBox3);
            this.prescriptionListPanel.Controls.Add(this.prescriptionSearchBox);
            this.prescriptionListPanel.Controls.Add(this.searchButton);
            this.prescriptionListPanel.Controls.Add(this.selectPrescriptionButton);
            this.prescriptionListPanel.Controls.Add(this.label1);
            this.prescriptionListPanel.Controls.Add(this.listView4);
            this.prescriptionListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionListPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionListPanel.MinimumSize = new System.Drawing.Size(450, 300);
            this.prescriptionListPanel.Name = "prescriptionListPanel";
            this.prescriptionListPanel.Size = new System.Drawing.Size(1294, 627);
            this.prescriptionListPanel.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1255, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(193, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioButton3.Size = new System.Drawing.Size(218, 37);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Prescriber Name";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioButton2.Size = new System.Drawing.Size(190, 37);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Patient Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // prescriptionSearchBox
            // 
            this.prescriptionSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriptionSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionSearchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.prescriptionSearchBox.Location = new System.Drawing.Point(27, 154);
            this.prescriptionSearchBox.Name = "prescriptionSearchBox";
            this.prescriptionSearchBox.Size = new System.Drawing.Size(1082, 34);
            this.prescriptionSearchBox.TabIndex = 4;
            this.prescriptionSearchBox.Text = "Search for a prescription";
            this.prescriptionSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prescriptionSearchBox.Click += new System.EventHandler(this.prescriptionSearchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1122, 149);
            this.searchButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectPrescriptionButton
            // 
            this.selectPrescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPrescriptionButton.AutoSize = true;
            this.selectPrescriptionButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrescriptionButton.Location = new System.Drawing.Point(1026, 14);
            this.selectPrescriptionButton.Name = "selectPrescriptionButton";
            this.selectPrescriptionButton.Size = new System.Drawing.Size(256, 48);
            this.selectPrescriptionButton.TabIndex = 2;
            this.selectPrescriptionButton.Text = "Select Prescription";
            this.selectPrescriptionButton.UseVisualStyleBackColor = true;
            this.selectPrescriptionButton.Click += new System.EventHandler(this.selectPrescriptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prescription Search";
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.statusGroupBox);
            this.prescriptionDetailPanel.Controls.Add(this.tableLayoutPanel1);
            this.prescriptionDetailPanel.Controls.Add(this.backButton);
            this.prescriptionDetailPanel.Controls.Add(this.label2);
            this.prescriptionDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(1294, 627);
            this.prescriptionDetailPanel.TabIndex = 2;
            this.prescriptionDetailPanel.Visible = false;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroupBox.Controls.Add(this.deletedStatusButton);
            this.statusGroupBox.Controls.Add(this.completeStatusButton);
            this.statusGroupBox.Controls.Add(this.readyStatusButton);
            this.statusGroupBox.Controls.Add(this.activeStatusButton);
            this.statusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.Location = new System.Drawing.Point(1003, 82);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(288, 531);
            this.statusGroupBox.TabIndex = 5;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Change Status";
            // 
            // deletedStatusButton
            // 
            this.deletedStatusButton.AutoSize = true;
            this.deletedStatusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedStatusButton.ForeColor = System.Drawing.Color.Crimson;
            this.deletedStatusButton.Location = new System.Drawing.Point(6, 244);
            this.deletedStatusButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.deletedStatusButton.Name = "deletedStatusButton";
            this.deletedStatusButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.deletedStatusButton.Size = new System.Drawing.Size(276, 62);
            this.deletedStatusButton.TabIndex = 6;
            this.deletedStatusButton.Text = "Delete";
            this.deletedStatusButton.UseVisualStyleBackColor = true;
            // 
            // completeStatusButton
            // 
            this.completeStatusButton.AutoSize = true;
            this.completeStatusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeStatusButton.Location = new System.Drawing.Point(6, 171);
            this.completeStatusButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.completeStatusButton.Name = "completeStatusButton";
            this.completeStatusButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.completeStatusButton.Size = new System.Drawing.Size(276, 62);
            this.completeStatusButton.TabIndex = 5;
            this.completeStatusButton.Text = "Complete";
            this.completeStatusButton.UseVisualStyleBackColor = true;
            // 
            // readyStatusButton
            // 
            this.readyStatusButton.AutoSize = true;
            this.readyStatusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyStatusButton.Location = new System.Drawing.Point(6, 98);
            this.readyStatusButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.readyStatusButton.Name = "readyStatusButton";
            this.readyStatusButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.readyStatusButton.Size = new System.Drawing.Size(276, 62);
            this.readyStatusButton.TabIndex = 4;
            this.readyStatusButton.Text = "Ready for Pickup";
            this.readyStatusButton.UseVisualStyleBackColor = true;
            // 
            // activeStatusButton
            // 
            this.activeStatusButton.AutoSize = true;
            this.activeStatusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatusButton.Location = new System.Drawing.Point(6, 26);
            this.activeStatusButton.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.activeStatusButton.Name = "activeStatusButton";
            this.activeStatusButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.activeStatusButton.Size = new System.Drawing.Size(276, 62);
            this.activeStatusButton.TabIndex = 3;
            this.activeStatusButton.Text = "Received";
            this.activeStatusButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 534);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 531);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 505);
            this.panel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 101);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 391);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.listView3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 193);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Allergies";
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Location = new System.Drawing.Point(4, 32);
            this.listView3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(461, 157);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 189);
            this.panel4.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(4, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 153);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Birth: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(492, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 531);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicine Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 505);
            this.panel2.TabIndex = 7;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Location = new System.Drawing.Point(7, 137);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(467, 351);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prescription Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rx Number: ";
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
            this.backButton.TabIndex = 7;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prescription Information";
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.patient,
            this.prescriber,
            this.status,
            this.refills});
            this.listView4.Location = new System.Drawing.Point(27, 197);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1255, 420);
            this.listView4.TabIndex = 6;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // patient
            // 
            this.patient.Text = "Patient";
            this.patient.Width = 240;
            // 
            // prescriber
            // 
            this.prescriber.Text = "Prescriber";
            this.prescriber.Width = 240;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 160;
            // 
            // refills
            // 
            this.refills.Text = "Refills";
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.prescriptionListPanel);
            this.Controls.Add(this.prescriptionDetailPanel);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "PrescriptionsForm";
            this.Size = new System.Drawing.Size(1294, 627);
            this.Load += new System.EventHandler(this.PrescriptionsForm_Load);
            this.prescriptionListPanel.ResumeLayout(false);
            this.prescriptionListPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.prescriptionDetailPanel.ResumeLayout(false);
            this.prescriptionDetailPanel.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel prescriptionListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectPrescriptionButton;
        private System.Windows.Forms.TextBox prescriptionSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel prescriptionDetailPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button deletedStatusButton;
        private System.Windows.Forms.Button completeStatusButton;
        private System.Windows.Forms.Button readyStatusButton;
        private System.Windows.Forms.Button activeStatusButton;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader patient;
        private System.Windows.Forms.ColumnHeader prescriber;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader refills;
    }
}