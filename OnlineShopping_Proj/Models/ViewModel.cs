using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping_Proj.Models
{
    public class ViewModel
    {

        public Product prod { get; set; }

        public Category cat { get; set; }

        public List<Category> Categorys { get; set; }
        public List<Product> Products { get; set; }


    }
}