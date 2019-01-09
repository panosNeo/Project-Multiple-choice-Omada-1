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
            this.tagTreeView = new System.Windows.Forms.TreeView();
            this.searchTagBtn = new System.Windows.Forms.Button();
            this.searchByTagLabel = new System.Windows.Forms.Label();
            this.searchTextBtn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchByTextLabel = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
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
            this.panel2.Controls.Add(this.tagTreeView);
            this.panel2.Controls.Add(this.searchTagBtn);
            this.panel2.Controls.Add(this.searchByTagLabel);
            this.panel2.Controls.Add(this.searchTextBtn);
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.searchByTextLabel);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 59);
            this.panel2.TabIndex = 1;
            // 
            // tagTreeView
            // 
            this.tagTreeView.Location = new System.Drawing.Point(591, 7);
            this.tagTreeView.Name = "tagTreeView";
            this.tagTreeView.Size = new System.Drawing.Size(176, 49);
            this.tagTreeView.TabIndex = 8;
            this.tagTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tagTreeView_AfterSelect);
            // 
            // searchTagBtn
            // 
            this.searchTagBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTagBtn.FlatAppearance.BorderSize = 0;
            this.searchTagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.searchTagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.searchTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTagBtn.Image = global::QuizMaker.Properties.Resources.iconfinder_search_285651;
            this.searchTagBtn.Location = new System.Drawing.Point(800, 16);
            this.searchTagBtn.Name = "searchTagBtn";
            this.searchTagBtn.Size = new System.Drawing.Size(37, 29);
            this.searchTagBtn.TabIndex = 7;
            this.searchTagBtn.UseVisualStyleBackColor = true;
            this.searchTagBtn.Click += new System.EventHandler(this.searchTagBtn_Click);
            // 
            // searchByTagLabel
            // 
            this.searchByTagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByTagLabel.AutoSize = true;
            this.searchByTagLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchByTagLabel.ForeColor = System.Drawing.Color.White;
            this.searchByTagLabel.Location = new System.Drawing.Point(439, 16);
            this.searchByTagLabel.Name = "searchByTagLabel";
            this.searchByTagLabel.Size = new System.Drawing.Size(126, 22);
            this.searchByTagLabel.TabIndex = 5;
            this.searchByTagLabel.Text = "Search by tag";
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
            this.searchTextBtn.Click += new System.EventHandler(this.searchTextBtn_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(79, 20);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(234, 20);
            this.searchText.TabIndex = 3;
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
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsPanel.Location = new System.Drawing.Point(60, 141);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(720, 330);
            this.resultsPanel.TabIndex = 2;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(843, 490);
            this.SizeChanged += new System.EventHandler(this.SearchControl_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchTextBtn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label searchByTextLabel;
        private System.Windows.Forms.Label searchByTagLabel;
        private System.Windows.Forms.Button searchTagBtn;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.TreeView tagTreeView;
    }
}
