namespace QuizMaker
{
    partial class RegisterControl
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
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createAccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createAccountBtn.FlatAppearance.BorderSize = 0;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createAccountBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createAccountBtn.Location = new System.Drawing.Point(390, 375);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(201, 38);
            this.createAccountBtn.TabIndex = 6;
            this.createAccountBtn.Text = "Create account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordText.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordText.Location = new System.Drawing.Point(390, 190);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(201, 26);
            this.passwordText.TabIndex = 2;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameText.Location = new System.Drawing.Point(390, 149);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(201, 26);
            this.usernameText.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(231, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(115, 24);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameLabel.Location = new System.Drawing.Point(229, 151);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(117, 24);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username :";
            // 
            // topLabel
            // 
            this.topLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.topLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLabel.Location = new System.Drawing.Point(419, 78);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(132, 36);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "Register";
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailText.Font = new System.Drawing.Font("Arial", 12F);
            this.emailText.Location = new System.Drawing.Point(390, 231);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(201, 26);
            this.emailText.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLabel.Location = new System.Drawing.Point(266, 233);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 24);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "E-mail :";
            // 
            // firstNameText
            // 
            this.firstNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameText.Font = new System.Drawing.Font("Arial", 12F);
            this.firstNameText.Location = new System.Drawing.Point(390, 272);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(201, 26);
            this.firstNameText.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameLabel.Location = new System.Drawing.Point(222, 274);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(124, 24);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name :";
            // 
            // lastNameText
            // 
            this.lastNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameText.Font = new System.Drawing.Font("Arial", 12F);
            this.lastNameText.Location = new System.Drawing.Point(390, 313);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(201, 26);
            this.lastNameText.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameLabel.Location = new System.Drawing.Point(223, 315);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(123, 24);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.topLabel);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(736, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
    }
}
