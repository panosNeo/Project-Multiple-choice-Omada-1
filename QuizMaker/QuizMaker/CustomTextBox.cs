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
    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            AutoSize = false; //Allows you to change height to have bottom padding
            Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.White });
        }
        private void redrawText()
        {
            using (Graphics graphics = this.CreateGraphics())
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
                graphics.DrawString(this.Text, this.Font, brush, 1, 1); //play around with how you draw string more to suit your original
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            redrawText();
        }
    }
}
