using Assignment2_SE1634.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SE1634.DAO
{
    public class CartDAO
    {
        MusicStoreContext context = new MusicStoreContext();
        public List<Cart> GetCartsByUser(string username)
        {
            List<Cart> carts = context.Carts.Where(c=>c.CartId==username).ToList();
            return carts;
        }
    }
}
