using WinFormUI.Utilities.Authentication;

namespace WinFormUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var result=AuthHelper.Login(usernameLbl.Text, passwordTxtBox.Text,out var message);
            if (result)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = AuthHelper.GetUserName();
        }
    }
}
