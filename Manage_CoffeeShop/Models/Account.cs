using System;
using System.Collections.Generic;

namespace Manage_CoffeeShop.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Type { get; set; }
    }
}
