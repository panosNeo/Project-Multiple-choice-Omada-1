namespace Administrator
{
    partial class FeedbackControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FeedbackGroupbox = new System.Windows.Forms.GroupBox();
            this.RateCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FeedbackIDListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.FeedbackGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeedbackGroupbox
            // 
            this.FeedbackGroupbox.Controls.Add(this.RateCheckbox);
            this.FeedbackGroupbox.Controls.Add(this.UpdateButton);
            this.FeedbackGroupbox.Controls.Add(this.DeleteButton);
            this.FeedbackGroupbox.Controls.Add(this.FeedbackIDListbox);
            this.FeedbackGroupbox.Controls.Add(this.label2);
            this.FeedbackGroupbox.Controls.Add(this.ReportBox);
            this.FeedbackGroupbox.Controls.Add(this.label4);
            this.FeedbackGroupbox.Controls.Add(this.UserIDListbox);
            this.FeedbackGroupbox.Controls.Add(this.label1);
            this.FeedbackGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FeedbackGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.FeedbackGroupbox.Location = new System.Drawing.Point(106, 36);
            this.FeedbackGroupbox.Name = "FeedbackGroupbox";
            this.FeedbackGroupbox.Size = new System.Drawing.Size(515, 294);
            this.FeedbackGroupbox.TabIndex = 2;
            this.FeedbackGroupbox.TabStop = false;
            this.FeedbackGroupbox.Text = "Feedbacks";
            // 
            // RateCheckbox
            // 
            this.RateCheckbox.AutoSize = true;
            this.RateCheckbox.Location = new System.Drawing.Point(257, 130);
            this.RateCheckbox.Name = "RateCheckbox";
            this.RateCheckbox.Size = new System.Drawing.Size(56, 20);
            this.RateCheckbox.TabIndex = 17;
            this.RateCheckbox.Text = "Rate";
            this.RateCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(417, 59);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(417, 22);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // FeedbackIDListbox
            // 
            this.FeedbackIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FeedbackIDListbox.FormattingEnabled = true;
            this.FeedbackIDListbox.ItemHeight = 17;
            this.FeedbackIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.FeedbackIDListbox.Location = new System.Drawing.Point(131, 59);
            this.FeedbackIDListbox.Name = "FeedbackIDListbox";
            this.FeedbackIDListbox.Size = new System.Drawing.Size(83, 21);
            this.FeedbackIDListbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Feedback ID :";
            // 
            // ReportBox
            // 
            this.ReportBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReportBox.Location = new System.Drawing.Point(17, 150);
            this.ReportBox.Multiline = true;
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.ReadOnly = true;
            this.ReportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportBox.Size = new System.Drawing.Size(475, 124);
            this.ReportBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Feedback :";
            // 
            // UserIDListbox
            // 
            this.UserIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UserIDListbox.FormattingEnabled = true;
            this.UserIDListbox.ItemHeight = 17;
            this.UserIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.UserIDListbox.Location = new System.Drawing.Point(131, 32);
            this.UserIDListbox.Name = "UserIDListbox";
            this.UserIDListbox.Size = new System.Drawing.Size(83, 21);
            this.UserIDListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.warningLabel.Location = new System.Drawing.Point(37, 394);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(56, 16);
            this.warningLabel.TabIndex = 6;
            this.warningLabel.Text = "*Report";
            this.warningLabel.Visible = false;
            // 
            // FeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.FeedbackGroupbox);
            this.Name = "FeedbackControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.FeedbackGroupbox.ResumeLayout(false);
            this.FeedbackGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FeedbackGroupbox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox FeedbackIDListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReportBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UserIDListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RateCheckbox;
        private System.Windows.Forms.Label warningLabel;
    }
}
