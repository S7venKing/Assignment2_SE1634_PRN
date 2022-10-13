using Manage_CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_CoffeeShop.DAO
{
    public class TableDAO
    {
        coffeeContext coffee = new coffeeContext();
        public List<CoffeTable> LoadDataTable()
        { 
            var table = coffee.CoffeTables.ToList();
            return table;
        }
    }
}
