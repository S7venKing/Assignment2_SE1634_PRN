namespace Manage_CoffeeShop
{
    partial class LoginGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 250);
            this.panel1.TabIndex = 0;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(236, 120);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(63, 22);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(168, 120);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(63, 22);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_pass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 41);
            this.panel3.TabIndex = 2;
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(110, 12);
            this.txb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.Size = new System.Drawing.Size(187, 23);
            this.txb_pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_user);
            this.panel2.Controls.Add(this.lb_user);
            this.panel2.Location = new System.Drawing.Point(4, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 41);
            this.panel2.TabIndex = 0;
            // 
            // txb_user
            // 
            this.txb_user.Location = new System.Drawing.Point(109, 12);
            this.txb_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(187, 23);
            this.txb_user.TabIndex = 1;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(65, 14);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(36, 15);
            this.lb_user.TabIndex = 0;
            this.lb_user.Text = "User: ";
            // 
            // LoginGUI
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(389, 268);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lb_user;
        private Panel panel3;
        private TextBox txb_pass;
        private Label label1;
        private TextBox txb_user;
        private Button btn_login;
        private Button btn_quit;
    }
}