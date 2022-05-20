namespace WinFormUI.UserControls
{
    partial class TransactionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionUserControl));
            this.odoTxt = new System.Windows.Forms.TextBox();
            this.maintainTxt = new System.Windows.Forms.TextBox();
            this.maintainValueTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastTimePicker = new System.Windows.Forms.TextBox();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // odoTxt
            // 
            this.odoTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.odoTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odoTxt.Enabled = false;
            this.odoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odoTxt.Location = new System.Drawing.Point(508, 14);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.ReadOnly = true;
            this.odoTxt.Size = new System.Drawing.Size(130, 28);
            this.odoTxt.TabIndex = 21;
            // 
            // maintainTxt
            // 
            this.maintainTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maintainTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maintainTxt.Enabled = false;
            this.maintainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainTxt.Location = new System.Drawing.Point(44, 13);
            this.maintainTxt.Name = "maintainTxt";
            this.maintainTxt.ReadOnly = true;
            this.maintainTxt.Size = new System.Drawing.Size(222, 28);
            this.maintainTxt.TabIndex = 28;
            // 
            // maintainValueTxt
            // 
            this.maintainValueTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maintainValueTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.maintainValueTxt.Enabled = false;
            this.maintainValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintainValueTxt.Location = new System.Drawing.Point(271, 14);
            this.maintainValueTxt.Name = "maintainValueTxt";
            this.maintainValueTxt.ReadOnly = true;
            this.maintainValueTxt.Size = new System.Drawing.Size(231, 28);
            this.maintainValueTxt.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 31;
            // 
            // lastTimePicker
            // 
            this.lastTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastTimePicker.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lastTimePicker.Enabled = false;
            this.lastTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastTimePicker.Location = new System.Drawing.Point(644, 14);
            this.lastTimePicker.Name = "lastTimePicker";
            this.lastTimePicker.ReadOnly = true;
            this.lastTimePicker.Size = new System.Drawing.Size(213, 28);
            this.lastTimePicker.TabIndex = 32;
            // 
            // noteTxt
            // 
            this.noteTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.noteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTxt.Enabled = false;
            this.noteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTxt.Location = new System.Drawing.Point(10, 60);
            this.noteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.noteTxt.Multiline = true;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.ReadOnly = true;
            this.noteTxt.Size = new System.Drawing.Size(869, 93);
            this.noteTxt.TabIndex = 33;
            this.noteTxt.TextChanged += new System.EventHandler(this.noteTxt_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.lastTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maintainValueTxt);
            this.Controls.Add(this.maintainTxt);
            this.Controls.Add(this.odoTxt);
            this.Name = "TransactionUserControl";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Size = new System.Drawing.Size(889, 159);
            this.Load += new System.EventHandler(this.TransactionUserControl_Load);
            this.SizeChanged += new System.EventHandler(this.TransactionUserControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox odoTxt;
        private TextBox maintainTxt;
        private TextBox maintainValueTxt;
        private Label label1;
        private TextBox lastTimePicker;
        private TextBox noteTxt;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
