using OnlineShopping_Proj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping_Proj.Controllers
{
    public class CategoryController : Controller
    {
        private ShoppingContext Db = new ShoppingContext();
        // GET: Category
        public ActionResult Index()
        {
            var data = Db.categories.ToList();
            var data1 = Db.products.ToList();
            ViewModel vm = new ViewModel();
            vm.Categorys = data;
            vm.Products = data1;
            return View(vm);


        }

        [HttpPost]
        public ActionResult Index(ViewModel obj)
        {
            Db.categories.Add(obj.cat);
            Db.products.Add(obj.prod);
            Db.SaveChanges();
            Index();
            return View();

        }


    }
}