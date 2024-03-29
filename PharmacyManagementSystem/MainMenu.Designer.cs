﻿namespace PharmacyManagementSystem
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newRefillRequestsButton = new System.Windows.Forms.Button();
            this.newNoticesButton = new System.Windows.Forms.Button();
            this.newPrescriptionsButton = new System.Windows.Forms.Button();
            this.patientRecordsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 240;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Size = new System.Drawing.Size(1232, 753);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1MinSize = 300;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(250, 753);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.newRefillRequestsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newNoticesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newPrescriptionsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientRecordsButton, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newRefillRequestsButton
            // 
            this.newRefillRequestsButton.BackColor = System.Drawing.Color.White;
            this.newRefillRequestsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newRefillRequestsButton.FlatAppearance.BorderSize = 0;
            this.newRefillRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRefillRequestsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRefillRequestsButton.Location = new System.Drawing.Point(10, 210);
            this.newRefillRequestsButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.newRefillRequestsButton.Name = "newRefillRequestsButton";
            this.newRefillRequestsButton.Size = new System.Drawing.Size(230, 90);
            this.newRefillRequestsButton.TabIndex = 0;
            this.newRefillRequestsButton.Text = "Refill Requests";
            this.newRefillRequestsButton.UseVisualStyleBackColor = false;
            this.newRefillRequestsButton.Click += new System.EventHandler(this.newRefillRequestsButton_Click);
            // 
            // newNoticesButton
            // 
            this.newNoticesButton.BackColor = System.Drawing.Color.White;
            this.newNoticesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNoticesButton.FlatAppearance.BorderSize = 0;
            this.newNoticesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoticesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoticesButton.Location = new System.Drawing.Point(10, 10);
            this.newNoticesButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.newNoticesButton.Name = "newNoticesButton";
            this.newNoticesButton.Size = new System.Drawing.Size(230, 90);
            this.newNoticesButton.TabIndex = 0;
            this.newNoticesButton.Text = "Notices";
            this.newNoticesButton.UseVisualStyleBackColor = false;
            this.newNoticesButton.Click += new System.EventHandler(this.newNoticesButton_Click);
            // 
            // newPrescriptionsButton
            // 
            this.newPrescriptionsButton.BackColor = System.Drawing.Color.White;
            this.newPrescriptionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPrescriptionsButton.FlatAppearance.BorderSize = 0;
            this.newPrescriptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPrescriptionsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrescriptionsButton.Location = new System.Drawing.Point(10, 110);
            this.newPrescriptionsButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.newPrescriptionsButton.Name = "newPrescriptionsButton";
            this.newPrescriptionsButton.Size = new System.Drawing.Size(230, 90);
            this.newPrescriptionsButton.TabIndex = 1;
            this.newPrescriptionsButton.Text = "Prescriptions";
            this.newPrescriptionsButton.UseVisualStyleBackColor = false;
            this.newPrescriptionsButton.Click += new System.EventHandler(this.newPrescriptionsButton_Click);
            // 
            // patientRecordsButton
            // 
            this.patientRecordsButton.BackColor = System.Drawing.Color.White;
            this.patientRecordsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientRecordsButton.FlatAppearance.BorderSize = 0;
            this.patientRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientRecordsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRecordsButton.Location = new System.Drawing.Point(10, 310);
            this.patientRecordsButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.patientRecordsButton.Name = "patientRecordsButton";
            this.patientRecordsButton.Size = new System.Drawing.Size(230, 90);
            this.patientRecordsButton.TabIndex = 3;
            this.patientRecordsButton.Text = "Patient Records";
            this.patientRecordsButton.UseVisualStyleBackColor = false;
            this.patientRecordsButton.Click += new System.EventHandler(this.patientRecordsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(250, 352);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = global::PharmacyManagementSystem.Properties.Resources.icons8_exit_50;
            this.logoutButton.Location = new System.Drawing.Point(11, 10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.logoutButton.Size = new System.Drawing.Size(228, 332);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "MainMenu";
            this.Text = "Pharmacy Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button newRefillRequestsButton;
        private System.Windows.Forms.Button patientRecordsButton;
        private System.Windows.Forms.Button newNoticesButton;
        private System.Windows.Forms.Button newPrescriptionsButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
    }
}