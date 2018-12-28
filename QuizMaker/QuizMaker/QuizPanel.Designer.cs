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
            this.SuspendLayout();
            // 
            // questionHolder
            // 
            this.questionHolder.Location = new System.Drawing.Point(3, 80);
            this.questionHolder.Name = "questionHolder";
            this.questionHolder.Size = new System.Drawing.Size(957, 85);
            this.questionHolder.TabIndex = 0;
            // 
            // answersHolder
            // 
            this.answersHolder.Location = new System.Drawing.Point(3, 171);
            this.answersHolder.Name = "answersHolder";
            this.answersHolder.Size = new System.Drawing.Size(954, 235);
            this.answersHolder.TabIndex = 1;
            // 
            // questionSwapHolder
            // 
            this.questionSwapHolder.Location = new System.Drawing.Point(127, 412);
            this.questionSwapHolder.Name = "questionSwapHolder";
            this.questionSwapHolder.Size = new System.Drawing.Size(719, 50);
            this.questionSwapHolder.TabIndex = 2;
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizTitleLabel.ForeColor = System.Drawing.Color.White;
            this.quizTitleLabel.Location = new System.Drawing.Point(439, 18);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(63, 29);
            this.quizTitleLabel.TabIndex = 3;
            this.quizTitleLabel.Text = "Title";
            // 
            // QuizPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.quizTitleLabel);
            this.Controls.Add(this.questionSwapHolder);
            this.Controls.Add(this.answersHolder);
            this.Controls.Add(this.questionHolder);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "QuizPanel";
            this.Size = new System.Drawing.Size(960, 509);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionHolder;
        private System.Windows.Forms.Panel answersHolder;
        private System.Windows.Forms.Panel questionSwapHolder;
        private System.Windows.Forms.Label quizTitleLabel;
    }
}
