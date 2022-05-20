using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.UserControls
{
    public partial class TransactionUserControl : UserControl
    {
        public TransactionUserControl()
        {
            InitializeComponent();
            noteTxt.AutoSize = true;
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
