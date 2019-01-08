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
    public partial class Feedback : UserControl
    {
        public Feedback()
        {
            InitializeComponent();
        }

        //vale to data sta components
        public void SetData(int userID,string feedback,bool rate)
        {
            userIDBox.Text = userID.ToString();
            feedbackBox.Text = feedback;

            if (rate)
                rateCheckbox.Checked = true;
            else
                rateCheckbox.Checked = false;
        }

        //delete checkbox
        public void SetDeleteCheckbox(bool check)
        {
            deleteCheckbox.Checked = check;
        }
        public bool GetDeleteCheckbox()
        {
            if (deleteCheckbox.Checked)
                return true;
            else
                return false;
        }

        //update checkbox
        public void SetRateCheckbox(bool check)
        {
            rateCheckbox.Checked = check;
        }
        public bool GetRateCheckbox()
        {
            if (deleteCheckbox.Checked)
                return true;
            else
                return false;
        }

    }
}
