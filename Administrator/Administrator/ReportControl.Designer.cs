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
            this.ReportGroupbox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReportIDListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportBox = new System.Windows.Forms.TextBox();
            this.QuestionIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.reportPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReportGroupbox.SuspendLayout();
            this.QuestionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportGroupbox
            // 
            this.ReportGroupbox.Controls.Add(this.DeleteButton);
            this.ReportGroupbox.Controls.Add(this.ReportIDListbox);
            this.ReportGroupbox.Controls.Add(this.label2);
            this.ReportGroupbox.Controls.Add(this.ReportBox);
            this.ReportGroupbox.Controls.Add(this.QuestionIDBox);
            this.ReportGroupbox.Controls.Add(this.label4);
            this.ReportGroupbox.Controls.Add(this.UserIDListbox);
            this.ReportGroupbox.Controls.Add(this.label3);
            this.ReportGroupbox.Controls.Add(this.label1);
            this.ReportGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReportGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ReportGroupbox.Location = new System.Drawing.Point(3, 18);
            this.ReportGroupbox.Name = "ReportGroupbox";
            this.ReportGroupbox.Size = new System.Drawing.Size(298, 294);
            this.ReportGroupbox.TabIndex = 1;
            this.ReportGroupbox.TabStop = false;
            this.ReportGroupbox.Text = "Reports";
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(209, 242);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ReportIDListbox
            // 
            this.ReportIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReportIDListbox.FormattingEnabled = true;
            this.ReportIDListbox.ItemHeight = 17;
            this.ReportIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ReportIDListbox.Location = new System.Drawing.Point(117, 64);
            this.ReportIDListbox.Name = "ReportIDListbox";
            this.ReportIDListbox.Size = new System.Drawing.Size(83, 21);
            this.ReportIDListbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report ID :";
            // 
            // ReportBox
            // 
            this.ReportBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReportBox.Location = new System.Drawing.Point(17, 136);
            this.ReportBox.Multiline = true;
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.ReadOnly = true;
            this.ReportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportBox.Size = new System.Drawing.Size(267, 86);
            this.ReportBox.TabIndex = 3;
            // 
            // QuestionIDBox
            // 
            this.QuestionIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionIDBox.Location = new System.Drawing.Point(117, 91);
            this.QuestionIDBox.Name = "QuestionIDBox";
            this.QuestionIDBox.ReadOnly = true;
            this.QuestionIDBox.Size = new System.Drawing.Size(125, 23);
            this.QuestionIDBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Report :";
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
            this.UserIDListbox.Location = new System.Drawing.Point(117, 37);
            this.UserIDListbox.Name = "UserIDListbox";
            this.UserIDListbox.Size = new System.Drawing.Size(83, 21);
            this.UserIDListbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // QuestionGroupbox
            // 
            this.QuestionGroupbox.Controls.Add(this.AnswerBox);
            this.QuestionGroupbox.Controls.Add(this.AnswerIDList);
            this.QuestionGroupbox.Controls.Add(this.label5);
            this.QuestionGroupbox.Controls.Add(this.qUserIDBox);
            this.QuestionGroupbox.Controls.Add(this.qQuestionBox);
            this.QuestionGroupbox.Controls.Add(this.qQuestionIDBox);
            this.QuestionGroupbox.Controls.Add(this.label6);
            this.QuestionGroupbox.Controls.Add(this.label7);
            this.QuestionGroupbox.Controls.Add(this.label8);
            this.QuestionGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuestionGroupbox.Location = new System.Drawing.Point(388, 18);
            this.QuestionGroupbox.Name = "QuestionGroupbox";
            this.QuestionGroupbox.Size = new System.Drawing.Size(298, 336);
            this.QuestionGroupbox.TabIndex = 2;
            this.QuestionGroupbox.TabStop = false;
            this.QuestionGroupbox.Text = "Question";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AnswerBox.Location = new System.Drawing.Point(17, 233);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerBox.Size = new System.Drawing.Size(267, 86);
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
            this.AnswerIDList.Location = new System.Drawing.Point(117, 206);
            this.AnswerIDList.Name = "AnswerIDList";
            this.AnswerIDList.Size = new System.Drawing.Size(83, 21);
            this.AnswerIDList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Answer ID :";
            // 
            // qUserIDBox
            // 
            this.qUserIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qUserIDBox.Location = new System.Drawing.Point(117, 34);
            this.qUserIDBox.Name = "qUserIDBox";
            this.qUserIDBox.ReadOnly = true;
            this.qUserIDBox.Size = new System.Drawing.Size(125, 23);
            this.qUserIDBox.TabIndex = 7;
            // 
            // qQuestionBox
            // 
            this.qQuestionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuestionBox.Location = new System.Drawing.Point(17, 115);
            this.qQuestionBox.Multiline = true;
            this.qQuestionBox.Name = "qQuestionBox";
            this.qQuestionBox.ReadOnly = true;
            this.qQuestionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qQuestionBox.Size = new System.Drawing.Size(267, 86);
            this.qQuestionBox.TabIndex = 3;
            // 
            // qQuestionIDBox
            // 
            this.qQuestionIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuestionIDBox.Location = new System.Drawing.Point(117, 62);
            this.qQuestionIDBox.Name = "qQuestionIDBox";
            this.qQuestionIDBox.ReadOnly = true;
            this.qQuestionIDBox.Size = new System.Drawing.Size(125, 23);
            this.qQuestionIDBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Question :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Question ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 37);
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
            this.warningLabel.Location = new System.Drawing.Point(33, 391);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(56, 16);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "*Report";
            this.warningLabel.Visible = false;
            // 
            // reportPanel
            // 
            this.reportPanel.AutoScroll = true;
            this.reportPanel.Location = new System.Drawing.Point(388, 385);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(298, 22);
            this.reportPanel.TabIndex = 6;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.QuestionGroupbox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.ReportGroupbox);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.ReportGroupbox.ResumeLayout(false);
            this.ReportGroupbox.PerformLayout();
            this.QuestionGroupbox.ResumeLayout(false);
            this.QuestionGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ReportGroupbox;
        private System.Windows.Forms.TextBox ReportBox;
        private System.Windows.Forms.TextBox QuestionIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UserIDListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ReportIDListbox;
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
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.FlowLayoutPanel reportPanel;
    }
}
