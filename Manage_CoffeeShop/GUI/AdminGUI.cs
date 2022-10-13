using Manage_CoffeeShop.DAO;
using Manage_CoffeeShop.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_CoffeeShop
{
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            AccountDAO acc_dao = new AccountDAO();
            DrinkDAO drink = new DrinkDAO();
            coffeeContext coffee = new coffeeContext();
            cbCategory.DataSource = coffee.Categories.ToList();
            cbCategory.DisplayMember = "CateName";
            dtgvAcc.DataSource = acc_dao.LoadDataAccount();
            dtgvDrink.DataSource = drink.LoadDataDrink();

        }

        private void dtgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbAccID.DataBindings.Clear();
            txbAccName.DataBindings.Clear();
            txbAccUser.DataBindings.Clear();
            txbAccID.DataBindings.Add("Text", dtgvAcc.DataSource, "Id");
            txbAccName.DataBindings.Add("Text", dtgvAcc.DataSource, "Name");
            txbAccUser.DataBindings.Add("Text", dtgvAcc.DataSource, "UserName");
    }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                Category cate = (Category)cb.SelectedValue;
                DrinkDAO drink = new DrinkDAO();
                dtgvDrink.DataSource = drink.LoadDrinkByCateID(cate.CateId);
            }
            
        }

        private void dtgvDrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbDrinkID.DataBindings.Clear();
            txbDrinkName.DataBindings.Clear();
            txbDrinkCategory.DataBindings.Clear();
            txbDrinkPrice.DataBindings.Clear();
            txbDrinkID.DataBindings.Add("Text", dtgvDrink.DataSource, "DrinkId");
            txbDrinkName.DataBindings.Add("Text", dtgvDrink.DataSource, "DrinkName");
            txbDrinkCategory.DataBindings.Add("Text", dtgvDrink.DataSource, "CateId");
            txbDrinkPrice.DataBindings.Add("Text", dtgvDrink.DataSource, "DrinkPrice");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            coffeeContext coffee = new coffeeContext();
            dtgvDrink.DataSource = coffee.Drinks.ToList();
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {

        }
    }
}
