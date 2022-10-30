using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping_Proj.Models
{
    public class Product
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}