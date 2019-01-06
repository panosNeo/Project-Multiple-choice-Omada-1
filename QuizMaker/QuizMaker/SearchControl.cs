using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class SearchControl : UserControl
    {
        private MultipleChoiceDataSetTableAdapters.SubjectTableAdapter s;
        public SearchControl()
        {
            
            InitializeComponent();
            SearchHandler.SearchController.SetSubjects();
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

        
    }
}
