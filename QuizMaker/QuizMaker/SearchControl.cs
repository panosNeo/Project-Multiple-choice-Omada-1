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
            List<Quiz> quizzes = SearchHandler.SearchController.GetQuizDataFromSubject(Convert.ToInt32(selectedTreeNodeID));
            ResultQuizControl temp;
            foreach (Quiz q in quizzes)
            {
                temp = new ResultQuizControl(q)
                {
                    Dock = DockStyle.Top
                };
                temp.SetQuizNumberOfQuestions(q.getQuestions().Count);
                temp.SetQuizTitle(q.GetQuizTitle());
                temp.SetQuizSubject(q.GetSubject_id().ToString());
                temp.Click += new EventHandler(ResultQuiz_Click);
                resultsPanel.Controls.Add(temp);
            }
        }
        private void ResultQuiz_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            QuizPanel p = new QuizPanel(new QuizPlayerController(((ResultQuizControl)sender).GetQuiz()));
        }
    }
}
