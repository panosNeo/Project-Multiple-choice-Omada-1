namespace QuizMaker
{
    partial class PrintQuestion
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
            this.QuestionNameLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QuestionNameLabel
            // 
            this.QuestionNameLabel.AutoSize = true;
            this.QuestionNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuestionNameLabel.Location = new System.Drawing.Point(3, 0);
            this.QuestionNameLabel.Name = "QuestionNameLabel";
            this.QuestionNameLabel.Size = new System.Drawing.Size(47, 16);
            this.QuestionNameLabel.TabIndex = 0;
            this.QuestionNameLabel.Text = "label1";
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(30, 27);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(54, 13);
            this.answer1.TabIndex = 1;
            this.answer1.Text = "undefined";
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(30, 49);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(54, 13);
            this.answer2.TabIndex = 2;
            this.answer2.Text = "undefined";
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(30, 71);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(54, 13);
            this.answer3.TabIndex = 3;
            this.answer3.Text = "undefined";
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(30, 93);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(54, 13);
            this.answer4.TabIndex = 4;
            this.answer4.Text = "undefined";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 93);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // PrintQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.QuestionNameLabel);
            this.Name = "PrintQuestion";
            this.Size = new System.Drawing.Size(650, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNameLabel;
        private System.Windows.Forms.Label answer1;
        private System.Windows.Forms.Label answer2;
        private System.Windows.Forms.Label answer3;
        private System.Windows.Forms.Label answer4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}
