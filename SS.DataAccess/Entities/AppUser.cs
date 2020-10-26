using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }

        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
