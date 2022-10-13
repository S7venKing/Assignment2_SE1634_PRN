namespace Assignment2_SE1634
{
    partial class MainGUI
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbShopping = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.plnShop = new System.Windows.Forms.Panel();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.tblLayout.SuspendLayout();
            this.plnShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblLayout.Controls.Add(this.lbLogin, 2, 0);
            this.tblLayout.Controls.Add(this.lbShopping, 0, 0);
            this.tblLayout.Controls.Add(this.lbCart, 1, 0);
            this.tblLayout.Location = new System.Drawing.Point(12, 12);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Size = new System.Drawing.Size(265, 31);
            this.tblLayout.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(189, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(46, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // lbShopping
            // 
            this.lbShopping.AutoSize = true;
            this.lbShopping.Location = new System.Drawing.Point(3, 0);
            this.lbShopping.Name = "lbShopping";
            this.lbShopping.Size = new System.Drawing.Size(73, 20);
            this.lbShopping.TabIndex = 0;
            this.lbShopping.Text = "Shopping";
            this.lbShopping.Click += new System.EventHandler(this.lbShopping_Click);
            // 
            // lbCart
            // 
            this.lbCart.AutoSize = true;
            this.lbCart.Location = new System.Drawing.Point(96, 0);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(36, 20);
            this.lbCart.TabIndex = 1;
            this.lbCart.Text = "Cart";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(151, 50);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(258, 28);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedValueChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(88, 53);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(456, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(51, 20);
            this.Title.TabIndex = 3;
            this.Title.Text = "Genre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 28);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(774, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(25, 479);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(138, 479);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // plnShop
            // 
            this.plnShop.Controls.Add(this.btnNext);
            this.plnShop.Controls.Add(this.btnPrev);
            this.plnShop.Controls.Add(this.btnSearch);
            this.plnShop.Controls.Add(this.textBox1);
            this.plnShop.Controls.Add(this.Title);
            this.plnShop.Controls.Add(this.lbGenre);
            this.plnShop.Controls.Add(this.cbGenre);
            this.plnShop.Location = new System.Drawing.Point(5, 118);
            this.plnShop.Name = "plnShop";
            this.plnShop.Size = new System.Drawing.Size(987, 529);
            this.plnShop.TabIndex = 1;
            this.plnShop.Visible = false;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 712);
            this.Controls.Add(this.plnShop);
            this.Controls.Add(this.tblLayout);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.plnShop.ResumeLayout(false);
            this.plnShop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblLayout;
        private Label lbLogin;
        private Label lbShopping;
        private Label lbCart;
        private ComboBox cbGenre;
        private Label lbGenre;
        private Label Title;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnPrev;
        private Button btnNext;
        private Panel plnShop;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}