using WinFormUI.UIElements;

namespace WinFormUI.Forms
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plateCmb = new System.Windows.Forms.ComboBox();
            this.customerPhoneTxt = new System.Windows.Forms.TextBox();
            this.carTypesCmb = new System.Windows.Forms.ComboBox();
            this.yearsCmb = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plakaLbl = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.noteTxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.odoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maintainCmb = new System.Windows.Forms.ComboBox();
            this.maintainValueCmb = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plateCmb
            // 
            this.plateCmb.FormattingEnabled = true;
            this.plateCmb.Location = new System.Drawing.Point(88, 49);
            this.plateCmb.Name = "plateCmb";
            this.plateCmb.Size = new System.Drawing.Size(173, 28);
            this.plateCmb.TabIndex = 0;
            this.plateCmb.TextChanged += new System.EventHandler(this.plateCmb_TextChanged);
            this.plateCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plateCmb_KeyPress);
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Location = new System.Drawing.Point(727, 49);
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(182, 27);
            this.customerPhoneTxt.TabIndex = 3;
            // 
            // carTypesCmb
            // 
            this.carTypesCmb.FormattingEnabled = true;
            this.carTypesCmb.Location = new System.Drawing.Point(284, 48);
            this.carTypesCmb.Name = "carTypesCmb";
            this.carTypesCmb.Size = new System.Drawing.Size(173, 28);
            this.carTypesCmb.TabIndex = 1;
            this.carTypesCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // yearsCmb
            // 
            this.yearsCmb.FormattingEnabled = true;
            this.yearsCmb.Location = new System.Drawing.Point(485, 49);
            this.yearsCmb.Name = "yearsCmb";
            this.yearsCmb.Size = new System.Drawing.Size(206, 28);
            this.yearsCmb.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.plakaLbl);
            this.splitContainer1.Panel1.Controls.Add(this.plateCmb);
            this.splitContainer1.Panel1.Controls.Add(this.yearsCmb);
            this.splitContainer1.Panel1.Controls.Add(this.customerPhoneTxt);
            this.splitContainer1.Panel1.Controls.Add(this.carTypesCmb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1663, 483);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç tipi";
            // 
            // plakaLbl
            // 
            this.plakaLbl.AutoSize = true;
            this.plakaLbl.Location = new System.Drawing.Point(88, 9);
            this.plakaLbl.Name = "plakaLbl";
            this.plakaLbl.Size = new System.Drawing.Size(44, 20);
            this.plakaLbl.TabIndex = 0;
            this.plakaLbl.Text = "Plaka";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.noteTxt);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel1.Controls.Add(this.odoTxt);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.maintainCmb);
            this.splitContainer2.Panel1.Controls.Add(this.maintainValueCmb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1663, 381);
            this.splitContainer2.SplitterDistance = 93;
            this.splitContainer2.TabIndex = 0;
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(977, 46);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(557, 44);
            this.noteTxt.TabIndex = 18;
            this.noteTxt.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1557, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.MaxDate = DateTime.Now;
            // 
            // odoTxt
            // 
            this.odoTxt.Location = new System.Drawing.Point(485, 48);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.Size = new System.Drawing.Size(182, 27);
            this.odoTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Odo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Markası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bakım Tipi";
            // 
            // maintainCmb
            // 
            this.maintainCmb.FormattingEnabled = true;
            this.maintainCmb.Location = new System.Drawing.Point(88, 47);
            this.maintainCmb.Name = "maintainCmb";
            this.maintainCmb.Size = new System.Drawing.Size(173, 28);
            this.maintainCmb.TabIndex = 4;
            this.maintainCmb.TextChanged += new System.EventHandler(this.maintainCmb_TextChanged);
            // 
            // maintainValueCmb
            // 
            this.maintainValueCmb.FormattingEnabled = true;
            this.maintainValueCmb.Location = new System.Drawing.Point(284, 46);
            this.maintainValueCmb.Name = "maintainValueCmb";
            this.maintainValueCmb.Size = new System.Drawing.Size(173, 28);
            this.maintainValueCmb.TabIndex = 5;
            this.maintainValueCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1663, 284);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Entities.Concrete.Transaction);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox plateCmb;
        private TextBox customerPhoneTxt;
        private ComboBox carTypesCmb;
        private ComboBox yearsCmb;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label plakaLbl;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox odoTxt;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox maintainCmb;
        private ComboBox maintainValueCmb;
        private RichTextBox noteTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource transactionBindingSource;
    }
}