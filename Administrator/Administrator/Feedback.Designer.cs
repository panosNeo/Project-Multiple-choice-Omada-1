﻿namespace Administrator
{
    partial class Feedback
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
            this.feedbackBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.rateCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // feedbackBox
            // 
            this.feedbackBox.Location = new System.Drawing.Point(140, 14);
            this.feedbackBox.Multiline = true;
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.ReadOnly = true;
            this.feedbackBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedbackBox.Size = new System.Drawing.Size(277, 34);
            this.feedbackBox.TabIndex = 19;
            this.feedbackBox.Text = " \r\n ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Feedback :";
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(18, 23);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.ReadOnly = true;
            this.userIDBox.Size = new System.Drawing.Size(100, 20);
            this.userIDBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(15, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "User :";
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Location = new System.Drawing.Point(554, 23);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(15, 14);
            this.deleteCheckbox.TabIndex = 20;
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // rateCheckbox
            // 
            this.rateCheckbox.AutoSize = true;
            this.rateCheckbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.rateCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.rateCheckbox.Location = new System.Drawing.Point(427, 20);
            this.rateCheckbox.Name = "rateCheckbox";
            this.rateCheckbox.Size = new System.Drawing.Size(53, 20);
            this.rateCheckbox.TabIndex = 21;
            this.rateCheckbox.Text = "Rate";
            this.rateCheckbox.UseVisualStyleBackColor = true;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rateCheckbox);
            this.Controls.Add(this.deleteCheckbox);
            this.Controls.Add(this.feedbackBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.label6);
            this.Name = "Feedback";
            this.Size = new System.Drawing.Size(600, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feedbackBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox deleteCheckbox;
        private System.Windows.Forms.CheckBox rateCheckbox;
    }
}
