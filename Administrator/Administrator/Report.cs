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
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        //perase to data sta fields
        public void SetData(int userID,string report,int quizID)
        {
            userIDBox.Text = userID.ToString();
            reportBox.Text = report;
            quizIDBox.Text = quizID.ToString();
        }

        //delete checkbox
        public void SetDeleteCheckbox(bool check)
        {
            deleteCheckbox.Checked = check;
        }
        //des an einai checked h oxi to delete checkbox
        public bool GetDeleteCheckbox()
        {
            if (deleteCheckbox.Checked)
                return true;
            else
                return false;
        }
    }
}
