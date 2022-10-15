using Assignment2_SE1634.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SE1634.DAO
{
    public class AccountDAO
    {
        public User GetUserByUsernameAndPassword(string username, string pass)
        {
            User user = new User();
            
            MusicStoreContext musicStoreContext = new MusicStoreContext();
            user = musicStoreContext.Users.ToList().Where(p => p.UserName == username && p.Password==pass).FirstOrDefault();
            return user;
        }
    }
}
