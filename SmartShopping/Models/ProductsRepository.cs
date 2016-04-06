using SmartShopping.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartShopping.Models
{
    public class ProductsRepository
    {
        private SmartDBDataContext db = new SmartDBDataContext();

        public IQueryable<Product> getAllProducts()
        {
            return db.Products;
        }
    }
}