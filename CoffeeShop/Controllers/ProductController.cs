using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            List<Product> prods = db.GetAll<Product>().ToList();
           
            Console.WriteLine();
            return View(prods);
        }

        public IActionResult Detail(int prodId)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            Product thisProd = db.Get<Product>(prodId);
            return View(thisProd);
        }
    }
}
