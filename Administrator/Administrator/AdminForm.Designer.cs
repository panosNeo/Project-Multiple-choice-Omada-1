namespace Administrator
{
    partial class AdminForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Feedback = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(936, 47);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator App";
            // 
            // Close
            // 
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Close.Image = global::Administrator.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(892, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(42, 45);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.Feedback);
            this.MenuPanel.Controls.Add(this.Report);
            this.MenuPanel.Controls.Add(this.Question);
            this.MenuPanel.Controls.Add(this.User);
            this.MenuPanel.Controls.Add(this.Subject);
            this.MenuPanel.Controls.Add(this.Profile);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 47);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 423);
            this.MenuPanel.TabIndex = 1;
            // 
            // Feedback
            // 
            this.Feedback.FlatAppearance.BorderSize = 0;
            this.Feedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Feedback.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Feedback.Image = global::Administrator.Properties.Resources.feedback1;
            this.Feedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Feedback.Location = new System.Drawing.Point(-1, 223);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(200, 38);
            this.Feedback.TabIndex = 5;
            this.Feedback.Text = "Feedbacks";
            this.Feedback.UseVisualStyleBackColor = false;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            this.Feedback.MouseEnter += new System.EventHandler(this.Feedback_MouseEnter);
            this.Feedback.MouseLeave += new System.EventHandler(this.Feedback_MouseLeave);
            // 
            // Report
            // 
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Report.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Report.Image = global::Administrator.Properties.Resources.report;
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(-1, 179);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(200, 38);
            this.Report.TabIndex = 4;
            this.Report.Text = "Reports";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            this.Report.MouseEnter += new System.EventHandler(this.Report_MouseEnter);
            this.Report.MouseLeave += new System.EventHandler(this.Report_MouseLeave);
            // 
            // Question
            // 
            this.Question.FlatAppearance.BorderSize = 0;
            this.Question.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Question.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Question.Image = global::Administrator.Properties.Resources.test_quiz;
            this.Question.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Question.Location = new System.Drawing.Point(-1, 135);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(200, 38);
            this.Question.TabIndex = 3;
            this.Question.Text = "Question Settings";
            this.Question.UseVisualStyleBackColor = false;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            this.Question.MouseEnter += new System.EventHandler(this.Question_MouseEnter);
            this.Question.MouseLeave += new System.EventHandler(this.Question_MouseLeave);
            // 
            // User
            // 
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.User.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.User.Image = global::Administrator.Properties.Resources.user;
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(-1, 91);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 38);
            this.User.TabIndex = 2;
            this.User.Text = "User Settings";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            this.User.MouseEnter += new System.EventHandler(this.User_MouseEnter);
            this.User.MouseLeave += new System.EventHandler(this.User_MouseLeave);
            // 
            // Subject
            // 
            this.Subject.FlatAppearance.BorderSize = 0;
            this.Subject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Subject.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Subject.Image = global::Administrator.Properties.Resources.subject;
            this.Subject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.Location = new System.Drawing.Point(-1, 47);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(200, 38);
            this.Subject.TabIndex = 1;
            this.Subject.Text = "Subject Settings";
            this.Subject.UseVisualStyleBackColor = false;
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            this.Subject.MouseEnter += new System.EventHandler(this.Subject_MouseEnter);
            this.Subject.MouseLeave += new System.EventHandler(this.Subject_MouseLeave);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Profile.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Profile.Image = global::Administrator.Properties.Resources.Account1;
            this.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.Location = new System.Drawing.Point(-1, 334);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(200, 38);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "My Profile";
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            this.Profile.MouseEnter += new System.EventHandler(this.Profile_MouseEnter);
            this.Profile.MouseLeave += new System.EventHandler(this.Profile_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 47);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(736, 423);
            this.MainPanel.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 470);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Subject;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button Feedback;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Question;
    }
}

