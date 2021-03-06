﻿namespace Administrator
{
    partial class UserDataControl
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
            this.warningLabel = new System.Windows.Forms.Label();
            this.SearchIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserGroupbox = new System.Windows.Forms.GroupBox();
            this.BlockButton = new System.Windows.Forms.Button();
            this.UserReset = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UserSettingsButton = new System.Windows.Forms.Button();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UserGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(289, 31);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(64, 16);
            this.warningLabel.TabIndex = 9;
            this.warningLabel.Text = "Warning *";
            this.warningLabel.Visible = false;
            // 
            // SearchIDBox
            // 
            this.SearchIDBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SearchIDBox.Location = new System.Drawing.Point(292, 50);
            this.SearchIDBox.Name = "SearchIDBox";
            this.SearchIDBox.Size = new System.Drawing.Size(152, 27);
            this.SearchIDBox.TabIndex = 0;
            this.SearchIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchIDBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(133, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Username :";
            // 
            // UserGroupbox
            // 
            this.UserGroupbox.Controls.Add(this.BlockButton);
            this.UserGroupbox.Controls.Add(this.UserReset);
            this.UserGroupbox.Controls.Add(this.EmailBox);
            this.UserGroupbox.Controls.Add(this.LastNameBox);
            this.UserGroupbox.Controls.Add(this.NameBox);
            this.UserGroupbox.Controls.Add(this.label6);
            this.UserGroupbox.Controls.Add(this.label5);
            this.UserGroupbox.Controls.Add(this.label4);
            this.UserGroupbox.Controls.Add(this.UpdateButton);
            this.UserGroupbox.Controls.Add(this.DeleteButton);
            this.UserGroupbox.Controls.Add(this.UserSettingsButton);
            this.UserGroupbox.Controls.Add(this.RoleBox);
            this.UserGroupbox.Controls.Add(this.label3);
            this.UserGroupbox.Controls.Add(this.UserIDBox);
            this.UserGroupbox.Controls.Add(this.label2);
            this.UserGroupbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.UserGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UserGroupbox.Location = new System.Drawing.Point(38, 144);
            this.UserGroupbox.Name = "UserGroupbox";
            this.UserGroupbox.Size = new System.Drawing.Size(654, 219);
            this.UserGroupbox.TabIndex = 10;
            this.UserGroupbox.TabStop = false;
            this.UserGroupbox.Text = "User Data";
            // 
            // BlockButton
            // 
            this.BlockButton.Enabled = false;
            this.BlockButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.BlockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.BlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockButton.Location = new System.Drawing.Point(561, 95);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(75, 31);
            this.BlockButton.TabIndex = 16;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // UserReset
            // 
            this.UserReset.Enabled = false;
            this.UserReset.FlatAppearance.BorderSize = 0;
            this.UserReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UserReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserReset.Image = global::Administrator.Properties.Resources.reset;
            this.UserReset.Location = new System.Drawing.Point(561, 22);
            this.UserReset.Name = "UserReset";
            this.UserReset.Size = new System.Drawing.Size(35, 35);
            this.UserReset.TabIndex = 15;
            this.UserReset.UseVisualStyleBackColor = false;
            this.UserReset.Click += new System.EventHandler(this.UserReset_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmailBox.Location = new System.Drawing.Point(274, 175);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.ReadOnly = true;
            this.EmailBox.Size = new System.Drawing.Size(132, 23);
            this.EmailBox.TabIndex = 6;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LastNameBox.Location = new System.Drawing.Point(274, 141);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.ReadOnly = true;
            this.LastNameBox.Size = new System.Drawing.Size(132, 23);
            this.LastNameBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameBox.Location = new System.Drawing.Point(274, 107);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(132, 23);
            this.NameBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name :";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(561, 167);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(561, 131);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.FlatAppearance.BorderSize = 0;
            this.UserSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UserSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSettingsButton.Image = global::Administrator.Properties.Resources.settings;
            this.UserSettingsButton.Location = new System.Drawing.Point(602, 22);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(35, 35);
            this.UserSettingsButton.TabIndex = 14;
            this.UserSettingsButton.UseVisualStyleBackColor = false;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // RoleBox
            // 
            this.RoleBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RoleBox.Location = new System.Drawing.Point(274, 73);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.ReadOnly = true;
            this.RoleBox.Size = new System.Drawing.Size(132, 23);
            this.RoleBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role :";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserIDBox.Location = new System.Drawing.Point(274, 39);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.ReadOnly = true;
            this.UserIDBox.Size = new System.Drawing.Size(132, 23);
            this.UserIDBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Administrator.Properties.Resources.search;
            this.SearchButton.Location = new System.Drawing.Point(450, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(57, 27);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UserDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.UserGroupbox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIDBox);
            this.Controls.Add(this.label1);
            this.Name = "UserDataControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.UserGroupbox.ResumeLayout(false);
            this.UserGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UserGroupbox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UserSettingsButton;
        private System.Windows.Forms.TextBox RoleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button UserReset;
        private System.Windows.Forms.Button BlockButton;
    }
}
