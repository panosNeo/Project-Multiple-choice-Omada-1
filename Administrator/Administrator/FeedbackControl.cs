using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class FeedbackControl : UserControl
    {
        public FeedbackControl()
        {
            InitializeComponent();
        }

        private void FeedbackControl_Load(object sender, EventArgs e)
        {
            SearchFeedbacks();
        }


        private void SearchFeedbacks()
        {
            Feedback temp;
            for (int i = 0; i < 11; i++)
            {
                temp = new Feedback();
                if (i % 2 == 0)
                    temp.BackColor = Color.White;
                else
                    temp.BackColor = Color.FromName("GradientActiveCaption");
                temp.Click += new EventHandler(clicked);
                showFeedbacksPanel.Controls.Add(temp);
            }
        }

        private void clicked(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me");
        }

    }
}
