namespace Administrator
{
    partial class FeedbackControl
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
            this.reportPanel = new System.Windows.Forms.Panel();
            this.UpdateAllCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateFeedbackButton = new System.Windows.Forms.Button();
            this.deleteFeedbackButton = new System.Windows.Forms.Button();
            this.deleteAllCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showFeedbacksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.noFeedback = new System.Windows.Forms.Label();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPanel.Controls.Add(this.UpdateAllCheckbox);
            this.reportPanel.Controls.Add(this.UpdateFeedbackButton);
            this.reportPanel.Controls.Add(this.deleteFeedbackButton);
            this.reportPanel.Controls.Add(this.deleteAllCheckbox);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Location = new System.Drawing.Point(30, 34);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(676, 43);
            this.reportPanel.TabIndex = 16;
            // 
            // UpdateAllCheckbox
            // 
            this.UpdateAllCheckbox.AutoSize = true;
            this.UpdateAllCheckbox.Location = new System.Drawing.Point(453, 14);
            this.UpdateAllCheckbox.Name = "UpdateAllCheckbox";
            this.UpdateAllCheckbox.Size = new System.Drawing.Size(15, 14);
            this.UpdateAllCheckbox.TabIndex = 11;
            this.UpdateAllCheckbox.Tag = "update";
            this.UpdateAllCheckbox.UseVisualStyleBackColor = true;
            this.UpdateAllCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // UpdateFeedbackButton
            // 
            this.UpdateFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.UpdateFeedbackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateFeedbackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateFeedbackButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UpdateFeedbackButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateFeedbackButton.Location = new System.Drawing.Point(474, 3);
            this.UpdateFeedbackButton.Name = "UpdateFeedbackButton";
            this.UpdateFeedbackButton.Size = new System.Drawing.Size(72, 35);
            this.UpdateFeedbackButton.TabIndex = 10;
            this.UpdateFeedbackButton.Text = "Update";
            this.UpdateFeedbackButton.UseVisualStyleBackColor = false;
            this.UpdateFeedbackButton.Click += new System.EventHandler(this.UpdateFeedbackButton_Click);
            // 
            // deleteFeedbackButton
            // 
            this.deleteFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.deleteFeedbackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.deleteFeedbackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.deleteFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFeedbackButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteFeedbackButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteFeedbackButton.Location = new System.Drawing.Point(599, 3);
            this.deleteFeedbackButton.Name = "deleteFeedbackButton";
            this.deleteFeedbackButton.Size = new System.Drawing.Size(72, 35);
            this.deleteFeedbackButton.TabIndex = 9;
            this.deleteFeedbackButton.Text = "Delete";
            this.deleteFeedbackButton.UseVisualStyleBackColor = false;
            this.deleteFeedbackButton.Click += new System.EventHandler(this.deleteFeedbackButton_Click);
            // 
            // deleteAllCheckbox
            // 
            this.deleteAllCheckbox.AutoSize = true;
            this.deleteAllCheckbox.Location = new System.Drawing.Point(578, 14);
            this.deleteAllCheckbox.Name = "deleteAllCheckbox";
            this.deleteAllCheckbox.Size = new System.Drawing.Size(15, 14);
            this.deleteAllCheckbox.TabIndex = 7;
            this.deleteAllCheckbox.Tag = "delete";
            this.deleteAllCheckbox.UseVisualStyleBackColor = true;
            this.deleteAllCheckbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedbacks";
            // 
            // showFeedbacksPanel
            // 
            this.showFeedbacksPanel.AutoScroll = true;
            this.showFeedbacksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.showFeedbacksPanel.Location = new System.Drawing.Point(53, 73);
            this.showFeedbacksPanel.Name = "showFeedbacksPanel";
            this.showFeedbacksPanel.Size = new System.Drawing.Size(630, 233);
            this.showFeedbacksPanel.TabIndex = 17;
            // 
            // noFeedback
            // 
            this.noFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noFeedback.AutoSize = true;
            this.noFeedback.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.noFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.noFeedback.Location = new System.Drawing.Point(233, 339);
            this.noFeedback.Name = "noFeedback";
            this.noFeedback.Size = new System.Drawing.Size(231, 23);
            this.noFeedback.TabIndex = 18;
            this.noFeedback.Tag = "noFeedback";
            this.noFeedback.Text = "There are no Feedbacks";
            this.noFeedback.Visible = false;
            // 
            // FeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.noFeedback);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.showFeedbacksPanel);
            this.Name = "FeedbackControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.Load += new System.EventHandler(this.FeedbackControl_Load);
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button deleteFeedbackButton;
        private System.Windows.Forms.CheckBox deleteAllCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateFeedbackButton;
        private System.Windows.Forms.FlowLayoutPanel showFeedbacksPanel;
        private System.Windows.Forms.CheckBox UpdateAllCheckbox;
        private System.Windows.Forms.Label noFeedback;
    }
}
