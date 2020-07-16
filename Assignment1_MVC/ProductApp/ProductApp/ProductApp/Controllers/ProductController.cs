using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
/// <summary>
/// ipo model entha folder la iruko athu namespace add pananum
/// View la ethuvum doubt ila la?

/// </summary>

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductList list = new ProductList();
        public IActionResult Index()
        {
            list.Products.Add(new Product(1, "pphone", 15000, 2));
            return View(list.Products);
            // ipo intha return statement will render a View.. The View name is same as Method name (index)... 
            // and the index.cshtml will be present inside a folder with name of the controller (Product)
        }

        public IActionResult Create(Product p)
        {
            list.Products.Add(p);
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}