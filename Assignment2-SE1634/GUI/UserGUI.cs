using Assignment2_SE1634.DAO;
using Assignment2_SE1634.GUI;
using Assignment2_SE1634.Models;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Assignment2_SE1634
{

    public partial class UserGUI : Form
    {
        FlowLayoutPanel flpnShop = new FlowLayoutPanel();
        AlbumDAO albumDAO = new AlbumDAO();
        ArtistDAO artistDAO = new ArtistDAO();
        public List<Album> albums { get; set; }
        public int page { get; set; }
        public User user { get; set; }
        public UserGUI(User user)
        {
            InitializeComponent();
            this.user = user;
            
                if (this.user != null)
                {
                    if(this.user.Role == 1)
                {
                    lbAdmin.Visible = true;
                }
                else
                {
                    lbAdmin.Visible = false;
                }
                    lblLog.Text = $"Logout({this.user.UserName})";
                    lblLog.Click += lbLogout_Click;
                }
                else
                {
                    lbAdmin.Visible = false;
                    lblLog.Text = "Login";
                    lblLog.Click += lbLogin_Click;

            }
            
            LoadShop(); 
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            LoginGUI login = new LoginGUI();
            login.form = this;
            login.Show();
            this.Hide();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            UserGUI user = new UserGUI(null);
            user.Show();
            this.Close();
        }
        private void lbShopping_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            plnShop.Visible = true;
            dataGridView1.Visible = false;
            
        }

        void LoadShop()
        {
            
            MusicStoreContext music = new MusicStoreContext();
            cbGenre.DataSource = music.Genres.ToList();
            cbGenre.DisplayMember = "Name";
            cbTitle.DataSource = music.Albums.ToList();
            cbTitle.DisplayMember = "Title";
            cbTitle.ValueMember = "Title";
            cbTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend; 
            flpnShop.Location = new Point(22, 150);
            flpnShop.Size = new Size(941, 338);
            //Bat dau load shoppingGui page = 1 , list de phan trang la all 
            page = 1;
            albums = albumDAO.LoadAllAlbum();
            dataGridView1.DataSource = albumDAO.LoadAllAlbum();
            Page(page,albums); 
        }




        void Page(int page,List<Album> listA)
        {
            //Clear page cu - them page moi vao gui
            flpnShop.Controls.Clear();
            plnShop.Controls.Add(flpnShop);

            //listA : Chon list de phan trang - All/Theo Genre
            //LoadPaginationAlbum - Lay ra 3 san pham bat dau tu page  
            List<Album> list = albumDAO.LoadPaginationAlbum(page, 3, listA);
            
            //Button Next and Previous
            if (page == 1)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
            int rs = listA.Count%3;
            int total;
            if (rs == 0)
            {
                 total = listA.Count/3;
            }
            else
            {
                total = listA.Count / 3 + 1;
            }
            if (page == total)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
            //Button Next and Previous

            //voi moi san pham trong list( 3 san pham da phan trang ) tao them 1 group box
            foreach (var album in list) 
            {   //Cau hinh cac thanh phan cua group box - picture,artist,price,addcart
                PictureBox pic = new PictureBox();
                Label price = new Label();
                Label artist = new Label();
                Button addCart = new Button();
                GroupBox grb = new GroupBox();
                grb.Size = new Size(305, 325);
                pic.ImageLocation = Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources\\Image\\gohan.jpg");
                artist.TextAlign = ContentAlignment.MiddleCenter;
                price.TextAlign = ContentAlignment.MiddleCenter;
                grb.Controls.Add(pic);
                grb.Controls.Add(price);
                grb.Controls.Add(artist);
                grb.Controls.Add(addCart);
                pic.Location = new Point(60, 39);
                pic.Size = new Size(187, 82);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                price.Location = new Point(106, 141);
                artist.Location = new Point(106, 176);
                addCart.Location = new Point(75, 245);
                addCart.Size = new Size(158, 29);
                addCart.Text = "Add to cart";
                addCart.Name = "btnAddCart";
                grb.Tag = album.AlbumId;   
                grb.Text = album.Title;
                price.Text = "$" + album.Price.ToString();
                artist.Text = artistDAO.GetArtistByID(album.ArtistId).Name;
                flpnShop.Controls.Add(grb);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page += 1;
            Page(page, albums);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            page -= 1;
            Page(page, albums);
        }

        private void cbGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            page = 1;
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                Genre genre = (Genre)cb.SelectedValue;
                albums = albumDAO.LoadAlbumByGenre(genre.GenreId);
                Page(page, albums);
                dataGridView1.DataSource = albumDAO.LoadAlbumByGenre(genre.GenreId);
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadShop();
            dataGridView1.DataSource = albumDAO.LoadAllAlbum();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            page = 1;
            albums = albumDAO.LoadAlbumByTitle(cbTitle.Text);
            dataGridView1.DataSource = albumDAO.LoadAlbumByTitle(cbTitle.Text);
            Page(page, albums);
        }

        private void lbAdmin_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnAdd.Click += BtnAdd_Click;
            plnShop.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = albumDAO.LoadAllAlbum();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult res = MessageBox.Show("Do you want to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    AlbumDAO dao = new AlbumDAO();
                    dao.Delete((int)dataGridView1.Rows[e.RowIndex].Cells["albumId"].Value);
                    
                    dataGridView1.DataSource = dao.LoadAllAlbum();
                }
                if (res == DialogResult.No)
                {

                }
            }
        }
    }
}