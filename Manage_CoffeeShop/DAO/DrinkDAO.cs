using Manage_CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_CoffeeShop.DAO
{
    public class DrinkDAO
    {
        coffeeContext coffee = new coffeeContext();
        public List<Drink> LoadDataDrink()
        {
            var drink = coffee.Drinks.ToList();
            return drink;
        }

        public List<Drink> LoadDrinkByCateID(int cateID)
        {
            var list = coffee.Drinks.ToList();
            var drink = list.Where(p => p.CateId == cateID).ToList();
            return drink;
        }
    }
}
