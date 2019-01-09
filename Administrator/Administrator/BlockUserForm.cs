using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class BlockUserForm : Form
    {
        public BlockUserForm()
        {
            InitializeComponent();
            blockBtn.DialogResult = DialogResult.OK;
            cancelBtn.DialogResult = DialogResult.Cancel;
            ReasonBox.Text = BlockData.reason;
            DaysBox.Text = BlockData.days.ToString();
        }

        private void blockBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(ReasonBox.Text) || String.IsNullOrWhiteSpace(DaysBox.Text))
            {
                errorLabel.Visible = true;
            }
            else if (!DaysBox.Text.All(char.IsDigit))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Use digits in the Days field";
            }
            else
            {
                BlockData.reason = ReasonBox.Text;
                BlockData.days = Convert.ToInt32(DaysBox.Text);
            }
        }
    }
}
