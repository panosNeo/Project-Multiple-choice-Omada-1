namespace Administrator
{
    partial class ProfileNote
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
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteBox
            // 
            this.NoteBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.NoteBox.Location = new System.Drawing.Point(224, 3);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.ReadOnly = true;
            this.NoteBox.Size = new System.Drawing.Size(146, 26);
            this.NoteBox.TabIndex = 1;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.NoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.NoteLabel.Location = new System.Drawing.Point(8, 6);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(200, 20);
            this.NoteLabel.TabIndex = 2;
            this.NoteLabel.Text = "Feedbacks to check out : ";
            // 
            // ProfileNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.NoteBox);
            this.Name = "ProfileNote";
            this.Size = new System.Drawing.Size(380, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label NoteLabel;
    }
}
