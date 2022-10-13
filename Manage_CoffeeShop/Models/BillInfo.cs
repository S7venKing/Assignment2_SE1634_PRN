using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class BillInfo
    {
        public int BillInfoId { get; set; }
        public int BillId { get; set; }
        public int DrinkId { get; set; }
        public int DrinkQuantity { get; set; }

        public virtual Bill Bill { get; set; } = null!;
        public virtual Drink Drink { get; set; } = null!;
    }
}
