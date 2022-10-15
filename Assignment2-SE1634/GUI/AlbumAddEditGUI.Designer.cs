namespace Assignment2_SE1634.GUI
{
    partial class AlbumAddEditGUI
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
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(46, 67);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(51, 20);
            this.lbGenre.TabIndex = 0;
            this.lbGenre.Text = "Genre:";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Location = new System.Drawing.Point(46, 131);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(47, 20);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.Text = "Artist:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(52, 191);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 20);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(46, 246);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 20);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(117, 64);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(326, 28);
            this.cbGenre.TabIndex = 4;
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(117, 128);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(326, 28);
            this.cbArtist.TabIndex = 5;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(117, 191);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(326, 27);
            this.txbTitle.TabIndex = 6;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(117, 246);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(326, 27);
            this.txbPrice.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(470, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(314, 303);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(129, 29);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Choose Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 27);
            this.textBox1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(631, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Location = new System.Drawing.Point(36, 307);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(54, 20);
            this.Image.TabIndex = 13;
            this.Image.Text = "Image:";
            // 
            // AlbumAddEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 531);
            this.ControlBox = false;
            this.Controls.Add(this.Image);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbGenre);
            this.Name = "AlbumAddEditGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumAddEditGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbGenre;
        private Label lbArtist;
        private Label lbTitle;
        private Label lbPrice;
        private ComboBox cbGenre;
        private ComboBox cbArtist;
        private TextBox txbTitle;
        private TextBox txbPrice;
        private PictureBox pictureBox1;
        private Button btnImage;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnCancel;
        private Label Image;
    }
}