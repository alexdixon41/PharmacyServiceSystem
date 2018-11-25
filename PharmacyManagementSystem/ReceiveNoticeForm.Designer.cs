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
            this.noticeListPanel = new System.Windows.Forms.Panel();
            this.noticesListView = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewNoticeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noticeDetailPanel = new System.Windows.Forms.Panel();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.noticeTitleLabel = new System.Windows.Forms.Label();
            this.noticeListPanel.SuspendLayout();
            this.noticeDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // noticeListPanel
            // 
            this.noticeListPanel.Controls.Add(this.noticesListView);
            this.noticeListPanel.Controls.Add(this.ViewNoticeButton);
            this.noticeListPanel.Controls.Add(this.label1);
            this.noticeListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticeListPanel.Location = new System.Drawing.Point(0, 0);
            this.noticeListPanel.MinimumSize = new System.Drawing.Size(450, 300);
            this.noticeListPanel.Name = "noticeListPanel";
            this.noticeListPanel.Size = new System.Drawing.Size(835, 701);
            this.noticeListPanel.TabIndex = 1;
            // 
            // noticesListView
            // 
            this.noticesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noticesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.date,
            this.status,
            this.sender,
            this.message});
            this.noticesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticesListView.FullRowSelect = true;
            this.noticesListView.Location = new System.Drawing.Point(27, 82);
            this.noticesListView.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.noticesListView.MinimumSize = new System.Drawing.Size(400, 300);
            this.noticesListView.Name = "noticesListView";
            this.noticesListView.Size = new System.Drawing.Size(796, 607);
            this.noticesListView.TabIndex = 0;
            this.noticesListView.UseCompatibleStateImageBehavior = false;
            this.noticesListView.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 160;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // sender
            // 
            this.sender.Text = "Sender";
            this.sender.Width = 220;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 500;
            // 
            // ViewNoticeButton
            // 
            this.ViewNoticeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewNoticeButton.AutoSize = true;
            this.ViewNoticeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewNoticeButton.Location = new System.Drawing.Point(648, 14);
            this.ViewNoticeButton.Name = "ViewNoticeButton";
            this.ViewNoticeButton.Size = new System.Drawing.Size(175, 48);
            this.ViewNoticeButton.TabIndex = 1;
            this.ViewNoticeButton.Text = "View Notice";
            this.ViewNoticeButton.UseVisualStyleBackColor = true;
            this.ViewNoticeButton.Click += new System.EventHandler(this.ViewNoticeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notices";
            // 
            // noticeDetailPanel
            // 
            this.noticeDetailPanel.Controls.Add(this.dateTextBox);
            this.noticeDetailPanel.Controls.Add(this.label4);
            this.noticeDetailPanel.Controls.Add(this.typeTextBox);
            this.noticeDetailPanel.Controls.Add(this.label3);
            this.noticeDetailPanel.Controls.Add(this.messageTextBox);
            this.noticeDetailPanel.Controls.Add(this.fromTextBox);
            this.noticeDetailPanel.Controls.Add(this.label2);
            this.noticeDetailPanel.Controls.Add(this.backButton);
            this.noticeDetailPanel.Controls.Add(this.noticeTitleLabel);
            this.noticeDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticeDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.noticeDetailPanel.Name = "noticeDetailPanel";
            this.noticeDetailPanel.Size = new System.Drawing.Size(835, 701);
            this.noticeDetailPanel.TabIndex = 3;
            this.noticeDetailPanel.Visible = false;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(115, 147);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(708, 34);
            this.dateTextBox.TabIndex = 12;
            this.dateTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date: ";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(115, 82);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(708, 34);
            this.typeTextBox.TabIndex = 10;
            this.typeTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(32, 278);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(791, 411);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.TabStop = false;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(115, 212);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(708, 34);
            this.fromTextBox.TabIndex = 7;
            this.fromTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "From: ";
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
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // noticeTitleLabel
            // 
            this.noticeTitleLabel.AutoSize = true;
            this.noticeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTitleLabel.Location = new System.Drawing.Point(100, 18);
            this.noticeTitleLabel.Name = "noticeTitleLabel";
            this.noticeTitleLabel.Size = new System.Drawing.Size(255, 44);
            this.noticeTitleLabel.TabIndex = 0;
            this.noticeTitleLabel.Text = "Notice Details";
            // 
            // ReceiveNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.noticeDetailPanel);
            this.Controls.Add(this.noticeListPanel);
            this.Name = "ReceiveNoticeForm";
            this.Size = new System.Drawing.Size(835, 701);
            this.Load += new System.EventHandler(this.ReceiveNoticeForm_Load);
            this.noticeListPanel.ResumeLayout(false);
            this.noticeListPanel.PerformLayout();
            this.noticeDetailPanel.ResumeLayout(false);
            this.noticeDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel noticeListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewNoticeButton;
        private System.Windows.Forms.Panel noticeDetailPanel;
        private System.Windows.Forms.Label noticeTitleLabel;
        private System.Windows.Forms.ListView noticesListView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader sender;
        private System.Windows.Forms.ColumnHeader message;
    }
}