using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Utilities.Authentication;

namespace WinFormUI.Forms
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            if (AuthHelper.IsAuthenticated())
            {
                this.Text = "Welcome " + AuthHelper.GetUserName();
            }
            else
            {
                this.Hide();
                var result = new LoginForm().ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Show();
                    this.Text = "Welcome " + AuthHelper.GetUserName();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
