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
    public partial class ProfileNote : UserControl
    {
        public ProfileNote()
        {
            InitializeComponent();
        }

        public void SetData(string text, int number)
        {
            NoteLabel.Text = text;
            NoteBox.Text = number.ToString();
        }

    }
}
