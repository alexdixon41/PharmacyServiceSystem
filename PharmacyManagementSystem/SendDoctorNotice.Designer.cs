﻿namespace PharmacyManagementSystem
{
    partial class SendDoctorNotice
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
            this.label1 = new System.Windows.Forms.Label();
            this.defaultMessageBox = new System.Windows.Forms.TextBox();
            this.customMessageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Doctor Notice";
            // 
            // defaultMessageBox
            // 
            this.defaultMessageBox.Location = new System.Drawing.Point(17, 50);
            this.defaultMessageBox.Multiline = true;
            this.defaultMessageBox.Name = "defaultMessageBox";
            this.defaultMessageBox.ReadOnly = true;
            this.defaultMessageBox.Size = new System.Drawing.Size(546, 113);
            this.defaultMessageBox.TabIndex = 2;
            // 
            // customMessageBox
            // 
            this.customMessageBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customMessageBox.Location = new System.Drawing.Point(17, 169);
            this.customMessageBox.Multiline = true;
            this.customMessageBox.Name = "customMessageBox";
            this.customMessageBox.Size = new System.Drawing.Size(546, 111);
            this.customMessageBox.TabIndex = 3;
            this.customMessageBox.Text = "(Optional) Enter additional message content";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(469, 286);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(94, 32);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SendDoctorNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 366);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.customMessageBox);
            this.Controls.Add(this.defaultMessageBox);
            this.Controls.Add(this.label1);
            this.Name = "SendDoctorNotice";
            this.Text = "SendDoctorNotice";
            this.Load += new System.EventHandler(this.SendDoctorNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox defaultMessageBox;
        private System.Windows.Forms.TextBox customMessageBox;
        private System.Windows.Forms.Button sendButton;
    }
}