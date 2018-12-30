﻿namespace QuizMaker
{
    partial class CreateQuizControl
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
            this.components = new System.ComponentModel.Container();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.stepOneNextBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.quizNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stepOneLabel = new System.Windows.Forms.Label();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.nextQuBtn = new System.Windows.Forms.Button();
            this.prevQuBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.innerQuestionPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.delAnswerBtn = new System.Windows.Forms.Button();
            this.nextAnswerBtn = new System.Windows.Forms.Button();
            this.questionNumber = new System.Windows.Forms.Label();
            this.questionSetLabel = new System.Windows.Forms.Label();
            this.setAnswerLabel = new System.Windows.Forms.Label();
            this.questionNameTextBox = new System.Windows.Forms.TextBox();
            this.stepToLabel = new System.Windows.Forms.Label();
            this.newQuestionBtn = new System.Windows.Forms.Button();
            this.finishQuestionsBtn = new System.Windows.Forms.Button();
            this.thirdPanel = new System.Windows.Forms.Panel();
            this.finishQuizBtn = new System.Windows.Forms.Button();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.stepThreeLabel = new System.Windows.Forms.Label();
            this.createQuizTimer = new System.Windows.Forms.Timer(this.components);
            this.firstPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.innerQuestionPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            this.thirdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstPanel
            // 
            this.firstPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstPanel.BackColor = System.Drawing.Color.White;
            this.firstPanel.Controls.Add(this.stepOneNextBtn);
            this.firstPanel.Controls.Add(this.comboBox1);
            this.firstPanel.Controls.Add(this.tagsLabel);
            this.firstPanel.Controls.Add(this.quizNameTextBox);
            this.firstPanel.Controls.Add(this.label1);
            this.firstPanel.Controls.Add(this.stepOneLabel);
            this.firstPanel.Location = new System.Drawing.Point(794, 105);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(260, 325);
            this.firstPanel.TabIndex = 0;
            // 
            // stepOneNextBtn
            // 
            this.stepOneNextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stepOneNextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stepOneNextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stepOneNextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stepOneNextBtn.FlatAppearance.BorderSize = 0;
            this.stepOneNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stepOneNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.stepOneNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepOneNextBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stepOneNextBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stepOneNextBtn.Location = new System.Drawing.Point(77, 275);
            this.stepOneNextBtn.Name = "stepOneNextBtn";
            this.stepOneNextBtn.Size = new System.Drawing.Size(107, 38);
            this.stepOneNextBtn.TabIndex = 6;
            this.stepOneNextBtn.Tag = "-5";
            this.stepOneNextBtn.Text = "Next";
            this.stepOneNextBtn.UseVisualStyleBackColor = false;
            this.stepOneNextBtn.Click += new System.EventHandler(this.movePanelsBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tagsLabel.Location = new System.Drawing.Point(3, 149);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(170, 23);
            this.tagsLabel.TabIndex = 3;
            this.tagsLabel.Text = "Set tags for quiz";
            // 
            // quizNameTextBox
            // 
            this.quizNameTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizNameTextBox.Location = new System.Drawing.Point(7, 83);
            this.quizNameTextBox.Name = "quizNameTextBox";
            this.quizNameTextBox.Size = new System.Drawing.Size(166, 27);
            this.quizNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set title for quiz";
            // 
            // stepOneLabel
            // 
            this.stepOneLabel.AutoSize = true;
            this.stepOneLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stepOneLabel.Location = new System.Drawing.Point(93, 11);
            this.stepOneLabel.Name = "stepOneLabel";
            this.stepOneLabel.Size = new System.Drawing.Size(80, 25);
            this.stepOneLabel.TabIndex = 0;
            this.stepOneLabel.Text = "Step 1";
            // 
            // secondPanel
            // 
            this.secondPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondPanel.BackColor = System.Drawing.Color.White;
            this.secondPanel.Controls.Add(this.nextQuBtn);
            this.secondPanel.Controls.Add(this.prevQuBtn);
            this.secondPanel.Controls.Add(this.backBtn);
            this.secondPanel.Controls.Add(this.innerQuestionPanel);
            this.secondPanel.Controls.Add(this.newQuestionBtn);
            this.secondPanel.Controls.Add(this.finishQuestionsBtn);
            this.secondPanel.Enabled = false;
            this.secondPanel.Location = new System.Drawing.Point(1144, 105);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(272, 391);
            this.secondPanel.TabIndex = 1;
            // 
            // nextQuBtn
            // 
            this.nextQuBtn.Enabled = false;
            this.nextQuBtn.Image = global::QuizMaker.Properties.Resources.fast_forward;
            this.nextQuBtn.Location = new System.Drawing.Point(213, 301);
            this.nextQuBtn.Name = "nextQuBtn";
            this.nextQuBtn.Size = new System.Drawing.Size(24, 24);
            this.nextQuBtn.TabIndex = 14;
            this.nextQuBtn.UseVisualStyleBackColor = true;
            this.nextQuBtn.Click += new System.EventHandler(this.nextQBtn_Click);
            // 
            // prevQuBtn
            // 
            this.prevQuBtn.Enabled = false;
            this.prevQuBtn.Image = global::QuizMaker.Properties.Resources.rewind;
            this.prevQuBtn.Location = new System.Drawing.Point(36, 301);
            this.prevQuBtn.Name = "prevQuBtn";
            this.prevQuBtn.Size = new System.Drawing.Size(24, 24);
            this.prevQuBtn.TabIndex = 13;
            this.prevQuBtn.UseVisualStyleBackColor = true;
            this.prevQuBtn.Click += new System.EventHandler(this.prevQBtn_click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(16, 338);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 38);
            this.backBtn.TabIndex = 12;
            this.backBtn.Tag = "5";
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.movePanelsBtn_Click);
            // 
            // innerQuestionPanel
            // 
            this.innerQuestionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.innerQuestionPanel.Controls.Add(this.deleteBtn);
            this.innerQuestionPanel.Controls.Add(this.AnswersPanel);
            this.innerQuestionPanel.Controls.Add(this.questionNumber);
            this.innerQuestionPanel.Controls.Add(this.questionSetLabel);
            this.innerQuestionPanel.Controls.Add(this.setAnswerLabel);
            this.innerQuestionPanel.Controls.Add(this.questionNameTextBox);
            this.innerQuestionPanel.Controls.Add(this.stepToLabel);
            this.innerQuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.innerQuestionPanel.Name = "innerQuestionPanel";
            this.innerQuestionPanel.Size = new System.Drawing.Size(272, 293);
            this.innerQuestionPanel.TabIndex = 11;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteBtn.Image = global::QuizMaker.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(223, 52);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(28, 28);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteQBtn_Click);
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.AutoScroll = true;
            this.AnswersPanel.Controls.Add(this.delAnswerBtn);
            this.AnswersPanel.Controls.Add(this.nextAnswerBtn);
            this.AnswersPanel.Location = new System.Drawing.Point(0, 149);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(272, 144);
            this.AnswersPanel.TabIndex = 13;
            // 
            // delAnswerBtn
            // 
            this.delAnswerBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delAnswerBtn.Location = new System.Drawing.Point(66, 3);
            this.delAnswerBtn.Name = "delAnswerBtn";
            this.delAnswerBtn.Size = new System.Drawing.Size(31, 30);
            this.delAnswerBtn.TabIndex = 13;
            this.delAnswerBtn.Text = "-";
            this.delAnswerBtn.UseVisualStyleBackColor = true;
            this.delAnswerBtn.Click += new System.EventHandler(this.delAnswerBtn_Click);
            // 
            // nextAnswerBtn
            // 
            this.nextAnswerBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextAnswerBtn.Location = new System.Drawing.Point(16, 3);
            this.nextAnswerBtn.Name = "nextAnswerBtn";
            this.nextAnswerBtn.Size = new System.Drawing.Size(31, 30);
            this.nextAnswerBtn.TabIndex = 12;
            this.nextAnswerBtn.Text = "+";
            this.nextAnswerBtn.UseVisualStyleBackColor = true;
            this.nextAnswerBtn.Click += new System.EventHandler(this.nextAnswerBtn_Click);
            // 
            // questionNumber
            // 
            this.questionNumber.AutoSize = true;
            this.questionNumber.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionNumber.Location = new System.Drawing.Point(185, 57);
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Size = new System.Drawing.Size(22, 23);
            this.questionNumber.TabIndex = 11;
            this.questionNumber.Text = "1";
            // 
            // questionSetLabel
            // 
            this.questionSetLabel.AutoSize = true;
            this.questionSetLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionSetLabel.Location = new System.Drawing.Point(12, 57);
            this.questionSetLabel.Name = "questionSetLabel";
            this.questionSetLabel.Size = new System.Drawing.Size(172, 23);
            this.questionSetLabel.TabIndex = 1;
            this.questionSetLabel.Text = "Set question No.";
            // 
            // setAnswerLabel
            // 
            this.setAnswerLabel.AutoSize = true;
            this.setAnswerLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.setAnswerLabel.Location = new System.Drawing.Point(12, 123);
            this.setAnswerLabel.Name = "setAnswerLabel";
            this.setAnswerLabel.Size = new System.Drawing.Size(135, 23);
            this.setAnswerLabel.TabIndex = 3;
            this.setAnswerLabel.Text = "Set answer/s";
            // 
            // questionNameTextBox
            // 
            this.questionNameTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionNameTextBox.Location = new System.Drawing.Point(16, 83);
            this.questionNameTextBox.Name = "questionNameTextBox";
            this.questionNameTextBox.Size = new System.Drawing.Size(235, 27);
            this.questionNameTextBox.TabIndex = 2;
            // 
            // stepToLabel
            // 
            this.stepToLabel.AutoSize = true;
            this.stepToLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stepToLabel.Location = new System.Drawing.Point(102, 11);
            this.stepToLabel.Name = "stepToLabel";
            this.stepToLabel.Size = new System.Drawing.Size(80, 25);
            this.stepToLabel.TabIndex = 0;
            this.stepToLabel.Text = "Step 2";
            // 
            // newQuestionBtn
            // 
            this.newQuestionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newQuestionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newQuestionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newQuestionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newQuestionBtn.FlatAppearance.BorderSize = 0;
            this.newQuestionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newQuestionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.newQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newQuestionBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newQuestionBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newQuestionBtn.Location = new System.Drawing.Point(66, 299);
            this.newQuestionBtn.Name = "newQuestionBtn";
            this.newQuestionBtn.Size = new System.Drawing.Size(141, 26);
            this.newQuestionBtn.TabIndex = 10;
            this.newQuestionBtn.Text = "Set next question";
            this.newQuestionBtn.UseVisualStyleBackColor = false;
            this.newQuestionBtn.Click += new System.EventHandler(this.newQuestionsBtn_Click);
            // 
            // finishQuestionsBtn
            // 
            this.finishQuestionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finishQuestionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finishQuestionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishQuestionsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finishQuestionsBtn.FlatAppearance.BorderSize = 0;
            this.finishQuestionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.finishQuestionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.finishQuestionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishQuestionsBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.finishQuestionsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishQuestionsBtn.Location = new System.Drawing.Point(144, 338);
            this.finishQuestionsBtn.Name = "finishQuestionsBtn";
            this.finishQuestionsBtn.Size = new System.Drawing.Size(107, 38);
            this.finishQuestionsBtn.TabIndex = 6;
            this.finishQuestionsBtn.Tag = "-5";
            this.finishQuestionsBtn.Text = "Finish";
            this.finishQuestionsBtn.UseVisualStyleBackColor = false;
            this.finishQuestionsBtn.Click += new System.EventHandler(this.movePanelsBtn_Click);
            // 
            // thirdPanel
            // 
            this.thirdPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thirdPanel.BackColor = System.Drawing.Color.White;
            this.thirdPanel.Controls.Add(this.finishQuizBtn);
            this.thirdPanel.Controls.Add(this.reviewLabel);
            this.thirdPanel.Controls.Add(this.stepThreeLabel);
            this.thirdPanel.Enabled = false;
            this.thirdPanel.Location = new System.Drawing.Point(1494, 105);
            this.thirdPanel.Name = "thirdPanel";
            this.thirdPanel.Size = new System.Drawing.Size(260, 325);
            this.thirdPanel.TabIndex = 2;
            // 
            // finishQuizBtn
            // 
            this.finishQuizBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finishQuizBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finishQuizBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishQuizBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finishQuizBtn.FlatAppearance.BorderSize = 0;
            this.finishQuizBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.finishQuizBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.finishQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishQuizBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.finishQuizBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishQuizBtn.Location = new System.Drawing.Point(77, 275);
            this.finishQuizBtn.Name = "finishQuizBtn";
            this.finishQuizBtn.Size = new System.Drawing.Size(107, 38);
            this.finishQuizBtn.TabIndex = 6;
            this.finishQuizBtn.Tag = "3";
            this.finishQuizBtn.Text = "Finish";
            this.finishQuizBtn.UseVisualStyleBackColor = false;
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reviewLabel.Location = new System.Drawing.Point(3, 57);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(179, 23);
            this.reviewLabel.TabIndex = 1;
            this.reviewLabel.Text = "Review your quiz";
            // 
            // stepThreeLabel
            // 
            this.stepThreeLabel.AutoSize = true;
            this.stepThreeLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stepThreeLabel.Location = new System.Drawing.Point(93, 11);
            this.stepThreeLabel.Name = "stepThreeLabel";
            this.stepThreeLabel.Size = new System.Drawing.Size(80, 25);
            this.stepThreeLabel.TabIndex = 0;
            this.stepThreeLabel.Text = "Step 3";
            // 
            // createQuizTimer
            // 
            this.createQuizTimer.Interval = 1;
            this.createQuizTimer.Tick += new System.EventHandler(this.createQuizTimer_Tick);
            // 
            // CreateQuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.thirdPanel);
            this.Controls.Add(this.secondPanel);
            this.Controls.Add(this.firstPanel);
            this.Name = "CreateQuizControl";
            this.Size = new System.Drawing.Size(1849, 509);
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.innerQuestionPanel.ResumeLayout(false);
            this.innerQuestionPanel.PerformLayout();
            this.AnswersPanel.ResumeLayout(false);
            this.thirdPanel.ResumeLayout(false);
            this.thirdPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.TextBox quizNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stepOneLabel;
        private System.Windows.Forms.Button stepOneNextBtn;
        private System.Windows.Forms.Panel secondPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel innerQuestionPanel;
        private System.Windows.Forms.Label questionNumber;
        private System.Windows.Forms.Label questionSetLabel;
        private System.Windows.Forms.Label setAnswerLabel;
        private System.Windows.Forms.TextBox questionNameTextBox;
        private System.Windows.Forms.Label stepToLabel;
        private System.Windows.Forms.Button newQuestionBtn;
        private System.Windows.Forms.Button finishQuestionsBtn;
        private System.Windows.Forms.Panel thirdPanel;
        private System.Windows.Forms.Button finishQuizBtn;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label stepThreeLabel;
        private System.Windows.Forms.Timer createQuizTimer;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button delAnswerBtn;
        private System.Windows.Forms.Button nextAnswerBtn;
        private System.Windows.Forms.Button prevQuBtn;
        private System.Windows.Forms.Button nextQuBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
