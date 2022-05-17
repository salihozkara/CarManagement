using Entities.Concrete;
using System.Linq;
using WinFormUI.UserControls;
using WinFormUI.Utilities.Authentication;

namespace WinFormUI.Forms
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
            headerPanelLocationChange();
            a(splitContainer2.Panel1);
            splitContainer1.Panel1MinSize = headerPanel.Height;
        }
        private void headerPanelLocationChange()
        {
            headerPanel.Location = new Point(
   splitContainer1.Panel1.Width / 2 - headerPanel.Size.Width / 2,
   splitContainer1.Panel1.Height / 2 - headerPanel.Size.Height / 2);
            headerPanel.Anchor = AnchorStyles.None;
        }
        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //var result = new LoginForm().ShowDialog();
            //if (result == DialogResult.Yes)
            //{
            //    this.Show();
            //    this.Text = "Welcome " + AuthHelper.GetUserName();
            //}
            //else
            //{
            //    Application.Exit();
            //}

            yearsCmb.DataSource = Enumerable.Range(1985, DateTime.Today.Year - 1985).ToList().ConvertAll(x => x.ToString());
            yearsCmb.SelectedItem = null;
            plateCmbFill();
            maintainCmbFill();


            transactionFill();
        }
        private void maintainCmbFill()
        {
            maintainTypes.Add(new MaintainType() { Name = "Oil Change" });
            maintainTypes.Add(new MaintainType() { Name = "Tire Rotation" });
            maintainTypes.Add(new MaintainType() { Name = "Transmission Flush" });
            maintainTypes.Add(new MaintainType() { Name = "Brake Flush" });
            maintainTypes.Add(new MaintainType() { Name = "Air Filter Change" });

            maintains.Add(new Maintain() { Value = "Castrol Magnetic", MaintainType = maintainTypes[0] });
            maintains.Add(new Maintain() { Value = "Castrol Non-Magnetic", MaintainType = maintainTypes[0] });
            maintains.Add(new Maintain() { Value = "Michelin", MaintainType = maintainTypes[1] });
            maintains.Add(new Maintain() { Value = "Michelin Non-Magnetic", MaintainType = maintainTypes[1] });
            maintains.Add(new Maintain() { Value = "Michelin Non-Magnetic", MaintainType = maintainTypes[2] });

            maintainCmb.DataSource = maintainTypes;

            maintainCmb.DisplayMember = "Name";
            maintainCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            maintainCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            maintainCmb.SelectedItem = null;

            maintainValueCmb.DisplayMember = "Value";
            maintainValueCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            maintainValueCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        List<Maintain> maintains = new List<Maintain>();
        List<MaintainType> maintainTypes = new List<MaintainType>();
        List<Car> cars = new();
        List<CarType> carTypes = new();
        private void plateCmbFill()
        {

            //carTypes.Add(new CarType());
            carTypes.Add(new CarType { Name = "Sedan" });
            carTypes.Add(new CarType { Name = "Hatchback" });
            carTypes.Add(new CarType { Name = "Coupe" });
            carTypes.Add(new CarType { Name = "SUV" });
            carTypes.Add(new CarType { Name = "Pickup" });
            carTypes.Add(new CarType { Name = "Van" });

            //cars.Add(new Car() { CarType = carTypes[0] });
            cars.Add(new Car() { Plate = "AA-123-AA", CarType = carTypes[4], Year = "2019" });
            cars.Add(new Car() { Plate = "BB-123-BB", CarType = carTypes[1], Year = "2011" });
            cars.Add(new Car() { Plate = "CC-123-CC", CarType = carTypes[2], Year = "2018" });
            cars.Add(new Car() { Plate = "DD-123-DD", CarType = carTypes[3], Year = "2017" });


            plateCmb.DataSource = new BindingSource(cars, null);
            plateCmb.DisplayMember = "Plate";
            plateCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            plateCmb.AutoCompleteSource = AutoCompleteSource.ListItems;



            carTypesCmb.DataSource = new BindingSource(carTypes, null);

            carTypesCmb.DisplayMember = "Name";






            plateCmb.SelectedItem = null;

            carTypesCmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            carTypesCmb.AutoCompleteSource = AutoCompleteSource.ListItems;

            // yearTxt.DataBindings.Add("Text", plateCmb, "SelectedItem.Year");

        }




        private void transactionFill()
        {
            var transactions = new List<Transaction>();
            transactions.Add(new Transaction() { LastDate = DateTime.Now, Car = cars[0], Maintain = maintains[0] });
            transactions.Add(new Transaction() { LastDate = DateTime.Now, Car = cars[0], Maintain = maintains[1] });
            transactions.Add(new Transaction() { LastDate = DateTime.Now, Car = cars[0], Maintain = maintains[2] });


            foreach (var transaction in transactions)
            {
                addTransaction(transaction);
            }

        }
        private void addTransaction(Transaction transaction)
        {
            var control = new TransactionUserControl();
            control.Controls["maintainTxt"].Text = transaction.Maintain.MaintainType.Name;
            control.Controls["maintainValueTxt"].Text = transaction.Maintain.Value;
            control.Controls["odoTxt"].Text = transaction.LastOdo;
            control.Controls["lastTimePicker"].Text = transaction.LastDate.ToLongDateString();
            control.Controls["noteTxt"].Text = String.IsNullOrEmpty(transaction.Note) ? @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque maximus sagittis odio in vehicula. Proin nec arcu at nisi vehicula dignissim eu et orci. Nulla facilisi. Nam rhoncus, enim sit amet faucibus eleifend, mi velit pulvinar turpis, eget porttitor felis tortor nec magna. Maecenas id arcu luctus, consequat metus feugiat, luctus enim. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus iaculis suscipit ipsum. Maecenas erat odio, porttitor vitae convallis eget, iaculis vel orci. Cras aliquet quam vitae cursus facilisis. Fusce porttitor condimentum leo, posuere condimentum mauris tempus eu. Sed eu pulvinar lorem. Fusce luctus, ex ac feugiat commodo, purus neque pretium metus, ac volutpat nisl diam a ex.

Curabitur lacinia velit convallis, hendrerit felis at, iaculis mauris. Maecenas mattis dui vel magna aliquam lacinia. Suspendisse mollis sem dictum diam eleifend gravida. Etiam fermentum mauris non nisi laoreet, vitae pharetra ipsum pulvinar. Ut a malesuada diam. Fusce sit amet massa lobortis, euismod odio laoreet, tincidunt eros. Praesent nunc elit, lobortis nec sapien ac, tincidunt mollis lorem. Vestibulum id porttitor quam. Donec lacinia placerat neque a blandit. Maecenas consectetur mauris et urna blandit faucibus. Quisque rutrum leo interdum dolor pellentesque, sit amet aliquet justo condimentum. Curabitur nec augue fringilla, egestas mauris ac, eleifend nunc." : transaction.Note;
            control.TabIndex =(int)(DateTime.Now.Ticks- transaction.LastDate.Ticks);
            flowLayoutPanel1.Controls.Add(control);

        }
        private void plateCmb_TextChanged(object sender, EventArgs e)
        {
            var car = plateCmb.Items.Cast<Car>().FirstOrDefault(c => c.Plate == plateCmb.Text);
            if (car != null)
            {
                //var selectedCar = ((Car)plateCmb.SelectedItem);
                plateCmb.SelectedItem = car;
                plateCmb.SelectionStart = plateCmb.Text.Length;
                carTypesCmb.SelectedItem = car.CarType;
                carTypesCmb.Enabled = false;
                yearsCmb.SelectedItem = car.Year;
                yearsCmb.Enabled = false;
                customerPhoneTxt.Text = car.CustomerPhone;



            }
            else
            {
                plateCmb.SelectedItem = null;
                carTypesCmb.SelectedItem = null;
                carTypesCmb.Enabled = true;
                yearsCmb.SelectedItem = null;
                yearsCmb.Enabled = true;
                customerPhoneTxt.Text = string.Empty;
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
                car = new Car
                {
                    CarType = carTypesCmb.SelectedItem as CarType ?? new CarType() { Name = carTypesCmb.Text },
                    Plate = plateCmb.Text,
                    Year = yearsCmb.SelectedItem as string ?? yearsCmb.Text,
                    CustomerPhone = customerPhoneTxt.Text,
                };
            }
            var transaction = new Transaction
            {
                Car = car,
                Maintain = maintainValueCmb.SelectedItem as Maintain ?? new Maintain() { Value = maintainValueCmb.Text, MaintainType = maintainCmb.SelectedItem as MaintainType ?? new MaintainType() { Name = maintainCmb.Text } },
                LastOdo = odoTxt.Text,
                Note = noteTxt.Text,
                LastDate = DateTime.Now,
            };

            addTransaction(transaction);
            FormClear();
            //transactions.Add(transaction);
            //plateCmb.SelectedItem = null;
            //maintainValueCmb.SelectedItem = null;
            //maintainValueCmb.Text = string.Empty;
            //priceTxt.Text = string.Empty;
            //descriptionTxt.Text = string.Empty;
            //plateCmb.Focus();

        }
        private void FormClear()
        {
            plateCmb.SelectedItem = null;
            carTypesCmb.SelectedItem = null;
            carTypesCmb.Text = string.Empty;
            yearsCmb.SelectedItem = null;
            yearsCmb.Text = string.Empty;
            customerPhoneTxt.Text = string.Empty;
            maintainCmb.SelectedItem = null;
            maintainCmb.Text = string.Empty;
            maintainValueCmb.SelectedItem = null;
            maintainValueCmb.Text = string.Empty;
            odoTxt.Text = string.Empty;
            noteTxt.Text = string.Empty;
            plateCmb.Focus();
        }
        private void maintainCmb_TextChanged(object sender, EventArgs e)
        {
            var obj = maintainCmb.Items.OfType<MaintainType>().FirstOrDefault(c => c.Name.ToLower() == maintainCmb.Text.ToLower());
            if (obj != null)
            {
                maintainCmb.SelectedItem = obj;
                maintainCmb.SelectionStart = Text.Length;
                maintainValueCmb.DataSource = maintains.Where(m => m.MaintainType == maintainCmb.SelectedItem as MaintainType).ToList();

            }
            else
            {
                maintainCmb.SelectedItem = null;
                maintainValueCmb.DataSource = null;

            }
        }

        private void MainWindowForm_SizeChanged(object sender, EventArgs e)
        {

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
            maintainFormPanel.Anchor = AnchorStyles.None;
        }
    }
}
