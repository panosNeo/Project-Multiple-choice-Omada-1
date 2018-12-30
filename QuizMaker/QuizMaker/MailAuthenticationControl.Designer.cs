namespace QuizMaker
{
    partial class MailAuthenticationControl
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
            this.vCodeText = new System.Windows.Forms.TextBox();
            this.vCodeLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vCodeText
            // 
            this.vCodeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vCodeText.Location = new System.Drawing.Point(437, 255);
            this.vCodeText.Name = "vCodeText";
            this.vCodeText.Size = new System.Drawing.Size(201, 20);
            this.vCodeText.TabIndex = 6;
            // 
            // vCodeLabel
            // 
            this.vCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vCodeLabel.AutoSize = true;
            this.vCodeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.vCodeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vCodeLabel.Location = new System.Drawing.Point(230, 251);
            this.vCodeLabel.Name = "vCodeLabel";
            this.vCodeLabel.Size = new System.Drawing.Size(176, 24);
            this.vCodeLabel.TabIndex = 5;
            this.vCodeLabel.Text = "Verification Code:";
            // 
            // topLabel
            // 
            this.topLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.topLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topLabel.Location = new System.Drawing.Point(201, 113);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(504, 36);
            this.topLabel.TabIndex = 4;
            this.topLabel.Text = "Enter Your Verification Code Below";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verifyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verifyBtn.FlatAppearance.BorderSize = 0;
            this.verifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.verifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.verifyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verifyBtn.Location = new System.Drawing.Point(378, 340);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(107, 38);
            this.verifyBtn.TabIndex = 7;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // MailAuthenticationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.vCodeText);
            this.Controls.Add(this.vCodeLabel);
            this.Controls.Add(this.topLabel);
            this.Name = "MailAuthenticationControl";
            this.Size = new System.Drawing.Size(763, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vCodeText;
        private System.Windows.Forms.Label vCodeLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button verifyBtn;
    }
}
