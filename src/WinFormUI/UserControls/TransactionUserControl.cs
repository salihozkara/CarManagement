using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.UserControls
{
    public partial class TransactionUserControl : UserControl
    {
        public TransactionUserControl(Transaction transaction)
        {
            InitializeComponent();
            noteTxt.AutoSize = true;
            maintainTxt.Text = transaction.Maintain.MaintainType.Name;
            maintainValueTxt.Text = transaction.Maintain.Value;
            odoTxt.Text = transaction.LastOdo;
            lastTimePicker.Text = transaction.LastDate.ToLongDateString();
            noteTxt.Text = transaction.Note;
        }
        public void Print()
        {
            ////CaptureScreen();
            //this.Size = new Size(800,this.Height);

            // printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 900, 700);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.Width, this.Height);
            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = 5;
            printDocument1.DefaultPageSettings.Landscape = false;
            //printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            PrintToGraphics(e.Graphics, e.MarginBounds);
        }
        public void PrintToGraphics(Graphics graphics, Rectangle bounds)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            Rectangle target = new Rectangle(0, 0, bounds.Width, bounds.Height);
            double xScale = (double)bitmap.Width / bounds.Width;
            double yScale = (double)bitmap.Height / bounds.Height;
            if (xScale < yScale)
                target.Width = (int)(xScale * target.Width / yScale);
            else
                target.Height = (int)(yScale * target.Height / xScale);
            graphics.PageUnit = GraphicsUnit.Display;
            graphics.DrawImage(bitmap, target);
        }
       
        private void TransactionUserControl_Load(object sender, EventArgs e)
        {
            //noteTxt.Size = new Size(noteTxt.Size.Width, noteTxt.Lines.Length * noteTxt.Font.Height);
            //this.Size = new Size(this.Size.Width, noteTxt.Size.Height + noteTxt.Location.Y + 20 + 20);
        }

        private void noteTxt_TextChanged(object sender, EventArgs e)
        {
            //noteTxt.Size = new Size(noteTxt.Size.Width, noteTxt.Lines.Length * noteTxt.Font.Height);
            //this.Size = new Size(this.Size.Width, noteTxt.Size.Height + noteTxt.Location.Y + 20 + 20);
        }

        private void TransactionUserControl_SizeChanged(object sender, EventArgs e)
        {
            //noteTxt.Size = new Size(noteTxt.Size.Width, noteTxt.Lines.Length * noteTxt.Font.Height);
            this.Size = new Size(this.Size.Width, noteTxt.Size.Height + noteTxt.Location.Y + 20 + 20);
        }
    }
}
