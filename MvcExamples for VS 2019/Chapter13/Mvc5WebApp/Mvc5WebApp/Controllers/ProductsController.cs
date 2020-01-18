using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5WebApp.Models;

namespace Mvc5WebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsList()
        {
            List<Product> products = new List<Product>
            {
                new Product{ Id=1, Name="MacBook", Price=1500},
                new Product{ Id=2, Name="iPhone", Price=400},
                new Product{ Id=3, Name="iWatch", Price=399}
            };

            return View("ProductsList", products);
        }

        public ActionResult FindProductById(int? id)
        {
            if (id == null || id < 1 || id > 5)
            {
                return HttpNotFound("Id is illegal.");
            }

            List<Product> products = new List<Product>
            {
                new Product{ Id=1, Name="MacBook", Price=1500},
                new Product{ Id=3, Name="iPhone", Price=400},
                new Product{ Id=5, Name="iWatch", Price=399}
            };

            var product = products.Where(p => p.Id == id);


            if (product.Count() == 0)
            {
                return RedirectToAction("ProductsList", "Products");
            }

            return View(product);
        }
    }
}