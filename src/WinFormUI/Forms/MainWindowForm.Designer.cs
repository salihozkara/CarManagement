

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
            this.plateCmb = new System.Windows.Forms.ComboBox();
            this.customerPhoneTxt = new System.Windows.Forms.TextBox();
            this.carTypesCmb = new System.Windows.Forms.ComboBox();
            this.yearsCmb = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plakaLbl = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.maintainFormPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.maintainValueCmb = new System.Windows.Forms.ComboBox();
            this.noteTxt = new System.Windows.Forms.RichTextBox();
            this.maintainTypeCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.odoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.maintainFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateCmb
            // 
            this.plateCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.plateCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.plateCmb.DisplayMember = "Plate";
            this.plateCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plateCmb.FormattingEnabled = true;
            this.plateCmb.Location = new System.Drawing.Point(8, 33);
            this.plateCmb.Name = "plateCmb";
            this.plateCmb.Size = new System.Drawing.Size(135, 30);
            this.plateCmb.TabIndex = 0;
            this.plateCmb.ValueMember = "Id";
            this.plateCmb.TextChanged += new System.EventHandler(this.plateCmb_TextChanged);
            this.plateCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plateCmb_KeyPress);
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerPhoneTxt.Location = new System.Drawing.Point(487, 34);
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(182, 28);
            this.customerPhoneTxt.TabIndex = 3;
            // 
            // carTypesCmb
            // 
            this.carTypesCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.carTypesCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.carTypesCmb.DisplayMember = "Name";
            this.carTypesCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carTypesCmb.FormattingEnabled = true;
            this.carTypesCmb.Location = new System.Drawing.Point(180, 33);
            this.carTypesCmb.Name = "carTypesCmb";
            this.carTypesCmb.Size = new System.Drawing.Size(135, 30);
            this.carTypesCmb.TabIndex = 1;
            this.carTypesCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // yearsCmb
            // 
            this.yearsCmb.DropDownHeight = 200;
            this.yearsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearsCmb.FormattingEnabled = true;
            this.yearsCmb.IntegralHeight = false;
            this.yearsCmb.Location = new System.Drawing.Point(355, 33);
            this.yearsCmb.Name = "yearsCmb";
            this.yearsCmb.Size = new System.Drawing.Size(94, 30);
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
            this.splitContainer1.Panel1.Controls.Add(this.headerPanel);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1019, 582);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 7;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerPanel.Controls.Add(this.plateCmb);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.carTypesCmb);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.customerPhoneTxt);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.yearsCmb);
            this.headerPanel.Controls.Add(this.plakaLbl);
            this.headerPanel.Location = new System.Drawing.Point(166, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(671, 68);
            this.headerPanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(528, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(376, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(189, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Tipi";
            // 
            // plakaLbl
            // 
            this.plakaLbl.AutoSize = true;
            this.plakaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plakaLbl.Location = new System.Drawing.Point(40, 6);
            this.plakaLbl.Name = "plakaLbl";
            this.plakaLbl.Size = new System.Drawing.Size(67, 26);
            this.plakaLbl.TabIndex = 0;
            this.plakaLbl.Text = "Plaka";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.maintainFormPanel);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.SizeChanged += new System.EventHandler(this.splitContainer2_Panel1_SizeChanged);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.splitContainer2.Size = new System.Drawing.Size(1019, 489);
            this.splitContainer2.SplitterDistance = 445;
            this.splitContainer2.TabIndex = 0;
            // 
            // maintainFormPanel
            // 
            this.maintainFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintainFormPanel.Controls.Add(this.label7);
            this.maintainFormPanel.Controls.Add(this.saveBtn);
            this.maintainFormPanel.Controls.Add(this.label8);
            this.maintainFormPanel.Controls.Add(this.maintainValueCmb);
            this.maintainFormPanel.Controls.Add(this.noteTxt);
            this.maintainFormPanel.Controls.Add(this.maintainTypeCmb);
            this.maintainFormPanel.Controls.Add(this.label6);
            this.maintainFormPanel.Controls.Add(this.odoTxt);
            this.maintainFormPanel.Controls.Add(this.label5);
            this.maintainFormPanel.Location = new System.Drawing.Point(98, 16);
            this.maintainFormPanel.Name = "maintainFormPanel";
            this.maintainFormPanel.Size = new System.Drawing.Size(256, 461);
            this.maintainFormPanel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bakım Tipi";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(139, 419);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 40);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Not";
            // 
            // maintainValueCmb
            // 
            this.maintainValueCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.maintainValueCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.maintainValueCmb.DisplayMember = "Value";
            this.maintainValueCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainValueCmb.FormattingEnabled = true;
            this.maintainValueCmb.Location = new System.Drawing.Point(3, 125);
            this.maintainValueCmb.Name = "maintainValueCmb";
            this.maintainValueCmb.Size = new System.Drawing.Size(242, 30);
            this.maintainValueCmb.TabIndex = 5;
            //this.maintainValueCmb.ValueMember = "Id";
            this.maintainValueCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(3, 268);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(242, 134);
            this.noteTxt.TabIndex = 7;
            this.noteTxt.Text = "";
            // 
            // maintainTypeCmb
            // 
            this.maintainTypeCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.maintainTypeCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.maintainTypeCmb.DisplayMember = "Name";
            this.maintainTypeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainTypeCmb.FormattingEnabled = true;
            this.maintainTypeCmb.Location = new System.Drawing.Point(3, 48);
            this.maintainTypeCmb.Name = "maintainTypeCmb";
            this.maintainTypeCmb.Size = new System.Drawing.Size(242, 30);
            this.maintainTypeCmb.TabIndex = 4;
            this.maintainTypeCmb.TextChanged += new System.EventHandler(this.maintainCmb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Markası";
            // 
            // odoTxt
            // 
            this.odoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odoTxt.Location = new System.Drawing.Point(3, 191);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.Size = new System.Drawing.Size(242, 28);
            this.odoTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Odo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(868, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tarih";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 489);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 582);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindowForm_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.maintainFormPanel.ResumeLayout(false);
            this.maintainFormPanel.PerformLayout();
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
        private Button saveBtn;
        private TextBox odoTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox maintainTypeCmb;
        private ComboBox maintainValueCmb;
        private RichTextBox noteTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label1;
        private Panel headerPanel;
        private Panel maintainFormPanel;
    }
}