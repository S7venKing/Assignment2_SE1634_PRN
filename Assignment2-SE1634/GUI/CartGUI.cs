using Assignment2_SE1634.DAO;
using Assignment2_SE1634.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class CartGUI : Form
    {
        public string username { get; set;}
        public List<Cart> cart = new List<Cart>();
        CartDAO carts = new CartDAO();
        AlbumDAO dao = new AlbumDAO();
        public CartGUI(string userName)
        {
            InitializeComponent();
            this.username = userName;
            LoadCart();
        }

        void LoadCart()
        {
            
            cart = carts.GetCartsByUser(this.username);
            double price = 0;
            foreach (var item in cart)
            {
                price += (double)(dao.LoadAlbumByID(item.AlbumId).Price) * (item.Count);
                txbPrice.Text = price.ToString("0.###");
                
            }
            
           
            dataGridView1.DataSource = cart;
        }

        MusicStoreContext music = new MusicStoreContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   
                int albID = (int)dataGridView1.Rows[e.RowIndex].Cells["albumID"].Value;
                Cart alb =  cart.Where(p => p.AlbumId == albID).FirstOrDefault();
                int count = (int)dataGridView1.Rows[e.RowIndex].Cells["count"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
                {
                    count += 1;
                    dataGridView1.Rows[e.RowIndex].Cells["count"].Value = count;
                    alb.Count = count;
                    music.Entry(alb).State = EntityState.Modified;
                    music.SaveChanges();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
                {
                    if (count > 1)
                    {
                        count -= 1;
                        dataGridView1.Rows[e.RowIndex].Cells["count"].Value = count;
                        alb.Count = count;
                        music.Entry(alb).State = EntityState.Modified;
                        music.SaveChanges();
                       
                    }
                    else
                    {
                        music.Remove(alb);
                        music.SaveChanges();
                       
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
                {
                    AlbumDAO dao = new AlbumDAO();
                    Album album = dao.LoadAlbumByID(albID);
                    MessageBox.Show($"Album ID: {album.AlbumId}\nAlbum Name:{album.Title}");
                }
                
                LoadCart();
            }
            catch
            {
                
            }
            

        }
    }
}
