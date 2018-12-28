namespace QuizMaker
{
    partial class MailAuthentication
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
            this.logoLabel = new System.Windows.Forms.Label();
            this.codeText = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(375, 10);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(243, 31);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "Mail Authentication";
            // 
            // codeText
            // 
            this.codeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeText.Location = new System.Drawing.Point(451, 198);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(167, 20);
            this.codeText.TabIndex = 5;
            // 
            // codeLabel
            // 
            this.codeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.codeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeLabel.Location = new System.Drawing.Point(223, 198);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(204, 24);
            this.codeLabel.TabIndex = 4;
            this.codeLabel.Text = "Authentication Code:";
            // 
            // MailAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.logoLabel);
            this.Name = "MailAuthentication";
            this.Size = new System.Drawing.Size(730, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label codeLabel;
    }
}
