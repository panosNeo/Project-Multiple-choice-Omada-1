
﻿namespace QuizMaker.PlayQuizTemplates
{
    partial class QuizQuestion
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(3, 0);
            this.questionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(94, 24);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Question";
            // 
            // QuizQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.questionLabel);
            this.MaximumSize = new System.Drawing.Size(500, 0);
            this.Name = "QuizQuestion";
            this.Size = new System.Drawing.Size(500, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
    }
}

