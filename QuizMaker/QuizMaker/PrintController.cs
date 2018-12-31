using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using QuizMaker.PrintQuizTemplates;

namespace QuizMaker
{
    class PrintController : UserControl
    {
        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        FirstPage pannel = null;
        List<FirstPage> firstPage = new List<FirstPage>();
        PrintDialog p = new PrintDialog();
        DialogResult printed = DialogResult.No;
        List<Bitmap> temp;

        public PrintController()
        {
            
            printdoc1.PrintPage += new PrintPageEventHandler(printActualFile);

        }

        List<Bitmap> MemoryImage = new List<Bitmap>();
        public void GetPrintArea(List<FirstPage> pnl)
        {
            
            foreach (FirstPage f in pnl)
            {
                MemoryImage.Add(new Bitmap(f.Size.Width, f.Size.Height));
            
                Rectangle rect = new Rectangle(0, 0, f.Width, f.Height);
                f.DrawToBitmap(MemoryImage.ElementAt<Bitmap>(MemoryImage.Count - 1), new Rectangle(0, 0, f.Width, f.Height));
            }
        }
        
        
        void printActualFile(object sender, PrintPageEventArgs e)
        {
            
            if(temp.Count > 0)
            {
                Image img = temp.ElementAt<Bitmap>(0); // this is what I want to print
                Rectangle bounds = e.PageBounds;
                int mx = 30;
                int my = 30; // add borders
                int x = img.Width;
                int y = img.Height;
                int xp = bounds.Width * 9 / 10; // for some reason (I can't explain why)
                int yp = bounds.Height * 9 / 10; // 100% appears larger than the page...
                int xr, yr;
                        if (x > y)
                        {
                            xr = xp - mx;
                            yr = xr* y / x;
                        }
                        else
                        {
                            yr = yp - my;
                            xr = yr* x / y;
                        }
                Size size = new Size(xr, yr);
                Image copy = (Image)img.Clone();
                Rectangle pagearea = e.PageBounds;
                e.Graphics.DrawImage(copy, new Rectangle(new Point(mx, my), size));
                temp.RemoveAt(0);
            }
            e.HasMorePages = !(temp.Count == 0);
        }
        public void Print(List<FirstPage> pnl)
        {
            
            firstPage = pnl;
            pannel = pnl.ElementAt(0);
            GetPrintArea(pnl);
            temp = MemoryImage.ToList();
            previewdlg.Document = printdoc1;
            DialogResult result = PrintDialog();


        }
        public DialogResult PrintDialog()
        {
            previewdlg.Document = printdoc1;
            ToolStripButton b = new ToolStripButton();
            b.Text = "Print";
            b.Image = Properties.Resources.print;
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Click += printPreview_PrintClick;
            ((ToolStrip)(previewdlg.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(previewdlg.Controls[1])).Items.Insert(0, b);
            return previewdlg.ShowDialog();
        }
        private void printPreview_PrintClick(Object sender, EventArgs e)
        {
            temp = MemoryImage.ToList();
            p.Document = printdoc1;
            p.AllowPrintToFile = true;
            DialogResult result = p.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                printdoc1.Print();
                printed = DialogResult.OK;
            }
        }
        private void PrintDocument_BeginPrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
        public bool isPrinted()
        {
            return printed.Equals(DialogResult.OK) ? true : false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PrintController
            // 
            this.Name = "PrintController";
            this.ResumeLayout(false);

        }
    }
}
