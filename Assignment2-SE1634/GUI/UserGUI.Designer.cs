namespace Assignment2_SE1634
{
    partial class UserGUI
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
            this.components = new System.ComponentModel.Container();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.plnShop = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.albumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.lbCart = new System.Windows.Forms.Label();
            this.lbShopping = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lblLog = new System.Windows.Forms.Label();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.plnShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(114, 15);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(258, 28);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedValueChanged += new System.EventHandler(this.cbGenre_SelectedValueChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(45, 21);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(549, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(857, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(28, 533);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 533);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // plnShop
            // 
            this.plnShop.Controls.Add(this.btnAdd);
            this.plnShop.Controls.Add(this.dataGridView1);
            this.plnShop.Controls.Add(this.cbTitle);
            this.plnShop.Controls.Add(this.btnAll);
            this.plnShop.Controls.Add(this.btnNext);
            this.plnShop.Controls.Add(this.btnPrev);
            this.plnShop.Controls.Add(this.btnSearch);
            this.plnShop.Controls.Add(this.Title);
            this.plnShop.Controls.Add(this.lbGenre);
            this.plnShop.Controls.Add(this.cbGenre);
            this.plnShop.Location = new System.Drawing.Point(12, 65);
            this.plnShop.Name = "plnShop";
            this.plnShop.Size = new System.Drawing.Size(1007, 579);
            this.plnShop.TabIndex = 1;
            this.plnShop.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Create a new Album";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumId,
            this.genreId,
            this.artistId,
            this.titleAlbum,
            this.price,
            this.albumUrl,
            this.artistDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.cartsDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.albumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(975, 429);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // albumId
            // 
            this.albumId.DataPropertyName = "AlbumId";
            this.albumId.HeaderText = "AlbumId";
            this.albumId.MinimumWidth = 6;
            this.albumId.Name = "albumId";
            this.albumId.Width = 125;
            // 
            // genreId
            // 
            this.genreId.DataPropertyName = "GenreId";
            this.genreId.HeaderText = "GenreId";
            this.genreId.MinimumWidth = 6;
            this.genreId.Name = "genreId";
            this.genreId.Width = 125;
            // 
            // artistId
            // 
            this.artistId.DataPropertyName = "ArtistId";
            this.artistId.HeaderText = "ArtistId";
            this.artistId.MinimumWidth = 6;
            this.artistId.Name = "artistId";
            this.artistId.Width = 125;
            // 
            // titleAlbum
            // 
            this.titleAlbum.DataPropertyName = "Title";
            this.titleAlbum.HeaderText = "Title";
            this.titleAlbum.MinimumWidth = 6;
            this.titleAlbum.Name = "titleAlbum";
            this.titleAlbum.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // albumUrl
            // 
            this.albumUrl.DataPropertyName = "AlbumUrl";
            this.albumUrl.HeaderText = "AlbumUrl";
            this.albumUrl.MinimumWidth = 6;
            this.albumUrl.Name = "albumUrl";
            this.albumUrl.Width = 125;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Visible = false;
            this.artistDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Visible = false;
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartsDataGridViewTextBoxColumn
            // 
            this.cartsDataGridViewTextBoxColumn.DataPropertyName = "Carts";
            this.cartsDataGridViewTextBoxColumn.HeaderText = "Carts";
            this.cartsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartsDataGridViewTextBoxColumn.Name = "cartsDataGridViewTextBoxColumn";
            this.cartsDataGridViewTextBoxColumn.Visible = false;
            this.cartsDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            this.orderDetailsDataGridViewTextBoxColumn.Visible = false;
            this.orderDetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Assignment2_SE1634.Models.Album);
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(593, 16);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(258, 28);
            this.cbTitle.TabIndex = 10;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(387, 16);
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
            this.lbCart.Location = new System.Drawing.Point(126, 22);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(36, 20);
            this.lbCart.TabIndex = 1;
            this.lbCart.Text = "Cart";
            this.lbCart.Click += new System.EventHandler(this.lbCart_Click);
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
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(208, 22);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(56, 20);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Logout";
            this.lblLog.Click += new System.EventHandler(this.lblLog_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessToken = null;
            this.sqlConnection1.Credential = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.StatisticsEnabled = false;
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(346, 22);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(59, 20);
            this.lbAdmin.TabIndex = 3;
            this.lbAdmin.Text = "Albums";
            this.lbAdmin.Click += new System.EventHandler(this.lbAdmin_Click);
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 725);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbShopping);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.plnShop);
            this.Name = "UserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGUI";
            this.plnShop.ResumeLayout(false);
            this.plnShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
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
        private Button btnAll;
        private ComboBox cbTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblLog;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Label lbAdmin;
        private DataGridView dataGridView1;
        private BindingSource albumBindingSource;
        private Button btnAdd;
        private DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumUrlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn albumId;
        private DataGridViewTextBoxColumn genreId;
        private DataGridViewTextBoxColumn artistId;
        private DataGridViewTextBoxColumn titleAlbum;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn albumUrl;
    }
    }