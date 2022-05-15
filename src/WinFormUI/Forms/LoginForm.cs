using WinFormUI.Utilities.Authentication;

namespace WinFormUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result=AuthHelper.Login(textBox1.Text, textBox2.Text,out var message);
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
    }
}
