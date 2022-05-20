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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            AuthHelper.ChangePassword(textBoxOldPassword.Text, textBoxNewPassword.Text, out string errorMessage);
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                MessageBox.Show("Password changed successfully");
                this.Close();
            }
        }
    }
}
