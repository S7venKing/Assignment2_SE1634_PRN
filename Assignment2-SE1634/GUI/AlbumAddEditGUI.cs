using Assignment2_SE1634.DAO;
using Assignment2_SE1634.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_SE1634.GUI
{
    public partial class AlbumAddEditGUI : Form
    {
        private string action;
        private int id;
        public Form form;
        public string Action { get => action; set => action = value; }
        public int Id { get => id; set => id = value; }
        public AlbumAddEditGUI(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
            MessageBox.Show(this.action + "," + this.id.ToString());
            LoadGUI();


        }

        void LoadGUI()
        {
            AlbumDAO dao = new AlbumDAO();
            if (this.action == "edit")
            {
                Album album = dao.LoadAlbumByID(this.id);
                MusicStoreContext music = new MusicStoreContext();
                cbArtist.Text = music.Artists.Where(p => p.ArtistId == album.ArtistId).FirstOrDefault().Name;
                cbGenre.Text = music.Genres.Where(p => p.GenreId == album.GenreId).FirstOrDefault().Name;
                cbGenre.DataSource = music.Genres.ToList();
                cbGenre.DisplayMember = "Name";
                cbGenre.ValueMember = "Name";
                cbArtist.DataSource = music.Artists.ToList();
                cbArtist.DisplayMember = "Name";
                cbArtist.ValueMember = "Name";
                cbArtist.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbArtist.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbGenre.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbGenre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txbPrice.Text = album.Price.ToString();
                txbTitle.Text = album.Title;
                pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, $"Resources{album.AlbumUrl}");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Image file";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*gif)| *.jpg;*.jpeg;*.png;*.gif";

                ofd.ShowDialog();
                if (ofd.FileName == "")
                    return;
                string filename = ofd.FileName;
                string[] str = filename.Split("\\");
                pictureBox1.ImageLocation = filename;
                MessageBox.Show(filename.ToString());
                //luu vao resources cua chuong trinh(Application.StartupPath(bin\.net 6) + "Resources\\Images\\" + str.Last()), luu duong dan cua resouces toi database(\\Images\\str.Last())
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + "Resources\\Images\\" + str.Last(), true);
            }
            catch { }
        }
    }
}
