﻿namespace QuizMaker
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.feebackBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.menuVisibleBtn = new System.Windows.Forms.Button();
            this.feelLuckyBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.createQuizBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.feebackBtn);
            this.leftPanel.Controls.Add(this.profileBtn);
            this.leftPanel.Controls.Add(this.menuVisibleBtn);
            this.leftPanel.Controls.Add(this.feelLuckyBtn);
            this.leftPanel.Controls.Add(this.categoriesBtn);
            this.leftPanel.Controls.Add(this.createQuizBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 70);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(165, 486);
            this.leftPanel.TabIndex = 1;
            // 
            // feebackBtn
            // 
            this.feebackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.feebackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feebackBtn.FlatAppearance.BorderSize = 0;
            this.feebackBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.feebackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feebackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.feebackBtn.ForeColor = System.Drawing.Color.White;
            this.feebackBtn.Image = global::QuizMaker.Properties.Resources.feedback;
            this.feebackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feebackBtn.Location = new System.Drawing.Point(-1, 449);
            this.feebackBtn.Name = "feebackBtn";
            this.feebackBtn.Size = new System.Drawing.Size(169, 36);
            this.feebackBtn.TabIndex = 7;
            this.feebackBtn.Tag = "feedback";
            this.feebackBtn.Text = "Feedback";
            this.feebackBtn.UseVisualStyleBackColor = true;
            this.feebackBtn.Click += new System.EventHandler(this.LeftMenuButtons_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::QuizMaker.Properties.Resources.Account1;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(-1, 407);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(169, 36);
            this.profileBtn.TabIndex = 6;
            this.profileBtn.Tag = "profile";
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.LeftMenuButtons_Click);
            // 
            // menuVisibleBtn
            // 
            this.menuVisibleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuVisibleBtn.FlatAppearance.BorderSize = 0;
            this.menuVisibleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuVisibleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.menuVisibleBtn.ForeColor = System.Drawing.Color.White;
            this.menuVisibleBtn.Image = global::QuizMaker.Properties.Resources.menu2;
            this.menuVisibleBtn.Location = new System.Drawing.Point(-1, -1);
            this.menuVisibleBtn.Name = "menuVisibleBtn";
            this.menuVisibleBtn.Size = new System.Drawing.Size(30, 36);
            this.menuVisibleBtn.TabIndex = 5;
            this.menuVisibleBtn.UseVisualStyleBackColor = true;
            this.menuVisibleBtn.Click += new System.EventHandler(this.menuVisibleBtn_Click);
            // 
            // feelLuckyBtn
            // 
            this.feelLuckyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feelLuckyBtn.FlatAppearance.BorderSize = 0;
            this.feelLuckyBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.feelLuckyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feelLuckyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.feelLuckyBtn.ForeColor = System.Drawing.Color.White;
            this.feelLuckyBtn.Image = global::QuizMaker.Properties.Resources.feedback1;
            this.feelLuckyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feelLuckyBtn.Location = new System.Drawing.Point(-1, 134);
            this.feelLuckyBtn.Name = "feelLuckyBtn";
            this.feelLuckyBtn.Size = new System.Drawing.Size(169, 36);
            this.feelLuckyBtn.TabIndex = 4;
            this.feelLuckyBtn.Tag = "feelLucky";
            this.feelLuckyBtn.Text = "Feel Lucky";
            this.feelLuckyBtn.UseVisualStyleBackColor = true;
            this.feelLuckyBtn.Click += new System.EventHandler(this.LeftMenuButtons_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Image = global::QuizMaker.Properties.Resources.subject;
            this.categoriesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesBtn.Location = new System.Drawing.Point(-1, 92);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(169, 36);
            this.categoriesBtn.TabIndex = 3;
            this.categoriesBtn.Tag = "categories";
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.LeftMenuButtons_Click);
            // 
            // createQuizBtn
            // 
            this.createQuizBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createQuizBtn.FlatAppearance.BorderSize = 0;
            this.createQuizBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.createQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createQuizBtn.ForeColor = System.Drawing.Color.White;
            this.createQuizBtn.Image = global::QuizMaker.Properties.Resources.list;
            this.createQuizBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createQuizBtn.Location = new System.Drawing.Point(-1, 50);
            this.createQuizBtn.Name = "createQuizBtn";
            this.createQuizBtn.Size = new System.Drawing.Size(169, 36);
            this.createQuizBtn.TabIndex = 2;
            this.createQuizBtn.Tag = "createQuiz";
            this.createQuizBtn.Text = "Create quiz";
            this.createQuizBtn.UseVisualStyleBackColor = true;
            this.createQuizBtn.Click += new System.EventHandler(this.LeftMenuButtons_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.logoLabel);
            this.topPanel.Controls.Add(this.loginBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(950, 70);
            this.topPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(3, 14);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(152, 31);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Quiz Maker";
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(150)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Image = global::QuizMaker.Properties.Resources.login;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(815, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(133, 68);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(950, 556);
            this.mainPanel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 556);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(966, 594);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createQuizBtn;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button feelLuckyBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button menuVisibleBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button feebackBtn;
    }
}

