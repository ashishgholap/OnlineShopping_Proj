using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShopping_Proj.Models
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("CodeFirstDb1")
        {
                
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
