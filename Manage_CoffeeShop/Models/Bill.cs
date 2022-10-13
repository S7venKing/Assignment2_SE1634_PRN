using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int BillId { get; set; }
        public DateTime? Datecheckin { get; set; }
        public DateTime? Datecheckout { get; set; }
        public int TableId { get; set; }
        public int BillStatus { get; set; }

        public virtual CoffeTable Table { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
