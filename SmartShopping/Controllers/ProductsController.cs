using SmartShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShopping.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ProductsRepository productRep = new ProductsRepository();
            var products = productRep.getAllProducts();
            return View(products);
        }
    }
}