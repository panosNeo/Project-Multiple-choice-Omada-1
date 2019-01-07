namespace Administrator
{
    partial class ReportControl
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
            this.QuestionGroupbox = new System.Windows.Forms.GroupBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.AnswerIDList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qUserIDBox = new System.Windows.Forms.TextBox();
            this.qQuestionBox = new System.Windows.Forms.TextBox();
            this.qQuestionIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.showReportsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteAllCheckbox = new System.Windows.Forms.CheckBox();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportIcon = new System.Windows.Forms.PictureBox();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.QuestionGroupbox.SuspendLayout();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionGroupbox
            // 
            this.QuestionGroupbox.Controls.Add(this.AnswerBox);
            this.QuestionGroupbox.Controls.Add(this.AnswerIDList);
            this.QuestionGroupbox.Controls.Add(this.qUserIDBox);
            this.QuestionGroupbox.Controls.Add(this.qQuestionBox);
            this.QuestionGroupbox.Controls.Add(this.label5);
            this.QuestionGroupbox.Controls.Add(this.qQuestionIDBox);
            this.QuestionGroupbox.Controls.Add(this.label6);
            this.QuestionGroupbox.Controls.Add(this.label7);
            this.QuestionGroupbox.Controls.Add(this.label8);
            this.QuestionGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuestionGroupbox.Location = new System.Drawing.Point(30, 252);
            this.QuestionGroupbox.Name = "QuestionGroupbox";
            this.QuestionGroupbox.Size = new System.Drawing.Size(676, 156);
            this.QuestionGroupbox.TabIndex = 2;
            this.QuestionGroupbox.TabStop = false;
            this.QuestionGroupbox.Text = "Question";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AnswerBox.Location = new System.Drawing.Point(334, 80);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerBox.Size = new System.Drawing.Size(267, 70);
            this.AnswerBox.TabIndex = 10;
            // 
            // AnswerIDList
            // 
            this.AnswerIDList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AnswerIDList.FormattingEnabled = true;
            this.AnswerIDList.ItemHeight = 17;
            this.AnswerIDList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AnswerIDList.Location = new System.Drawing.Point(439, 56);
            this.AnswerIDList.Name = "AnswerIDList";
            this.AnswerIDList.Size = new System.Drawing.Size(83, 21);
            this.AnswerIDList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Answer ID :";
            // 
            // qUserIDBox
            // 
            this.qUserIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qUserIDBox.Location = new System.Drawing.Point(105, 20);
            this.qUserIDBox.Name = "qUserIDBox";
            this.qUserIDBox.ReadOnly = true;
            this.qUserIDBox.Size = new System.Drawing.Size(125, 23);
            this.qUserIDBox.TabIndex = 7;
            // 
            // qQuestionBox
            // 
            this.qQuestionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuestionBox.Location = new System.Drawing.Point(17, 80);
            this.qQuestionBox.Multiline = true;
            this.qQuestionBox.Name = "qQuestionBox";
            this.qQuestionBox.ReadOnly = true;
            this.qQuestionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qQuestionBox.Size = new System.Drawing.Size(267, 70);
            this.qQuestionBox.TabIndex = 3;
            // 
            // qQuestionIDBox
            // 
            this.qQuestionIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuestionIDBox.Location = new System.Drawing.Point(439, 24);
            this.qQuestionIDBox.Name = "qQuestionIDBox";
            this.qQuestionIDBox.ReadOnly = true;
            this.qQuestionIDBox.Size = new System.Drawing.Size(125, 23);
            this.qQuestionIDBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Question :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Question ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "User ID :";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.warningLabel.Location = new System.Drawing.Point(234, 12);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(56, 16);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "*Report";
            this.warningLabel.Visible = false;
            // 
            // showReportsPanel
            // 
            this.showReportsPanel.AutoScroll = true;
            this.showReportsPanel.Location = new System.Drawing.Point(53, 71);
            this.showReportsPanel.Name = "showReportsPanel";
            this.showReportsPanel.Size = new System.Drawing.Size(630, 165);
            this.showReportsPanel.TabIndex = 6;
            // 
            // deleteAllCheckbox
            // 
            this.deleteAllCheckbox.AutoSize = true;
            this.deleteAllCheckbox.Location = new System.Drawing.Point(578, 14);
            this.deleteAllCheckbox.Name = "deleteAllCheckbox";
            this.deleteAllCheckbox.Size = new System.Drawing.Size(15, 14);
            this.deleteAllCheckbox.TabIndex = 7;
            this.deleteAllCheckbox.UseVisualStyleBackColor = true;
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPanel.Controls.Add(this.deleteReportButton);
            this.reportPanel.Controls.Add(this.reportIcon);
            this.reportPanel.Controls.Add(this.deleteAllCheckbox);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Location = new System.Drawing.Point(30, 31);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(676, 43);
            this.reportPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // reportIcon
            // 
            this.reportIcon.Location = new System.Drawing.Point(116, 9);
            this.reportIcon.Name = "reportIcon";
            this.reportIcon.Size = new System.Drawing.Size(26, 24);
            this.reportIcon.TabIndex = 1;
            this.reportIcon.TabStop = false;
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.deleteReportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.deleteReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.deleteReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReportButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteReportButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteReportButton.Location = new System.Drawing.Point(599, 3);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(72, 35);
            this.deleteReportButton.TabIndex = 9;
            this.deleteReportButton.Text = "Delete";
            this.deleteReportButton.UseVisualStyleBackColor = false;
            this.deleteReportButton.MouseEnter += new System.EventHandler(this.deleteReportButton_MouseEnter);
            this.deleteReportButton.MouseLeave += new System.EventHandler(this.deleteReportButton_MouseLeave);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.QuestionGroupbox);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.showReportsPanel);
            this.Controls.Add(this.warningLabel);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.QuestionGroupbox.ResumeLayout(false);
            this.QuestionGroupbox.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox QuestionGroupbox;
        private System.Windows.Forms.TextBox qQuestionBox;
        private System.Windows.Forms.TextBox qQuestionIDBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qUserIDBox;
        private System.Windows.Forms.ListBox AnswerIDList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.FlowLayoutPanel showReportsPanel;
        private System.Windows.Forms.CheckBox deleteAllCheckbox;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox reportIcon;
        private System.Windows.Forms.Button deleteReportButton;
    }
}
