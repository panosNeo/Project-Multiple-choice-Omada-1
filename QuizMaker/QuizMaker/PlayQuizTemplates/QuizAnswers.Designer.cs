
﻿namespace QuizMaker.PlayQuizTemplates
{
    partial class QuizAnswers
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerNumLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(64, 16);
            this.answerLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(70, 18);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "Question";
            // 
            // answerNumLabel
            // 
            this.answerNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerNumLabel.AutoSize = true;
            this.answerNumLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerNumLabel.ForeColor = System.Drawing.Color.White;
            this.answerNumLabel.Location = new System.Drawing.Point(15, 16);
            this.answerNumLabel.Name = "answerNumLabel";
            this.answerNumLabel.Size = new System.Drawing.Size(22, 18);
            this.answerNumLabel.TabIndex = 1;
            this.answerNumLabel.Text = "1)";
            // 
            // answerBox
            // 
            this.answerBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.answerBox.AutoSize = true;
            this.answerBox.Location = new System.Drawing.Point(43, 20);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(15, 14);
            this.answerBox.TabIndex = 2;
            this.answerBox.UseVisualStyleBackColor = true;
            // 
            // QuizAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.answerNumLabel);
            this.Controls.Add(this.answerLabel);
            this.MaximumSize = new System.Drawing.Size(500, 0);
            this.Name = "QuizAnswers";
            this.Size = new System.Drawing.Size(500, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label answerNumLabel;
        private System.Windows.Forms.CheckBox answerBox;
    }
}

