﻿namespace Administrator
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
            this.SubjectNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerIDCombo = new System.Windows.Forms.ComboBox();
            this.questionIDCombo = new System.Windows.Forms.ComboBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuizNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.showReportsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteAllCheckbox = new System.Windows.Forms.CheckBox();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.questionButton = new System.Windows.Forms.Button();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noReports = new System.Windows.Forms.Label();
            this.noQuestionsLabel = new System.Windows.Forms.Label();
            this.QuestionGroupbox.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionGroupbox
            // 
            this.QuestionGroupbox.Controls.Add(this.noQuestionsLabel);
            this.QuestionGroupbox.Controls.Add(this.SubjectNameBox);
            this.QuestionGroupbox.Controls.Add(this.label2);
            this.QuestionGroupbox.Controls.Add(this.answerIDCombo);
            this.QuestionGroupbox.Controls.Add(this.questionIDCombo);
            this.QuestionGroupbox.Controls.Add(this.AnswerBox);
            this.QuestionGroupbox.Controls.Add(this.UsernameBox);
            this.QuestionGroupbox.Controls.Add(this.QuestionBox);
            this.QuestionGroupbox.Controls.Add(this.label5);
            this.QuestionGroupbox.Controls.Add(this.QuizNameBox);
            this.QuestionGroupbox.Controls.Add(this.label6);
            this.QuestionGroupbox.Controls.Add(this.label7);
            this.QuestionGroupbox.Controls.Add(this.label8);
            this.QuestionGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuestionGroupbox.Location = new System.Drawing.Point(30, 255);
            this.QuestionGroupbox.Name = "QuestionGroupbox";
            this.QuestionGroupbox.Size = new System.Drawing.Size(676, 156);
            this.QuestionGroupbox.TabIndex = 2;
            this.QuestionGroupbox.TabStop = false;
            this.QuestionGroupbox.Text = "Quiz Data";
            // 
            // SubjectNameBox
            // 
            this.SubjectNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectNameBox.Location = new System.Drawing.Point(123, 46);
            this.SubjectNameBox.Name = "SubjectNameBox";
            this.SubjectNameBox.ReadOnly = true;
            this.SubjectNameBox.Size = new System.Drawing.Size(125, 23);
            this.SubjectNameBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject Name :";
            // 
            // answerIDCombo
            // 
            this.answerIDCombo.Location = new System.Drawing.Point(469, 75);
            this.answerIDCombo.Name = "answerIDCombo";
            this.answerIDCombo.Size = new System.Drawing.Size(125, 24);
            this.answerIDCombo.TabIndex = 5;
            this.answerIDCombo.SelectedIndexChanged += new System.EventHandler(this.answerIDCombo_SelectedIndexChanged);
            // 
            // questionIDCombo
            // 
            this.questionIDCombo.Location = new System.Drawing.Point(123, 75);
            this.questionIDCombo.Name = "questionIDCombo";
            this.questionIDCombo.Size = new System.Drawing.Size(125, 24);
            this.questionIDCombo.TabIndex = 2;
            this.questionIDCombo.SelectedIndexChanged += new System.EventHandler(this.questionIDCombo_SelectedIndexChanged);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AnswerBox.Location = new System.Drawing.Point(371, 100);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerBox.Size = new System.Drawing.Size(267, 50);
            this.AnswerBox.TabIndex = 6;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameBox.Location = new System.Drawing.Point(469, 46);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.ReadOnly = true;
            this.UsernameBox.Size = new System.Drawing.Size(125, 23);
            this.UsernameBox.TabIndex = 4;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionBox.Location = new System.Drawing.Point(34, 100);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionBox.Size = new System.Drawing.Size(267, 50);
            this.QuestionBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Answer ID :";
            // 
            // QuizNameBox
            // 
            this.QuizNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuizNameBox.Location = new System.Drawing.Point(123, 17);
            this.QuizNameBox.Name = "QuizNameBox";
            this.QuizNameBox.ReadOnly = true;
            this.QuizNameBox.Size = new System.Drawing.Size(125, 23);
            this.QuizNameBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Question :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quiz Title :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "By user :";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(50, 12);
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
            this.deleteAllCheckbox.CheckedChanged += new System.EventHandler(this.deleteAllCheckbox_CheckedChanged);
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPanel.Controls.Add(this.questionButton);
            this.reportPanel.Controls.Add(this.deleteReportButton);
            this.reportPanel.Controls.Add(this.deleteAllCheckbox);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Location = new System.Drawing.Point(30, 31);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(676, 43);
            this.reportPanel.TabIndex = 8;
            // 
            // questionButton
            // 
            this.questionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.questionButton.FlatAppearance.BorderSize = 0;
            this.questionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.questionButton.Image = global::Administrator.Properties.Resources.question;
            this.questionButton.Location = new System.Drawing.Point(538, 9);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(24, 24);
            this.questionButton.TabIndex = 20;
            this.questionButton.UseVisualStyleBackColor = false;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
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
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            this.deleteReportButton.MouseEnter += new System.EventHandler(this.deleteReportButton_MouseEnter);
            this.deleteReportButton.MouseLeave += new System.EventHandler(this.deleteReportButton_MouseLeave);
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
            // noReports
            // 
            this.noReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noReports.AutoSize = true;
            this.noReports.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.noReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.noReports.Location = new System.Drawing.Point(256, 239);
            this.noReports.Name = "noReports";
            this.noReports.Size = new System.Drawing.Size(196, 23);
            this.noReports.TabIndex = 19;
            this.noReports.Tag = "noReports";
            this.noReports.Text = "There are no Reports";
            this.noReports.Visible = false;
            // 
            // noQuestionsLabel
            // 
            this.noQuestionsLabel.AutoSize = true;
            this.noQuestionsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.noQuestionsLabel.ForeColor = System.Drawing.Color.Red;
            this.noQuestionsLabel.Location = new System.Drawing.Point(303, 20);
            this.noQuestionsLabel.Name = "noQuestionsLabel";
            this.noQuestionsLabel.Size = new System.Drawing.Size(145, 16);
            this.noQuestionsLabel.TabIndex = 12;
            this.noQuestionsLabel.Text = "No existing questions";
            this.noQuestionsLabel.Visible = false;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.noReports);
            this.Controls.Add(this.QuestionGroupbox);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.showReportsPanel);
            this.Controls.Add(this.warningLabel);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            this.QuestionGroupbox.ResumeLayout(false);
            this.QuestionGroupbox.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox QuestionGroupbox;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.TextBox QuizNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.FlowLayoutPanel showReportsPanel;
        private System.Windows.Forms.CheckBox deleteAllCheckbox;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteReportButton;
        private System.Windows.Forms.ComboBox questionIDCombo;
        private System.Windows.Forms.ComboBox answerIDCombo;
        private System.Windows.Forms.Label noReports;
        private System.Windows.Forms.Button questionButton;
        private System.Windows.Forms.TextBox SubjectNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noQuestionsLabel;
    }
}
