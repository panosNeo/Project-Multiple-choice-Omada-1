namespace QuizMaker
{
    partial class FeedbackControl
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
            this.feedbackText = new System.Windows.Forms.TextBox();
            this.searchByTagLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackText
            // 
            this.feedbackText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedbackText.Location = new System.Drawing.Point(214, 120);
            this.feedbackText.Multiline = true;
            this.feedbackText.Name = "feedbackText";
            this.feedbackText.Size = new System.Drawing.Size(329, 155);
            this.feedbackText.TabIndex = 0;
            // 
            // searchByTagLabel
            // 
            this.searchByTagLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByTagLabel.AutoSize = true;
            this.searchByTagLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchByTagLabel.ForeColor = System.Drawing.Color.White;
            this.searchByTagLabel.Location = new System.Drawing.Point(98, 72);
            this.searchByTagLabel.Name = "searchByTagLabel";
            this.searchByTagLabel.Size = new System.Drawing.Size(565, 22);
            this.searchByTagLabel.TabIndex = 6;
            this.searchByTagLabel.Text = "Your feedback makes this application better. Tell us what you think!";
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendBtn.Location = new System.Drawing.Point(336, 295);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(94, 38);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // FeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.searchByTagLabel);
            this.Controls.Add(this.feedbackText);
            this.Name = "FeedbackControl";
            this.Size = new System.Drawing.Size(765, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feedbackText;
        private System.Windows.Forms.Label searchByTagLabel;
        private System.Windows.Forms.Button sendBtn;
    }
}
