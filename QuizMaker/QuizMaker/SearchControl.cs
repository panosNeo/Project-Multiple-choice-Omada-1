using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.QuizHandler;
using QuizMaker.SearchHandler;

namespace QuizMaker
{
    public partial class SearchControl : UserControl
    {
        private string selectedTreeNodeID = "0";
        private MultipleChoiceDataSetTableAdapters.SubjectTableAdapter s;
        public SearchControl()
        {
            
            InitializeComponent();
            //SearchHandler.SearchController.SetSubjects();
            setElementAtTreeView();
        }

        private void SearchControl_SizeChanged(object sender, EventArgs e)
        {
            resultsPanel.Size = new Size(this.Size.Width - 100, this.Size.Height - 160);
        }

        private void setElementAtTreeView()
        {
            tagTreeView.Nodes.Clear();
            tagTreeView.Nodes.Add(SearchHandler.SearchController.GetSubjects());
        }

        private void tagTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(((TreeView)sender).SelectedNode.Tag != null)
                selectedTreeNodeID = ((TreeView)sender).SelectedNode.Tag.ToString();
        }

        private void searchTagBtn_Click(object sender, EventArgs e)
        {
            resultsPanel.Controls.Clear();
            List<Quiz> quizzes = SearchHandler.SearchController.GetQuizDataFromSubject(Convert.ToInt32(selectedTreeNodeID));
            ResultQuizControl temp;
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            int counter = 0;
            foreach (Quiz q in quizzes)
            {
                temp = new ResultQuizControl(q)
                {
                    Dock = DockStyle.Top
                };
                if (counter % 2 == 0)
                {
                    temp.SetColor(Color.FromArgb(37, 46, 69));
                }
                counter++;
                temp.SetQuizNumberOfQuestions(q.getQuestions().Count);
                temp.SetQuizTitle(q.GetQuizTitle());
                temp.SetQuizSubject(subject.GetSubjectName(q.GetSubject_id()));
                temp.Click += new EventHandler(ResultQuiz_Click);
                resultsPanel.Controls.Add(temp);
                if (counter == 0)
                {
                    Label l = new Label()
                    {
                        Text = "Found 0 Quizes"
                    };
                    l.ForeColor = Color.White;
                    resultsPanel.Controls.Add(l);
                }
            }
        }
        private void ResultQuiz_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            QuizPanel p = new QuizPanel(new QuizPlayerController(((ResultQuizControl)sender).GetQuiz()));
            p.Dock = DockStyle.Fill;
            Controls.Add(p);
        }

        private void searchTextBtn_Click(object sender, EventArgs e)
        {
            resultsPanel.Controls.Clear();
            int counter = 0;
            LuceneSearcher searcher = new LuceneSearcher("./index");
            if (!String.IsNullOrWhiteSpace(searchText.Text))
            {
                List<RetreivedQuiz> quizes = searcher.GetQuizzes(searchText.Text);
                ResultQuizControl temp;
                
                foreach (RetreivedQuiz q in quizes)
                {
                    temp = new ResultQuizControl(SearchController.GetQuizByID(q.quizID))
                    {
                        Dock = DockStyle.Top
                    };
                    if (counter % 2 == 0)
                    {
                        temp.SetColor(Color.FromArgb(37, 46, 69));
                    }
                    counter++;
                    temp.SetQuizNumberOfQuestions(q.questionsCount);
                    temp.SetQuizTitle(q.quizName);
                    temp.SetQuizSubject(q.quizSubject);
                    temp.Click += new EventHandler(ResultQuiz_Click);
                    resultsPanel.Controls.Add(temp);
                }
            }
            if (counter == 0)
            {
                Label l = new Label()
                {
                    Text = "Found 0 Quizes"
                };
                l.ForeColor = Color.White;
                resultsPanel.Controls.Add(l);
            }
        }
    }
}
