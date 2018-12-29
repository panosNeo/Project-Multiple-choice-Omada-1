namespace QuizMaker
{
    partial class QuizPanel
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
            this.questionHolder = new System.Windows.Forms.Panel();
            this.answersHolder = new System.Windows.Forms.Panel();
            this.questionSwapHolder = new System.Windows.Forms.Panel();
            this.quizTitleLabel = new System.Windows.Forms.Label();
            this.answerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionHolder
            // 
            this.questionHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.questionHolder.Location = new System.Drawing.Point(175, 121);
            this.questionHolder.Name = "questionHolder";
            this.questionHolder.Size = new System.Drawing.Size(591, 85);
            this.questionHolder.TabIndex = 0;
            // 
            // answersHolder
            // 
            this.answersHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answersHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.answersHolder.Location = new System.Drawing.Point(175, 212);
            this.answersHolder.Name = "answersHolder";
            this.answersHolder.Size = new System.Drawing.Size(591, 235);
            this.answersHolder.TabIndex = 1;
            // 
            // questionSwapHolder
            // 
            this.questionSwapHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionSwapHolder.AutoScroll = true;
            this.questionSwapHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(79)))));
            this.questionSwapHolder.Location = new System.Drawing.Point(175, 497);
            this.questionSwapHolder.Name = "questionSwapHolder";
            this.questionSwapHolder.Size = new System.Drawing.Size(591, 69);
            this.questionSwapHolder.TabIndex = 2;
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizTitleLabel.ForeColor = System.Drawing.Color.White;
            this.quizTitleLabel.Location = new System.Drawing.Point(439, 89);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(63, 29);
            this.quizTitleLabel.TabIndex = 3;
            this.quizTitleLabel.Text = "Title";
            // 
            // answerBtn
            // 
            this.answerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answerBtn.FlatAppearance.BorderSize = 0;
            this.answerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.answerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerBtn.Location = new System.Drawing.Point(377, 453);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(186, 38);
            this.answerBtn.TabIndex = 6;
            this.answerBtn.Text = "Submit answer";
            this.answerBtn.UseVisualStyleBackColor = false;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // QuizPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.quizTitleLabel);
            this.Controls.Add(this.questionSwapHolder);
            this.Controls.Add(this.answersHolder);
            this.Controls.Add(this.questionHolder);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "QuizPanel";
            this.Size = new System.Drawing.Size(960, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionHolder;
        private System.Windows.Forms.Panel answersHolder;
        private System.Windows.Forms.Panel questionSwapHolder;
        private System.Windows.Forms.Label quizTitleLabel;
        private System.Windows.Forms.Button answerBtn;
    }
}
