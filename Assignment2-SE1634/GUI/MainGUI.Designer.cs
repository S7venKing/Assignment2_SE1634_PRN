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
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.plnShop = new System.Windows.Forms.Panel();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.lbCart = new System.Windows.Forms.Label();
            this.lbShopping = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.plnShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(114, 47);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(258, 28);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedValueChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(57, 50);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(545, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(850, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(45, 461);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // plnShop
            // 
            this.plnShop.Controls.Add(this.cbTitle);
            this.plnShop.Controls.Add(this.btnAll);
            this.plnShop.Controls.Add(this.btnNext);
            this.plnShop.Controls.Add(this.btnPrev);
            this.plnShop.Controls.Add(this.btnSearch);
            this.plnShop.Controls.Add(this.Title);
            this.plnShop.Controls.Add(this.lbGenre);
            this.plnShop.Controls.Add(this.cbGenre);
            this.plnShop.Location = new System.Drawing.Point(-5, 118);
            this.plnShop.Name = "plnShop";
            this.plnShop.Size = new System.Drawing.Size(1007, 549);
            this.plnShop.TabIndex = 1;
            this.plnShop.Visible = false;
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(589, 47);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(258, 28);
            this.cbTitle.TabIndex = 10;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(378, 47);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(119, 29);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "All Products";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // lbCart
            // 
            this.lbCart.AutoSize = true;
            this.lbCart.Location = new System.Drawing.Point(126, 20);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(36, 20);
            this.lbCart.TabIndex = 1;
            this.lbCart.Text = "Cart";
            // 
            // lbShopping
            // 
            this.lbShopping.AutoSize = true;
            this.lbShopping.Location = new System.Drawing.Point(12, 20);
            this.lbShopping.Name = "lbShopping";
            this.lbShopping.Size = new System.Drawing.Size(73, 20);
            this.lbShopping.TabIndex = 0;
            this.lbShopping.Text = "Shopping";
            this.lbShopping.Click += new System.EventHandler(this.lbShopping_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(203, 20);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(46, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 712);
            this.Controls.Add(this.lbShopping);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.plnShop);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGUI";
            this.plnShop.ResumeLayout(false);
            this.plnShop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbGenre;
        private Label lbGenre;
        private Label Title;
        private Button btnSearch;
        private Button btnPrev;
        private Button btnNext;
        private Panel plnShop;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label lbCart;
        private Label lbShopping;
        private Label lbLogin;
        private Button btnAll;
        private ComboBox cbTitle;
    }
}