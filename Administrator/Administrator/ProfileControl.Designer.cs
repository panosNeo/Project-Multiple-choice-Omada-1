namespace Administrator
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.profileLogoutButton = new System.Windows.Forms.Button();
            this.dataGroupbox = new System.Windows.Forms.GroupBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotesflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileSettingsButton = new System.Windows.Forms.Button();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.welcomeLabel.Location = new System.Drawing.Point(89, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(182, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome Admin";
            // 
            // profileLogoutButton
            // 
            this.profileLogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.profileLogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.profileLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileLogoutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.profileLogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.profileLogoutButton.Location = new System.Drawing.Point(642, 55);
            this.profileLogoutButton.Name = "profileLogoutButton";
            this.profileLogoutButton.Size = new System.Drawing.Size(72, 30);
            this.profileLogoutButton.TabIndex = 2;
            this.profileLogoutButton.Text = "Logout";
            this.profileLogoutButton.UseVisualStyleBackColor = false;
            this.profileLogoutButton.Click += new System.EventHandler(this.profileLogoutButton_Click);
            // 
            // dataGroupbox
            // 
            this.dataGroupbox.Controls.Add(this.UserIDBox);
            this.dataGroupbox.Controls.Add(this.label6);
            this.dataGroupbox.Controls.Add(this.ShowPassword);
            this.dataGroupbox.Controls.Add(this.PasswordBox);
            this.dataGroupbox.Controls.Add(this.UsernameBox);
            this.dataGroupbox.Controls.Add(this.EmailBox);
            this.dataGroupbox.Controls.Add(this.LastNameBox);
            this.dataGroupbox.Controls.Add(this.NameBox);
            this.dataGroupbox.Controls.Add(this.label5);
            this.dataGroupbox.Controls.Add(this.label4);
            this.dataGroupbox.Controls.Add(this.label3);
            this.dataGroupbox.Controls.Add(this.label2);
            this.dataGroupbox.Controls.Add(this.label1);
            this.dataGroupbox.Enabled = false;
            this.dataGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dataGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.dataGroupbox.Location = new System.Drawing.Point(50, 83);
            this.dataGroupbox.Name = "dataGroupbox";
            this.dataGroupbox.Size = new System.Drawing.Size(372, 209);
            this.dataGroupbox.TabIndex = 3;
            this.dataGroupbox.TabStop = false;
            this.dataGroupbox.Text = "Account Data";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(305, 172);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(60, 20);
            this.ShowPassword.TabIndex = 10;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordBox.Location = new System.Drawing.Point(113, 167);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(186, 26);
            this.PasswordBox.TabIndex = 9;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameBox.Location = new System.Drawing.Point(113, 138);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(186, 26);
            this.UsernameBox.TabIndex = 8;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailBox.Location = new System.Drawing.Point(113, 109);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(186, 26);
            this.EmailBox.TabIndex = 7;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameBox.Location = new System.Drawing.Point(113, 80);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(186, 26);
            this.LastNameBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameBox.Location = new System.Drawing.Point(113, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(186, 26);
            this.NameBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotesflowLayoutPanel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.groupBox1.Location = new System.Drawing.Point(50, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // NotesflowLayoutPanel
            // 
            this.NotesflowLayoutPanel.AutoScroll = true;
            this.NotesflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NotesflowLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.NotesflowLayoutPanel.Name = "NotesflowLayoutPanel";
            this.NotesflowLayoutPanel.Size = new System.Drawing.Size(532, 78);
            this.NotesflowLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administrator.Properties.Resources.adminProfile;
            this.pictureBox1.Location = new System.Drawing.Point(19, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // profileSettingsButton
            // 
            this.profileSettingsButton.FlatAppearance.BorderSize = 0;
            this.profileSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.profileSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileSettingsButton.Image = global::Administrator.Properties.Resources.settings;
            this.profileSettingsButton.Location = new System.Drawing.Point(654, 13);
            this.profileSettingsButton.Name = "profileSettingsButton";
            this.profileSettingsButton.Size = new System.Drawing.Size(60, 36);
            this.profileSettingsButton.TabIndex = 1;
            this.profileSettingsButton.UseVisualStyleBackColor = false;
            this.profileSettingsButton.Click += new System.EventHandler(this.profileSettingsButton_Click);
            // 
            // UserIDBox
            // 
            this.UserIDBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UserIDBox.Location = new System.Drawing.Point(113, 22);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(186, 26);
            this.UserIDBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "User ID :";
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGroupbox);
            this.Controls.Add(this.profileLogoutButton);
            this.Controls.Add(this.profileSettingsButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.Load += new System.EventHandler(this.ProfileControl_Load);
            this.dataGroupbox.ResumeLayout(false);
            this.dataGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button profileSettingsButton;
        private System.Windows.Forms.Button profileLogoutButton;
        private System.Windows.Forms.GroupBox dataGroupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel NotesflowLayoutPanel;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Label label6;
    }
}
