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
            this.label8 = new System.Windows.Forms.Label();
            this.noteTxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.plateCmb.Font = new System.Drawing.Font("DroidSansMono Nerd Font Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plateCmb.FormattingEnabled = true;
            this.plateCmb.Location = new System.Drawing.Point(583, 54);
            this.plateCmb.Margin = new System.Windows.Forms.Padding(4);
            this.plateCmb.Name = "plateCmb";
            this.plateCmb.Size = new System.Drawing.Size(168, 34);
            this.plateCmb.TabIndex = 0;
            this.plateCmb.TextChanged += new System.EventHandler(this.plateCmb_TextChanged);
            this.plateCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plateCmb_KeyPress);
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerPhoneTxt.Location = new System.Drawing.Point(1181, 55);
            this.customerPhoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(226, 33);
            this.customerPhoneTxt.TabIndex = 3;
            // 
            // carTypesCmb
            // 
            this.carTypesCmb.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carTypesCmb.FormattingEnabled = true;
            this.carTypesCmb.Location = new System.Drawing.Point(798, 54);
            this.carTypesCmb.Margin = new System.Windows.Forms.Padding(4);
            this.carTypesCmb.Name = "carTypesCmb";
            this.carTypesCmb.Size = new System.Drawing.Size(168, 34);
            this.carTypesCmb.TabIndex = 1;
            this.carTypesCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // yearsCmb
            // 
            this.yearsCmb.DropDownHeight = 200;
            this.yearsCmb.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearsCmb.FormattingEnabled = true;
            this.yearsCmb.IntegralHeight = false;
            this.yearsCmb.Location = new System.Drawing.Point(1016, 54);
            this.yearsCmb.Margin = new System.Windows.Forms.Padding(4);
            this.yearsCmb.Name = "yearsCmb";
            this.yearsCmb.Size = new System.Drawing.Size(116, 34);
            this.yearsCmb.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1274, 728);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1232, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1043, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(809, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Tipi";
            // 
            // plakaLbl
            // 
            this.plakaLbl.AutoSize = true;
            this.plakaLbl.Font = new System.Drawing.Font("DroidSansMono Nerd Font Mono", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plakaLbl.Location = new System.Drawing.Point(623, 20);
            this.plakaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plakaLbl.Name = "plakaLbl";
            this.plakaLbl.Size = new System.Drawing.Size(93, 30);
            this.plakaLbl.TabIndex = 0;
            this.plakaLbl.Text = "Plaka";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, -1);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.noteTxt);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
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
            this.splitContainer2.Size = new System.Drawing.Size(1274, 609);
            this.splitContainer2.SplitterDistance = 480;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(87, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "Not";
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(87, 346);
            this.noteTxt.Margin = new System.Windows.Forms.Padding(4);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(302, 166);
            this.noteTxt.TabIndex = 18;
            this.noteTxt.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(257, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // odoTxt
            // 
            this.odoTxt.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odoTxt.Location = new System.Drawing.Point(87, 250);
            this.odoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.Size = new System.Drawing.Size(302, 33);
            this.odoTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1085, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Odo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(87, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Markası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bakım Tipi";
            // 
            // maintainCmb
            // 
            this.maintainCmb.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainCmb.FormattingEnabled = true;
            this.maintainCmb.Location = new System.Drawing.Point(87, 71);
            this.maintainCmb.Margin = new System.Windows.Forms.Padding(4);
            this.maintainCmb.Name = "maintainCmb";
            this.maintainCmb.Size = new System.Drawing.Size(302, 34);
            this.maintainCmb.TabIndex = 4;
            this.maintainCmb.TextChanged += new System.EventHandler(this.maintainCmb_TextChanged);
            // 
            // maintainValueCmb
            // 
            this.maintainValueCmb.Font = new System.Drawing.Font("DroidSansMono Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainValueCmb.FormattingEnabled = true;
            this.maintainValueCmb.Location = new System.Drawing.Point(87, 167);
            this.maintainValueCmb.Margin = new System.Windows.Forms.Padding(4);
            this.maintainValueCmb.Name = "maintainValueCmb";
            this.maintainValueCmb.Size = new System.Drawing.Size(302, 34);
            this.maintainValueCmb.TabIndex = 5;
            this.maintainValueCmb.TextChanged += new System.EventHandler(this.cmb_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 11);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 500, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 601);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Entities.Concrete.Transaction);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 728);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private TextBox odoTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox maintainCmb;
        private ComboBox maintainValueCmb;
        private RichTextBox noteTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource transactionBindingSource;
        private Label label8;
        private Label label1;
    }
}