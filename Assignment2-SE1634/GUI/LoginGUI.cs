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
    public partial class LoginGUI : Form
    {
        public Form form { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            AccountDAO dao = new AccountDAO();
            User user = dao.GetUserByUsernameAndPassword(txbUser.Text, txbPass.Text);
            if (user != null)
            {
                UserGUI userGUI = new UserGUI(user);
                userGUI.Show();
                this.Close();
                
                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
