namespace QuizMaker.PlayQuizTemplates
{
    partial class QuizSwap
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
            this.questionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBtn
            // 
            this.questionBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.questionBtn.Location = new System.Drawing.Point(0, 0);
            this.questionBtn.Name = "questionBtn";
            this.questionBtn.Size = new System.Drawing.Size(50, 50);
            this.questionBtn.TabIndex = 0;
            this.questionBtn.UseVisualStyleBackColor = false;
            // 
            // QuizSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionBtn);
            this.Name = "QuizSwap";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button questionBtn;
    }
}
