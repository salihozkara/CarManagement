using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.Forms
{
    public partial class FormCard : Form
    {
        public FormCard(Bitmap bitmap)
        {
            InitializeComponent();
            pictureBox1.Image = bitmap;
            this.Size = new Size(bitmap.Width, bitmap.Height);
        }
        //{
        ////    InitializeComponent();
        ////    transactionUserControl1.Controls["maintainTxt"].Text = transaction.Maintain.MaintainType.Name;
        ////    transactionUserControl1.Controls["maintainValueTxt"].Text = transaction.Maintain.Value;
        ////    transactionUserControl1.Controls["odoTxt"].Text = transaction.LastOdo;
        ////    transactionUserControl1.Controls["lastTimePicker"].Text = transaction.LastDate.ToLongDateString();
        ////    transactionUserControl1.Controls["noteTxt"].Text = transaction.Note;
        //}
        //Bitmap bitmap;
        public void PrintCard()
        {
            //var grp=transactionUserControl1.CreateGraphics();
            //bitmap = new Bitmap(transactionUserControl1.Width, transactionUserControl1.Height);
            //grp.DrawImage(bitmap, 0, 0);
            //bitmap.Save("C:\\Users\\" + Environment.UserName + "\\Desktop\\" + transactionUserControl1.Controls["maintainTxt"].Text + ".jpg");
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }
        private void FormCard_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
