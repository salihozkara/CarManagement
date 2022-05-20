

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
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plakaLbl = new System.Windows.Forms.Label();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
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
            this.flowLayoutPanelTransaction = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            this.maintainFormPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            // splitContainerHeader
            // 
            this.splitContainerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHeader.IsSplitterFixed = true;
            this.splitContainerHeader.Location = new System.Drawing.Point(0, 28);
            this.splitContainerHeader.Name = "splitContainerHeader";
            this.splitContainerHeader.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHeader.Panel1
            // 
            this.splitContainerHeader.Panel1.Controls.Add(this.headerPanel);
            this.splitContainerHeader.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainerHeader.Panel2
            // 
            this.splitContainerHeader.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerHeader.Size = new System.Drawing.Size(1019, 554);
            this.splitContainerHeader.SplitterDistance = 84;
            this.splitContainerHeader.TabIndex = 7;
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
            this.headerPanel.Location = new System.Drawing.Point(166, 1);
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
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.IsSplitterFixed = true;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            this.splitContainerBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.maintainFormPanel);
            this.splitContainerBody.Panel1.SizeChanged += new System.EventHandler(this.splitContainer2_Panel1_SizeChanged);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.flowLayoutPanelTransaction);
            this.splitContainerBody.Size = new System.Drawing.Size(1019, 466);
            this.splitContainerBody.SplitterDistance = 243;
            this.splitContainerBody.TabIndex = 0;
            // 
            // maintainFormPanel
            // 
            this.maintainFormPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maintainFormPanel.Controls.Add(this.label7);
            this.maintainFormPanel.Controls.Add(this.saveBtn);
            this.maintainFormPanel.Controls.Add(this.label8);
            this.maintainFormPanel.Controls.Add(this.maintainValueCmb);
            this.maintainFormPanel.Controls.Add(this.noteTxt);
            this.maintainFormPanel.Controls.Add(this.maintainTypeCmb);
            this.maintainFormPanel.Controls.Add(this.label6);
            this.maintainFormPanel.Controls.Add(this.odoTxt);
            this.maintainFormPanel.Controls.Add(this.label5);
            this.maintainFormPanel.Location = new System.Drawing.Point(12, 3);
            this.maintainFormPanel.Name = "maintainFormPanel";
            this.maintainFormPanel.Size = new System.Drawing.Size(995, 250);
            this.maintainFormPanel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bakım Tipi";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(855, 36);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 36);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 85);
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
            this.maintainValueCmb.Location = new System.Drawing.Point(282, 42);
            this.maintainValueCmb.Name = "maintainValueCmb";
            this.maintainValueCmb.Size = new System.Drawing.Size(242, 30);
            this.maintainValueCmb.TabIndex = 5;
            this.maintainValueCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(0, 114);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(984, 134);
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
            this.maintainTypeCmb.Location = new System.Drawing.Point(19, 42);
            this.maintainTypeCmb.Name = "maintainTypeCmb";
            this.maintainTypeCmb.Size = new System.Drawing.Size(242, 30);
            this.maintainTypeCmb.TabIndex = 4;
            this.maintainTypeCmb.TextChanged += new System.EventHandler(this.maintainCmb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(282, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Markası";
            // 
            // odoTxt
            // 
            this.odoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odoTxt.Location = new System.Drawing.Point(571, 44);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.Size = new System.Drawing.Size(242, 28);
            this.odoTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(571, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Odo";
            // 
            // flowLayoutPanelTransaction
            // 
            this.flowLayoutPanelTransaction.AutoScroll = true;
            this.flowLayoutPanelTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTransaction.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTransaction.Name = "flowLayoutPanelTransaction";
            this.flowLayoutPanelTransaction.Size = new System.Drawing.Size(1019, 219);
            this.flowLayoutPanelTransaction.TabIndex = 0;
            this.flowLayoutPanelTransaction.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 582);
            this.Controls.Add(this.splitContainerHeader);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1025, 540);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindowForm_SizeChanged);
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            this.maintainFormPanel.ResumeLayout(false);
            this.maintainFormPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox plateCmb;
        private TextBox customerPhoneTxt;
        private ComboBox carTypesCmb;
        private ComboBox yearsCmb;
        private SplitContainer splitContainerHeader;
        private SplitContainer splitContainerBody;
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
        private FlowLayoutPanel flowLayoutPanelTransaction;
        private Label label8;
        private Panel headerPanel;
        private Panel maintainFormPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}