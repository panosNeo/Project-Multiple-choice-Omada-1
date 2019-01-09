namespace QuizMaker
{
    partial class ForgotPasswordControl
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.EmailBox = new QuizMaker.CustomTextBox();
            this.verificationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLabel.Location = new System.Drawing.Point(123, 118);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(539, 24);
            this.messageLabel.TabIndex = 9;
            this.messageLabel.Text = "Write below the e-mail you have linked with your account";
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailBox.ForeColor = System.Drawing.Color.White;
            this.EmailBox.Location = new System.Drawing.Point(245, 162);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(282, 20);
            this.EmailBox.TabIndex = 10;
            // 
            // verificationBtn
            // 
            this.verificationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verificationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.verificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verificationBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificationBtn.FlatAppearance.BorderSize = 0;
            this.verificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verificationBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.verificationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verificationBtn.Location = new System.Drawing.Point(288, 211);
            this.verificationBtn.Name = "verificationBtn";
            this.verificationBtn.Size = new System.Drawing.Size(201, 38);
            this.verificationBtn.TabIndex = 11;
            this.verificationBtn.Text = "Send code";
            this.verificationBtn.UseVisualStyleBackColor = false;
            this.verificationBtn.Click += new System.EventHandler(this.verificationBtn_Click);
            // 
            // ForgotPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.verificationBtn);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "ForgotPasswordControl";
            this.Size = new System.Drawing.Size(792, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private CustomTextBox EmailBox;
        private System.Windows.Forms.Button verificationBtn;
    }
}
