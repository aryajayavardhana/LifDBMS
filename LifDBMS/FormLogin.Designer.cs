
namespace LifDBMS
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(48, 88);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 15);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(48, 117);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(127, 85);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(156, 23);
            this.userTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(127, 114);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(156, 23);
            this.passwordTxt.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(127, 143);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(208, 143);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 252);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button cancel;
    }
}

