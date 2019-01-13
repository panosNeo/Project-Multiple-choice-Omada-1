namespace Administrator
{
    partial class BlockUserForm
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
            this.DaysBox = new System.Windows.Forms.TextBox();
            this.ReasonBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.blockBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DaysBox
            // 
            this.DaysBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DaysBox.Location = new System.Drawing.Point(88, 112);
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(179, 23);
            this.DaysBox.TabIndex = 23;
            // 
            // ReasonBox
            // 
            this.ReasonBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ReasonBox.Location = new System.Drawing.Point(88, 21);
            this.ReasonBox.Multiline = true;
            this.ReasonBox.Name = "ReasonBox";
            this.ReasonBox.Size = new System.Drawing.Size(179, 85);
            this.ReasonBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(30, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Days :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(15, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Reason :";
            // 
            // blockBtn
            // 
            this.blockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.blockBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.blockBtn.Location = new System.Drawing.Point(88, 141);
            this.blockBtn.Name = "blockBtn";
            this.blockBtn.Size = new System.Drawing.Size(85, 33);
            this.blockBtn.TabIndex = 26;
            this.blockBtn.Text = "Block";
            this.blockBtn.UseVisualStyleBackColor = true;
            this.blockBtn.Click += new System.EventHandler(this.blockBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.cancelBtn.Location = new System.Drawing.Point(182, 141);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 33);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(85, 2);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(114, 16);
            this.errorLabel.TabIndex = 28;
            this.errorLabel.Text = "Fill all the fields!";
            this.errorLabel.Visible = false;
            // 
            // BlockUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(350, 177);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.blockBtn);
            this.Controls.Add(this.DaysBox);
            this.Controls.Add(this.ReasonBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 215);
            this.Name = "BlockUserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DaysBox;
        private System.Windows.Forms.TextBox ReasonBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button blockBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label errorLabel;
    }
}