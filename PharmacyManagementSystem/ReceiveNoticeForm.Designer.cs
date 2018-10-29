namespace PharmacyManagementSystem
{
    partial class ReceiveNoticeForm
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
            this.newNoticeButton = new System.Windows.Forms.Button();
            this.noticeListPanel = new System.Windows.Forms.Panel();
            this.ViewNoticeButton = new System.Windows.Forms.Button();
            this.noticeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noticeDetailPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.noticeTitleLabel = new System.Windows.Forms.Label();
            this.noticeListPanel.SuspendLayout();
            this.noticeDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newNoticeButton
            // 
            this.newNoticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoticeButton.Location = new System.Drawing.Point(13, 13);
            this.newNoticeButton.Name = "newNoticeButton";
            this.newNoticeButton.Size = new System.Drawing.Size(198, 36);
            this.newNoticeButton.TabIndex = 0;
            this.newNoticeButton.Text = "New Doctor Notice";
            this.newNoticeButton.UseVisualStyleBackColor = true;
            this.newNoticeButton.Click += new System.EventHandler(this.newNoticeButton_Click);
            // 
            // noticeListPanel
            // 
            this.noticeListPanel.Controls.Add(this.ViewNoticeButton);
            this.noticeListPanel.Controls.Add(this.noticeListBox);
            this.noticeListPanel.Controls.Add(this.label1);
            this.noticeListPanel.Location = new System.Drawing.Point(12, 12);
            this.noticeListPanel.Name = "noticeListPanel";
            this.noticeListPanel.Size = new System.Drawing.Size(762, 459);
            this.noticeListPanel.TabIndex = 1;
            this.noticeListPanel.Visible = false;
            // 
            // ViewNoticeButton
            // 
            this.ViewNoticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewNoticeButton.Location = new System.Drawing.Point(398, 353);
            this.ViewNoticeButton.Name = "ViewNoticeButton";
            this.ViewNoticeButton.Size = new System.Drawing.Size(147, 32);
            this.ViewNoticeButton.TabIndex = 2;
            this.ViewNoticeButton.Text = "View Notice";
            this.ViewNoticeButton.UseVisualStyleBackColor = true;
            this.ViewNoticeButton.Click += new System.EventHandler(this.ViewNoticeButton_Click);
            // 
            // noticeListBox
            // 
            this.noticeListBox.FormattingEnabled = true;
            this.noticeListBox.ItemHeight = 16;
            this.noticeListBox.Location = new System.Drawing.Point(30, 70);
            this.noticeListBox.Name = "noticeListBox";
            this.noticeListBox.Size = new System.Drawing.Size(516, 276);
            this.noticeListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Notices";
            // 
            // noticeDetailPanel
            // 
            this.noticeDetailPanel.Controls.Add(this.textBox1);
            this.noticeDetailPanel.Controls.Add(this.noticeTitleLabel);
            this.noticeDetailPanel.Location = new System.Drawing.Point(12, 12);
            this.noticeDetailPanel.Name = "noticeDetailPanel";
            this.noticeDetailPanel.Size = new System.Drawing.Size(762, 459);
            this.noticeDetailPanel.TabIndex = 3;
            this.noticeDetailPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 235);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "I would like to discuss Ethen Holzapfel\'s case with you. It is quite urgent. Than" +
    "k you.";
            // 
            // noticeTitleLabel
            // 
            this.noticeTitleLabel.AutoSize = true;
            this.noticeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTitleLabel.Location = new System.Drawing.Point(21, 20);
            this.noticeTitleLabel.Name = "noticeTitleLabel";
            this.noticeTitleLabel.Size = new System.Drawing.Size(303, 29);
            this.noticeTitleLabel.TabIndex = 0;
            this.noticeTitleLabel.Text = "Notice From Dr. Doolittle";
            // 
            // ReceiveNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.noticeListPanel);
            this.Controls.Add(this.newNoticeButton);
            this.Controls.Add(this.noticeDetailPanel);
            this.Name = "ReceiveNoticeForm";
            this.Text = "ReceiveNoticeForm";
            this.noticeListPanel.ResumeLayout(false);
            this.noticeListPanel.PerformLayout();
            this.noticeDetailPanel.ResumeLayout(false);
            this.noticeDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newNoticeButton;
        private System.Windows.Forms.Panel noticeListPanel;
        private System.Windows.Forms.ListBox noticeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewNoticeButton;
        private System.Windows.Forms.Panel noticeDetailPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label noticeTitleLabel;
    }
}