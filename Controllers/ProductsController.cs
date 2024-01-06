using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvcApp100.Models;
namespace MyMvcApp100.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products; 

        public ProductsController()
        {

            products = new List<Product>()
            {
                new Product(){ ProductId=101, ProductName="Water Bottle", ProductDescription="A copper water bottle"},
                new Product(){ ProductId=102, ProductDescription="A Laptop",ProductName="Microsoft Surface pro 9"},
                new Product(){ ProductId=103, ProductDescription="A Smartphone",ProductName="Apple Iphone 10"},

            };



        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult List() 
        { 
        
            return View("List", products);




        }


    }
}