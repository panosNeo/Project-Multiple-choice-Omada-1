namespace QuizMaker
{
    partial class ProfileControl
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
            this.components = new System.ComponentModel.Container();
            this.personalPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.personalBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new QuizMaker.CustomTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new QuizMaker.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameText = new QuizMaker.CustomTextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.LastNameText = new QuizMaker.CustomTextBox();
            this.quizPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.quizBtn = new System.Windows.Forms.Button();
            this.personalAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.quizAnimtionTimer = new System.Windows.Forms.Timer(this.components);
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.personalPanel.SuspendLayout();
            this.quizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalPanel
            // 
            this.personalPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.personalPanel.Controls.Add(this.personalBtn);
            this.personalPanel.Controls.Add(this.usernameLabel);
            this.personalPanel.Controls.Add(this.usernameText);
            this.personalPanel.Controls.Add(this.emailLabel);
            this.personalPanel.Controls.Add(this.emailText);
            this.personalPanel.Controls.Add(this.label1);
            this.personalPanel.Controls.Add(this.firstNameText);
            this.personalPanel.Controls.Add(this.lastNameLabel);
            this.personalPanel.Controls.Add(this.LastNameText);
            this.personalPanel.Controls.Add(this.UpdateBtn);
            this.personalPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.personalPanel.Location = new System.Drawing.Point(150, 119);
            this.personalPanel.Name = "personalPanel";
            this.personalPanel.Size = new System.Drawing.Size(618, 52);
            this.personalPanel.TabIndex = 0;
            // 
            // personalBtn
            // 
            this.personalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.personalBtn.ForeColor = System.Drawing.Color.White;
            this.personalBtn.Location = new System.Drawing.Point(3, 3);
            this.personalBtn.Name = "personalBtn";
            this.personalBtn.Size = new System.Drawing.Size(615, 45);
            this.personalBtn.TabIndex = 8;
            this.personalBtn.Tag = "+";
            this.personalBtn.Text = "+ Personal Data";
            this.personalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.UseCompatibleTextRendering = true;
            this.personalBtn.UseVisualStyleBackColor = true;
            this.personalBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(1572, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(166, 38);
            this.UpdateBtn.TabIndex = 17;
            this.UpdateBtn.Tag = "-5";
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(624, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 18);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameText.ForeColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(624, 21);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(231, 23);
            this.usernameText.TabIndex = 10;
            this.usernameText.Text = "petros";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(861, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 18);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "E-mail";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailText.ForeColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(861, 21);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(231, 23);
            this.emailText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1098, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameText.ForeColor = System.Drawing.Color.White;
            this.firstNameText.Location = new System.Drawing.Point(1098, 21);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(231, 23);
            this.firstNameText.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(1335, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lastNameLabel.TabIndex = 15;
            this.lastNameLabel.Text = "Last Name";
            // 
            // LastNameText
            // 
            this.LastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameText.ForeColor = System.Drawing.Color.White;
            this.LastNameText.Location = new System.Drawing.Point(1335, 21);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(231, 23);
            this.LastNameText.TabIndex = 16;
            // 
            // quizPanel
            // 
            this.quizPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quizPanel.AutoScroll = true;
            this.quizPanel.Controls.Add(this.quizBtn);
            this.quizPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.quizPanel.Location = new System.Drawing.Point(150, 186);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.Size = new System.Drawing.Size(628, 53);
            this.quizPanel.TabIndex = 1;
            // 
            // quizBtn
            // 
            this.quizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizBtn.ForeColor = System.Drawing.Color.White;
            this.quizBtn.Location = new System.Drawing.Point(3, 3);
            this.quizBtn.Name = "quizBtn";
            this.quizBtn.Size = new System.Drawing.Size(615, 43);
            this.quizBtn.TabIndex = 9;
            this.quizBtn.Tag = "+";
            this.quizBtn.Text = "+ My quizes";
            this.quizBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quizBtn.UseCompatibleTextRendering = true;
            this.quizBtn.UseVisualStyleBackColor = true;
            this.quizBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // personalAnimationTimer
            // 
            this.personalAnimationTimer.Interval = 1;
            this.personalAnimationTimer.Tick += new System.EventHandler(this.panelTimer_Tick);
            // 
            // quizAnimtionTimer
            // 
            this.quizAnimtionTimer.Interval = 1;
            this.quizAnimtionTimer.Tick += new System.EventHandler(this.quizAnimtionTimer_Tick);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.feedbackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feedbackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.feedbackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbackBtn.Location = new System.Drawing.Point(150, 75);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(118, 38);
            this.feedbackBtn.TabIndex = 8;
            this.feedbackBtn.Text = "Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.feedbackBtn);
            this.Controls.Add(this.personalPanel);
            this.Controls.Add(this.quizPanel);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(917, 547);
            this.personalPanel.ResumeLayout(false);
            this.personalPanel.PerformLayout();
            this.quizPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel personalPanel;
        private System.Windows.Forms.FlowLayoutPanel quizPanel;
        private System.Windows.Forms.Button personalBtn;
        private System.Windows.Forms.Label usernameLabel;
        private CustomTextBox usernameText;
        private System.Windows.Forms.Label emailLabel;
        private CustomTextBox emailText;
        private System.Windows.Forms.Label label1;
        private CustomTextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private CustomTextBox LastNameText;
        private System.Windows.Forms.Button quizBtn;
        private System.Windows.Forms.Timer personalAnimationTimer;
        private System.Windows.Forms.Timer quizAnimtionTimer;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button feedbackBtn;
    }
}
