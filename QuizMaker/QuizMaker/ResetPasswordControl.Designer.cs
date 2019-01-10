namespace QuizMaker
{
    partial class ResetPasswordControl
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
            this.verificationBtn = new System.Windows.Forms.Button();
            this.CodeBox = new QuizMaker.CustomTextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.secondNewPassText = new QuizMaker.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.firstNewPassText = new QuizMaker.CustomTextBox();
            this.messagePanelLabel = new System.Windows.Forms.Label();
            this.resetPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.verificationBtn.Location = new System.Drawing.Point(270, 206);
            this.verificationBtn.Name = "verificationBtn";
            this.verificationBtn.Size = new System.Drawing.Size(201, 38);
            this.verificationBtn.TabIndex = 14;
            this.verificationBtn.Text = "Verify";
            this.verificationBtn.UseVisualStyleBackColor = false;
            this.verificationBtn.Click += new System.EventHandler(this.verificationBtn_Click);
            // 
            // CodeBox
            // 
            this.CodeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CodeBox.ForeColor = System.Drawing.Color.White;
            this.CodeBox.Location = new System.Drawing.Point(269, 155);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(202, 24);
            this.CodeBox.TabIndex = 13;
            this.CodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeBox_KeyDown);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLabel.Location = new System.Drawing.Point(138, 111);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(470, 24);
            this.messageLabel.TabIndex = 12;
            this.messageLabel.Text = "Paste the code you received in your e-mail below";
            // 
            // resetPanel
            // 
            this.resetPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetPanel.Controls.Add(this.secondNewPassText);
            this.resetPanel.Controls.Add(this.label1);
            this.resetPanel.Controls.Add(this.submitBtn);
            this.resetPanel.Controls.Add(this.firstNewPassText);
            this.resetPanel.Controls.Add(this.messagePanelLabel);
            this.resetPanel.Location = new System.Drawing.Point(109, 51);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(529, 307);
            this.resetPanel.TabIndex = 15;
            this.resetPanel.Visible = false;
            // 
            // secondNewPassText
            // 
            this.secondNewPassText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondNewPassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.secondNewPassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNewPassText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secondNewPassText.ForeColor = System.Drawing.Color.White;
            this.secondNewPassText.Location = new System.Drawing.Point(163, 156);
            this.secondNewPassText.Name = "secondNewPassText";
            this.secondNewPassText.PasswordChar = '*';
            this.secondNewPassText.Size = new System.Drawing.Size(202, 24);
            this.secondNewPassText.TabIndex = 17;
            this.secondNewPassText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNewPassText_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(171, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Repeat password";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitBtn.Location = new System.Drawing.Point(195, 226);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 38);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // firstNewPassText
            // 
            this.firstNewPassText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNewPassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.firstNewPassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNewPassText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNewPassText.ForeColor = System.Drawing.Color.White;
            this.firstNewPassText.Location = new System.Drawing.Point(162, 93);
            this.firstNewPassText.Name = "firstNewPassText";
            this.firstNewPassText.PasswordChar = '*';
            this.firstNewPassText.Size = new System.Drawing.Size(202, 24);
            this.firstNewPassText.TabIndex = 16;
            this.firstNewPassText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNewPassText_KeyDown);
            // 
            // messagePanelLabel
            // 
            this.messagePanelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messagePanelLabel.AutoSize = true;
            this.messagePanelLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messagePanelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messagePanelLabel.Location = new System.Drawing.Point(170, 64);
            this.messagePanelLabel.Name = "messagePanelLabel";
            this.messagePanelLabel.Size = new System.Drawing.Size(182, 24);
            this.messagePanelLabel.TabIndex = 15;
            this.messagePanelLabel.Text = "Set new password";
            // 
            // ResetPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.resetPanel);
            this.Controls.Add(this.verificationBtn);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "ResetPasswordControl";
            this.Size = new System.Drawing.Size(746, 415);
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verificationBtn;
        private CustomTextBox CodeBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel resetPanel;
        private CustomTextBox secondNewPassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private CustomTextBox firstNewPassText;
        private System.Windows.Forms.Label messagePanelLabel;
    }
}
