namespace QuizMaker
{
    partial class AnswerPanel
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
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.correctCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AnswerText
            // 
            this.AnswerText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnswerText.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AnswerText.Location = new System.Drawing.Point(0, 3);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(166, 27);
            this.AnswerText.TabIndex = 14;
            // 
            // correctCheckBox
            // 
            this.correctCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correctCheckBox.AutoSize = true;
            this.correctCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.correctCheckBox.ForeColor = System.Drawing.Color.White;
            this.correctCheckBox.Location = new System.Drawing.Point(172, 9);
            this.correctCheckBox.Name = "correctCheckBox";
            this.correctCheckBox.Size = new System.Drawing.Size(67, 20);
            this.correctCheckBox.TabIndex = 15;
            this.correctCheckBox.Text = "correct";
            this.correctCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.correctCheckBox);
            this.Name = "AnswerPanel";
            this.Size = new System.Drawing.Size(234, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.CheckBox correctCheckBox;
    }
}
