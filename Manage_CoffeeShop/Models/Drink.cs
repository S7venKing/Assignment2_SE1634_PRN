using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class Drink
    {
        public Drink()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int DrinkId { get; set; }
        public string DrinkName { get; set; } = null!;
        public int CateId { get; set; }
        public double DrinkPrice { get; set; }

        public virtual Category Cate { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
