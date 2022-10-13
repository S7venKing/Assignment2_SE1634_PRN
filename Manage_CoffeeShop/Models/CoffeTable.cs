using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class CoffeTable
    {
        public CoffeTable()
        {
            Bills = new HashSet<Bill>();
        }

        public int TableId { get; set; }
        public string? TableName { get; set; }
        public bool TableStatus { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
