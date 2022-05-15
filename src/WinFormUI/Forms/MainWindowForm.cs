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
