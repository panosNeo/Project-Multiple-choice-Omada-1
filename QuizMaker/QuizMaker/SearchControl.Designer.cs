namespace QuizMaker
{
    partial class SearchControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchByTextLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchTextBtn = new System.Windows.Forms.Button();
            this.searchByTagLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchTagBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.searchTagBtn);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchByTagLabel);
            this.panel2.Controls.Add(this.searchTextBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.searchByTextLabel);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 59);
            this.panel2.TabIndex = 1;
            // 
            // searchByTextLabel
            // 
            this.searchByTextLabel.AutoSize = true;
            this.searchByTextLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchByTextLabel.ForeColor = System.Drawing.Color.White;
            this.searchByTextLabel.Location = new System.Drawing.Point(3, 18);
            this.searchByTextLabel.Name = "searchByTextLabel";
            this.searchByTextLabel.Size = new System.Drawing.Size(70, 22);
            this.searchByTextLabel.TabIndex = 2;
            this.searchByTextLabel.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 3;
            // 
            // searchTextBtn
            // 
            this.searchTextBtn.FlatAppearance.BorderSize = 0;
            this.searchTextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.searchTextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.searchTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTextBtn.Image = global::QuizMaker.Properties.Resources.iconfinder_search_285651;
            this.searchTextBtn.Location = new System.Drawing.Point(319, 17);
            this.searchTextBtn.Name = "searchTextBtn";
            this.searchTextBtn.Size = new System.Drawing.Size(37, 29);
            this.searchTextBtn.TabIndex = 4;
            this.searchTextBtn.UseVisualStyleBackColor = true;
            // 
            // searchByTagLabel
            // 
            this.searchByTagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByTagLabel.AutoSize = true;
            this.searchByTagLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchByTagLabel.ForeColor = System.Drawing.Color.White;
            this.searchByTagLabel.Location = new System.Drawing.Point(470, 17);
            this.searchByTagLabel.Name = "searchByTagLabel";
            this.searchByTagLabel.Size = new System.Drawing.Size(126, 22);
            this.searchByTagLabel.TabIndex = 5;
            this.searchByTagLabel.Text = "Search by tag";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // searchTagBtn
            // 
            this.searchTagBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTagBtn.FlatAppearance.BorderSize = 0;
            this.searchTagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.searchTagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.searchTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTagBtn.Image = global::QuizMaker.Properties.Resources.iconfinder_search_285651;
            this.searchTagBtn.Location = new System.Drawing.Point(729, 16);
            this.searchTagBtn.Name = "searchTagBtn";
            this.searchTagBtn.Size = new System.Drawing.Size(37, 29);
            this.searchTagBtn.TabIndex = 7;
            this.searchTagBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 354);
            this.panel3.TabIndex = 2;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(843, 495);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchTextBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchByTextLabel;
        private System.Windows.Forms.Label searchByTagLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchTagBtn;
        private System.Windows.Forms.Panel panel3;
    }
}
