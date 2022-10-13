using Manage_CoffeeShop.DAO;
using Manage_CoffeeShop.Models;

namespace Manage_CoffeeShop
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent(); 

        }





        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txb_user.Text;
            string pass = txb_pass.Text;
            AccountDAO dao = new AccountDAO();
            bool rs = dao.GetAccountByUsernameAndPass(username, pass);
            if (rs)
            {
                TableManageGUI tableManage = new TableManageGUI();
                tableManage.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
    }
}

    
