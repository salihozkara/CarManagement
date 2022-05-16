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
            this.noteTxt = new System.Windows.Forms.RichTextBox();
            this.lastTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odoTxt = new System.Windows.Forms.TextBox();
            this.maintainTxt = new System.Windows.Forms.TextBox();
            this.maintainValueTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(1030, 0);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.ReadOnly = true;
            this.noteTxt.Size = new System.Drawing.Size(786, 25);
            this.noteTxt.TabIndex = 27;
            this.noteTxt.Text = "";
            // 
            // lastTimePicker
            // 
            this.lastTimePicker.Enabled = false;
            this.lastTimePicker.Location = new System.Drawing.Point(777, 0);
            this.lastTimePicker.Name = "lastTimePicker";
            this.lastTimePicker.Size = new System.Drawing.Size(226, 27);
            this.lastTimePicker.TabIndex = 22;
            // 
            // odoTxt
            // 
            this.odoTxt.Enabled = false;
            this.odoTxt.Location = new System.Drawing.Point(540, 2);
            this.odoTxt.Name = "odoTxt";
            this.odoTxt.ReadOnly = true;
            this.odoTxt.Size = new System.Drawing.Size(182, 27);
            this.odoTxt.TabIndex = 21;
            // 
            // maintainTxt
            // 
            this.maintainTxt.Enabled = false;
            this.maintainTxt.Location = new System.Drawing.Point(138, 3);
            this.maintainTxt.Name = "maintainTxt";
            this.maintainTxt.ReadOnly = true;
            this.maintainTxt.Size = new System.Drawing.Size(182, 27);
            this.maintainTxt.TabIndex = 28;
            // 
            // maintainValueTxt
            // 
            this.maintainValueTxt.Enabled = false;
            this.maintainValueTxt.Location = new System.Drawing.Point(338, 2);
            this.maintainValueTxt.Name = "maintainValueTxt";
            this.maintainValueTxt.ReadOnly = true;
            this.maintainValueTxt.Size = new System.Drawing.Size(182, 27);
            this.maintainValueTxt.TabIndex = 29;
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maintainValueTxt);
            this.Controls.Add(this.maintainTxt);
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.lastTimePicker);
            this.Controls.Add(this.odoTxt);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(1866, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox noteTxt;
        private DateTimePicker lastTimePicker;
        private TextBox odoTxt;
        private TextBox maintainTxt;
        private TextBox maintainValueTxt;
    }
}
