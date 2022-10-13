using Manage_CoffeeShop.DAO;
using Manage_CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_CoffeeShop
{
    public partial class TableManageGUI : Form
    {

        public TableManageGUI()
        {
            InitializeComponent();
            LoadTable();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginGUI login = new LoginGUI();
            login.Show();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfileGUI prof = new ProfileGUI();
            prof.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGUI prof = new AdminGUI();
            this.Hide();
            prof.ShowDialog();
            this.Show();
            
        }

        void LoadTable()
        {
            TableDAO dao = new TableDAO();
            List<CoffeTable> list = dao.LoadDataTable();
            foreach (var item in list)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 120;
                btn.Text = item.TableName;
                if (item.TableStatus)
                {
                    btn.BackColor = Color.LightBlue;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                btn.Click += Btn_Click;
                btn.Tag = item;
                flpnTable.Controls.Add(btn);
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            int tableId = (sender as CoffeTable).TableId;
            ShowBill(tableId);
        }

        void ShowBill(int id)
        {
            coffeeContext coffee = new coffeeContext();
            List<BillInfo> bills = coffee.BillInfos.ToList();

        }
    }
}
