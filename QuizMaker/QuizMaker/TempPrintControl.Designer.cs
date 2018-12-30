namespace QuizMaker
{
    partial class TempPrintControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.surnamePosLabel = new System.Windows.Forms.Label();
            this.namePosLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.surnamePosLabel);
            this.panel1.Controls.Add(this.namePosLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 157);
            this.panel1.TabIndex = 0;
            // 
            // surnamePosLabel
            // 
            this.surnamePosLabel.AutoSize = true;
            this.surnamePosLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnamePosLabel.Location = new System.Drawing.Point(192, 99);
            this.surnamePosLabel.Name = "surnamePosLabel";
            this.surnamePosLabel.Size = new System.Drawing.Size(86, 22);
            this.surnamePosLabel.TabIndex = 2;
            this.surnamePosLabel.Text = "Surname";
            // 
            // namePosLabel
            // 
            this.namePosLabel.AutoSize = true;
            this.namePosLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.namePosLabel.Location = new System.Drawing.Point(192, 57);
            this.namePosLabel.Name = "namePosLabel";
            this.namePosLabel.Size = new System.Drawing.Size(60, 22);
            this.namePosLabel.TabIndex = 1;
            this.namePosLabel.Text = "Name";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(15, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(69, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 540);
            this.panel2.TabIndex = 3;
            // 
            // TempPrintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TempPrintControl";
            this.Size = new System.Drawing.Size(654, 705);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label surnamePosLabel;
        private System.Windows.Forms.Label namePosLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel2;
    }
}
