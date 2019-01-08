namespace Administrator
{
    partial class Report
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
            this.label6 = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quizIDBox = new System.Windows.Forms.TextBox();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(22, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "User :";
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(25, 23);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.ReadOnly = true;
            this.userIDBox.Size = new System.Drawing.Size(100, 20);
            this.userIDBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Report reason :";
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(147, 14);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.ReadOnly = true;
            this.reportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportBox.Size = new System.Drawing.Size(264, 34);
            this.reportBox.TabIndex = 15;
            this.reportBox.Text = " \r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(429, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quiz ID :";
            // 
            // quizIDBox
            // 
            this.quizIDBox.Location = new System.Drawing.Point(432, 23);
            this.quizIDBox.Name = "quizIDBox";
            this.quizIDBox.ReadOnly = true;
            this.quizIDBox.Size = new System.Drawing.Size(100, 20);
            this.quizIDBox.TabIndex = 17;
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Location = new System.Drawing.Point(554, 23);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(15, 14);
            this.deleteCheckbox.TabIndex = 18;
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteCheckbox);
            this.Controls.Add(this.quizIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.label6);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(600, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quizIDBox;
        private System.Windows.Forms.CheckBox deleteCheckbox;
    }
}
