namespace Administrator
{
    partial class QuestionControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchIDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QuestionGroupbox = new System.Windows.Forms.GroupBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AnswerIDList = new System.Windows.Forms.ListBox();
            this.CorrectCheckbox = new System.Windows.Forms.CheckBox();
            this.QuestionSettingsButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuestionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Question ID :";
            // 
            // SearchIDBox
            // 
            this.SearchIDBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SearchIDBox.Location = new System.Drawing.Point(292, 50);
            this.SearchIDBox.Name = "SearchIDBox";
            this.SearchIDBox.Size = new System.Drawing.Size(152, 27);
            this.SearchIDBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Administrator.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(450, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuestionGroupbox
            // 
            this.QuestionGroupbox.Controls.Add(this.UpdateButton);
            this.QuestionGroupbox.Controls.Add(this.DeleteButton);
            this.QuestionGroupbox.Controls.Add(this.AddButton);
            this.QuestionGroupbox.Controls.Add(this.QuestionSettingsButton);
            this.QuestionGroupbox.Controls.Add(this.CorrectCheckbox);
            this.QuestionGroupbox.Controls.Add(this.AnswerIDList);
            this.QuestionGroupbox.Controls.Add(this.label7);
            this.QuestionGroupbox.Controls.Add(this.AnswerBox);
            this.QuestionGroupbox.Controls.Add(this.DateBox);
            this.QuestionGroupbox.Controls.Add(this.label6);
            this.QuestionGroupbox.Controls.Add(this.RatingBox);
            this.QuestionGroupbox.Controls.Add(this.label5);
            this.QuestionGroupbox.Controls.Add(this.QuestionBox);
            this.QuestionGroupbox.Controls.Add(this.label4);
            this.QuestionGroupbox.Controls.Add(this.SubjectIDBox);
            this.QuestionGroupbox.Controls.Add(this.label3);
            this.QuestionGroupbox.Controls.Add(this.UserIDBox);
            this.QuestionGroupbox.Controls.Add(this.label2);
            this.QuestionGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuestionGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuestionGroupbox.Location = new System.Drawing.Point(38, 122);
            this.QuestionGroupbox.Name = "QuestionGroupbox";
            this.QuestionGroupbox.Size = new System.Drawing.Size(654, 271);
            this.QuestionGroupbox.TabIndex = 4;
            this.QuestionGroupbox.TabStop = false;
            this.QuestionGroupbox.Text = "Question Data";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(289, 31);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(64, 16);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "Warning *";
            this.warningLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserIDBox.Location = new System.Drawing.Point(99, 39);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.ReadOnly = true;
            this.UserIDBox.Size = new System.Drawing.Size(113, 23);
            this.UserIDBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject ID :";
            // 
            // SubjectIDBox
            // 
            this.SubjectIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SubjectIDBox.Location = new System.Drawing.Point(99, 68);
            this.SubjectIDBox.Name = "SubjectIDBox";
            this.SubjectIDBox.ReadOnly = true;
            this.SubjectIDBox.Size = new System.Drawing.Size(113, 23);
            this.SubjectIDBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Question :";
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.QuestionBox.Location = new System.Drawing.Point(23, 169);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionBox.Size = new System.Drawing.Size(309, 90);
            this.QuestionBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rating :";
            // 
            // RatingBox
            // 
            this.RatingBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RatingBox.Location = new System.Drawing.Point(356, 39);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.ReadOnly = true;
            this.RatingBox.Size = new System.Drawing.Size(113, 23);
            this.RatingBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Creation Date :";
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DateBox.Location = new System.Drawing.Point(356, 68);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(113, 23);
            this.DateBox.TabIndex = 6;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AnswerBox.Location = new System.Drawing.Point(338, 169);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerBox.Size = new System.Drawing.Size(309, 90);
            this.AnswerBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Answer :";
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
            this.AnswerIDList.Location = new System.Drawing.Point(404, 142);
            this.AnswerIDList.Name = "AnswerIDList";
            this.AnswerIDList.Size = new System.Drawing.Size(65, 21);
            this.AnswerIDList.TabIndex = 7;
            // 
            // CorrectCheckbox
            // 
            this.CorrectCheckbox.AutoSize = true;
            this.CorrectCheckbox.Enabled = false;
            this.CorrectCheckbox.Location = new System.Drawing.Point(493, 142);
            this.CorrectCheckbox.Name = "CorrectCheckbox";
            this.CorrectCheckbox.Size = new System.Drawing.Size(75, 20);
            this.CorrectCheckbox.TabIndex = 11;
            this.CorrectCheckbox.Text = "Correct";
            this.CorrectCheckbox.UseVisualStyleBackColor = true;
            // 
            // QuestionSettingsButton
            // 
            this.QuestionSettingsButton.FlatAppearance.BorderSize = 0;
            this.QuestionSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuestionSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionSettingsButton.Image = global::Administrator.Properties.Resources.settings;
            this.QuestionSettingsButton.Location = new System.Drawing.Point(612, 22);
            this.QuestionSettingsButton.Name = "QuestionSettingsButton";
            this.QuestionSettingsButton.Size = new System.Drawing.Size(35, 35);
            this.QuestionSettingsButton.TabIndex = 12;
            this.QuestionSettingsButton.UseVisualStyleBackColor = false;
            this.QuestionSettingsButton.Click += new System.EventHandler(this.QuestionSettingsButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(515, 97);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(515, 60);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(515, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 31);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.QuestionGroupbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchIDBox);
            this.Controls.Add(this.label1);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.QuestionGroupbox.ResumeLayout(false);
            this.QuestionGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchIDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox QuestionGroupbox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.TextBox RatingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.ListBox AnswerIDList;
        private System.Windows.Forms.CheckBox CorrectCheckbox;
        private System.Windows.Forms.Button QuestionSettingsButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}
