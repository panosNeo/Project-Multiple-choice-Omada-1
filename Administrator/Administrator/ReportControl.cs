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
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
            loadReports();
        }
        private void loadReports()
        {
            Report temp;
            for(int i = 0; i < 11; i++)
            {
                temp = new Report();
                if (i % 2 == 0)
                    temp.BackColor = Color.White;
                else
                    temp.BackColor = Color.FromName("GradientActiveCaption");
                temp.Click += new EventHandler(clicked);
                showReportsPanel.Controls.Add(temp);
            }
        }
        private void clicked(object sender, EventArgs e) {
            MessageBox.Show("You clicked me");
        }

        private void deleteReportButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void deleteReportButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromName("GradientActiveCaption");
        }
    }
}
