﻿namespace WinFormUI.Forms
{
    partial class LoginForm
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(325, 80);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(75, 20);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(276, 135);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(177, 27);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(306, 193);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 29);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameLbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label usernameLbl;
        private TextBox passwordTxtBox;
        private Button loginBtn;
    }
}