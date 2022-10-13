using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class Category
    {
        public Category()
        {
            Drinks = new HashSet<Drink>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; } = null!;

        public virtual ICollection<Drink> Drinks { get; set; }
    }
}
