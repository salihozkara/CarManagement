using Business.Abstract;
using Entities.Concrete;
using System.Linq;
using WinFormUI.UserControls;
using WinFormUI.Utilities.Authentication;

namespace WinFormUI.Forms
{
    public partial class MainWindowForm : Form
    {
        private IMaintainService _maintainService;
        private IMaintainTypeService _maintainTypeService;
        private ICarService _carService;
        private ICarTypeService _carTypeService;
        private ITransactionService _transactionService;
        public MainWindowForm(IMaintainService maintainService, IMaintainTypeService maintainTypeService, ICarService carService, ICarTypeService carTypeService, ITransactionService transactionService)
        {

            _maintainService = maintainService;
            _maintainTypeService = maintainTypeService;
            _carService = carService;
            _carTypeService = carTypeService;
            _transactionService = transactionService;

            InitializeComponent();

            headerPanelLocationChange();
            splitContainerBody.Panel1MinSize = headerPanel.Height;
            a(splitContainerBody.Panel1);
            splitContainerHeader.Panel1MinSize = headerPanel.Height;
        }
        private void headerPanelLocationChange()
        {
            headerPanel.Location = new Point(
   splitContainerHeader.Panel1.Width / 2 - headerPanel.Size.Width / 2,
   splitContainerHeader.Panel1.Height / 2 - headerPanel.Size.Height / 2);
            headerPanel.Anchor = AnchorStyles.None;
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

            yearsCmb.DataSource = Enumerable.Range(1985, DateTime.Today.Year - 1985).ToList().ConvertAll(x => x.ToString());
            yearsCmb.SelectedItem = null;
            plateCmbFill();
            maintainCmbFill();
        }
        private void maintainCmbFill()
        {
            maintainTypeCmb.DataSource = _maintainTypeService.GetMaintainAsync().Result;

            maintainTypeCmb.SelectedItem = null;
        }
        
        private void plateCmbFill()
        {

            plateCmb.DataSource = _carService.GetCarAsync().Result;

            carTypesCmb.DataSource = _carTypeService.GetCarTypeAsync().Result;

            plateCmb.SelectedItem = null;
        }




        private void transactionFill()
        {
            
            flowLayoutPanelTransaction.Controls.Clear();
            foreach (var transaction in _transactionService.GetTransactionByCarIdAsync((int)plateCmb.SelectedValue).Result.OrderByDescending(x => x.LastDate))
            
            {
                addTransaction(transaction);
            }

        }
        private void addTransaction(Transaction transaction)
        {
            var control = new TransactionUserControl(transaction);
            control.Size = new Size(flowLayoutPanelTransaction.Size.Width - 30, control.Height);
            flowLayoutPanelTransaction.Controls.Add(control);

        }
        private void plateCmb_TextChanged(object sender, EventArgs e)
        {
            var car = plateCmb.Items.Cast<Car>().FirstOrDefault(c => c.Plate == plateCmb.Text);
            if (car != null)
            {
                plateCmb.SelectedItem = car;
                plateCmb.SelectionStart = plateCmb.Text.Length;
                carTypesCmb.SelectedItem = car.CarType;
                carTypesCmb.Enabled = false;
                yearsCmb.SelectedItem = car.Year;
                yearsCmb.Enabled = false;
                customerPhoneTxt.Text = car.CustomerPhone;
                transactionFill();
            }
            else
            {
                plateCmb.SelectedItem = null;
                carTypesCmb.SelectedItem = null;
                carTypesCmb.Enabled = true;
                yearsCmb.SelectedItem = null;
                yearsCmb.Enabled = true;
                customerPhoneTxt.Text = string.Empty;
                flowLayoutPanelTransaction.Controls.Clear();
            }

        }


        private void plateCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        private void cmb_TextChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (sender as ComboBox)!;
            var obj = cmb.Items.OfType<object>().FirstOrDefault(c => c.GetType().GetProperty(cmb.DisplayMember)?.GetValue(c)?.ToString() == cmb.Text);
            if (obj != null)
            {
                cmb.SelectedItem = obj;
                cmb.SelectionStart = Text.Length;
            }
            else
            {
                cmb.SelectedItem = null;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (plateCmb.SelectedItem is not Car car)
            {
                if (carTypesCmb.SelectedItem is not CarType carType)
                {
                    carType = new CarType() { Name = carTypesCmb.Text };
                    _carTypeService.AddCarTypeAsync(carType).Wait();
                }
                car = new Car
                {
                    CarType = carType,
                    Plate = plateCmb.Text,
                    Year = yearsCmb.SelectedItem as string ?? yearsCmb.Text,
                    CustomerPhone = customerPhoneTxt.Text,
                };

                _carService.AddCarAsync(car).Wait();
            }
            if (maintainTypeCmb.SelectedItem is not MaintainType maintainType)
            {
                maintainType = new MaintainType() { Name = maintainTypeCmb.Text };
                _maintainTypeService.AddMaintainType(maintainType).Wait();
            }
            if (maintainValueCmb.SelectedItem is not Maintain maintain)
            {
                maintain = new Maintain() { MaintainType = maintainType, Value = maintainValueCmb.Text };
                _maintainService.AddMaintainAsync(maintain).Wait();
            }
            var transaction = new Transaction
            {
                Car = car,
                Maintain = maintain,
                LastOdo = odoTxt.Text,
                Note = noteTxt.Text,
                LastDate = DateTime.Now,
            };



            _transactionService.AddTransactionAsync(transaction).Wait();
            FormClear();
            var card = new TransactionUserControl(transaction);
            Bitmap bitmap = new Bitmap(card.Width, card.Height);
            card.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            //var formCard = new FormCard(bitmap);
            //formCard.ShowDialog();
            card.Print();


        }
        private void FormClear()
        {
            plateCmbFill();
            maintainCmbFill();
            plateCmb.SelectedItem = null;
            carTypesCmb.SelectedItem = null;
            carTypesCmb.Text = string.Empty;
            yearsCmb.SelectedItem = null;
            yearsCmb.Text = string.Empty;
            customerPhoneTxt.Text = string.Empty;
            maintainTypeCmb.SelectedItem = null;
            maintainTypeCmb.Text = string.Empty;
            maintainValueCmb.SelectedItem = null;
            maintainValueCmb.Text = string.Empty;
            odoTxt.Text = string.Empty;
            noteTxt.Text = string.Empty;
            plateCmb.Focus();
        }
        private void maintainCmb_TextChanged(object sender, EventArgs e)
        {
            var obj = maintainTypeCmb.Items.OfType<MaintainType>().FirstOrDefault(c => c.Name.ToLower() == maintainTypeCmb.Text.ToLower());
            if (obj != null)
            {
                maintainTypeCmb.SelectedItem = obj;
                maintainTypeCmb.SelectionStart = Text.Length;
                maintainValueCmb.DataSource = _maintainService.GetMaintainsByMaintainTypeIdAsync(obj.Id).Result;
            }
            else
            {
                maintainValueCmb.DataSource = null;
                maintainTypeCmb.SelectedItem = null;
            }
        }

        private void MainWindowForm_SizeChanged(object sender, EventArgs e)
        {
            splitContainerBody.SplitterDistance = maintainFormPanel.Size.Height;
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            headerPanelLocationChange();
        }

        private void splitContainer2_Panel1_SizeChanged(object sender, EventArgs e)
        {
            a(sender as Panel);
        }
        private void a(Panel panel)
        {
            maintainFormPanel.Location = new Point(
panel.Width / 2 - maintainFormPanel.Size.Width / 2,
panel.Height / 2 - maintainFormPanel.Size.Height / 2);
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanelTransaction.Controls)
            {
                control.Size = new Size(flowLayoutPanelTransaction.Width-30, control.Height);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void MainWindowForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
