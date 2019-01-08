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
        private string selectedTreeNodeID = "";
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
            

        }
    }
}
