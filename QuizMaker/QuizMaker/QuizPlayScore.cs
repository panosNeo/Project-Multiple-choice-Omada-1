﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.QuizHandler;

namespace QuizMaker
{
    public partial class QuizPlayScore : UserControl
    {
        private QuizPlayerController quiz;
        public QuizPlayScore(string score, QuizPlayerController q)
        {
            InitializeComponent();
            this.score.Text = score;
            SetQuiz(q);
            
        }

        public void SetQuiz(QuizPlayerController q)
        {
            this.quiz = q;
        }

        private void printQuizBtn_Click(object sender, EventArgs e)
        {
            quiz.PrintThisQuiz();
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            QuizPanel q = new QuizPanel(quiz);
            q.Dock = DockStyle.Fill;
            Controls.Add(q);
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            MultipleChoiceDataSetTableAdapters.QuizTableAdapter quizTableAdapter = new MultipleChoiceDataSetTableAdapters.QuizTableAdapter();
            int rating =(int)quizTableAdapter.ReturnRating();
            rating += 1;
            Quiz quiz = new Quiz();
            int qid =quiz.GetQuiz_id();
            int subjectId = (int)quizTableAdapter.ReturnSubjectOfQuiz();

            quizTableAdapter.UpdateRating(rating, qid, subjectId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MultipleChoiceDataSetTableAdapters.QuizTableAdapter quizTableAdapter = new MultipleChoiceDataSetTableAdapters.QuizTableAdapter();
            int rating = (int)quizTableAdapter.ReturnRating();
            rating -= 1;
            Quiz quiz = new Quiz();
            int qid = quiz.GetQuiz_id();
            int subjectId = (int)quizTableAdapter.ReturnSubjectOfQuiz();

            quizTableAdapter.UpdateRating(rating, qid, subjectId);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
