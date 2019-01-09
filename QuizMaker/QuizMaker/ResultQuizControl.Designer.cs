namespace QuizMaker
{
    partial class ResultQuizControl
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
            this.quizTitleLabel = new System.Windows.Forms.Label();
            this.quizTitleText = new QuizMaker.CustomTextBox();
            this.quizSubjectText = new QuizMaker.CustomTextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.numOfQuestions = new System.Windows.Forms.Label();
            this.questionCountText = new QuizMaker.CustomTextBox();
            this.likesLabel = new System.Windows.Forms.Label();
            this.dislikesLabel = new System.Windows.Forms.Label();
            this.likesText = new QuizMaker.CustomTextBox();
            this.dislikesText = new QuizMaker.CustomTextBox();
            this.SuspendLayout();
            // 
            // quizTitleLabel
            // 
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizTitleLabel.ForeColor = System.Drawing.Color.White;
            this.quizTitleLabel.Location = new System.Drawing.Point(3, 12);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new System.Drawing.Size(71, 18);
            this.quizTitleLabel.TabIndex = 0;
            this.quizTitleLabel.Text = "Quiz Title";
            // 
            // quizTitleText
            // 
            this.quizTitleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.quizTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quizTitleText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizTitleText.ForeColor = System.Drawing.Color.White;
            this.quizTitleText.Location = new System.Drawing.Point(80, 10);
            this.quizTitleText.Name = "quizTitleText";
            this.quizTitleText.ReadOnly = true;
            this.quizTitleText.Size = new System.Drawing.Size(179, 20);
            this.quizTitleText.TabIndex = 1;
            // 
            // quizSubjectText
            // 
            this.quizSubjectText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.quizSubjectText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quizSubjectText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quizSubjectText.ForeColor = System.Drawing.Color.White;
            this.quizSubjectText.Location = new System.Drawing.Point(80, 46);
            this.quizSubjectText.Name = "quizSubjectText";
            this.quizSubjectText.ReadOnly = true;
            this.quizSubjectText.Size = new System.Drawing.Size(179, 20);
            this.quizSubjectText.TabIndex = 3;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(3, 48);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(60, 18);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject";
            // 
            // numOfQuestions
            // 
            this.numOfQuestions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numOfQuestions.AutoSize = true;
            this.numOfQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numOfQuestions.ForeColor = System.Drawing.Color.White;
            this.numOfQuestions.Location = new System.Drawing.Point(329, 12);
            this.numOfQuestions.Name = "numOfQuestions";
            this.numOfQuestions.Size = new System.Drawing.Size(151, 18);
            this.numOfQuestions.TabIndex = 4;
            this.numOfQuestions.Text = "Number of questions";
            // 
            // questionCountText
            // 
            this.questionCountText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionCountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.questionCountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionCountText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.questionCountText.ForeColor = System.Drawing.Color.White;
            this.questionCountText.Location = new System.Drawing.Point(351, 33);
            this.questionCountText.Name = "questionCountText";
            this.questionCountText.ReadOnly = true;
            this.questionCountText.Size = new System.Drawing.Size(109, 20);
            this.questionCountText.TabIndex = 5;
            // 
            // likesLabel
            // 
            this.likesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.likesLabel.AutoSize = true;
            this.likesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.likesLabel.ForeColor = System.Drawing.Color.White;
            this.likesLabel.Location = new System.Drawing.Point(552, 10);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(46, 18);
            this.likesLabel.TabIndex = 6;
            this.likesLabel.Text = "Likes";
            // 
            // dislikesLabel
            // 
            this.dislikesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dislikesLabel.AutoSize = true;
            this.dislikesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dislikesLabel.ForeColor = System.Drawing.Color.White;
            this.dislikesLabel.Location = new System.Drawing.Point(534, 40);
            this.dislikesLabel.Name = "dislikesLabel";
            this.dislikesLabel.Size = new System.Drawing.Size(64, 18);
            this.dislikesLabel.TabIndex = 7;
            this.dislikesLabel.Text = "Dislikes";
            // 
            // likesText
            // 
            this.likesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.likesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.likesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.likesText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.likesText.ForeColor = System.Drawing.Color.White;
            this.likesText.Location = new System.Drawing.Point(604, 8);
            this.likesText.Name = "likesText";
            this.likesText.ReadOnly = true;
            this.likesText.Size = new System.Drawing.Size(109, 20);
            this.likesText.TabIndex = 8;
            // 
            // dislikesText
            // 
            this.dislikesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dislikesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.dislikesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dislikesText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dislikesText.ForeColor = System.Drawing.Color.White;
            this.dislikesText.Location = new System.Drawing.Point(604, 38);
            this.dislikesText.Name = "dislikesText";
            this.dislikesText.ReadOnly = true;
            this.dislikesText.Size = new System.Drawing.Size(109, 20);
            this.dislikesText.TabIndex = 9;
            // 
            // ResultQuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.dislikesText);
            this.Controls.Add(this.likesText);
            this.Controls.Add(this.dislikesLabel);
            this.Controls.Add(this.likesLabel);
            this.Controls.Add(this.questionCountText);
            this.Controls.Add(this.numOfQuestions);
            this.Controls.Add(this.quizSubjectText);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.quizTitleText);
            this.Controls.Add(this.quizTitleLabel);
            this.Name = "ResultQuizControl";
            this.Size = new System.Drawing.Size(728, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizTitleLabel;
        private CustomTextBox quizTitleText;
        private CustomTextBox quizSubjectText;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label numOfQuestions;
        private CustomTextBox questionCountText;
        private System.Windows.Forms.Label likesLabel;
        private System.Windows.Forms.Label dislikesLabel;
        private CustomTextBox likesText;
        private CustomTextBox dislikesText;
    }
}
