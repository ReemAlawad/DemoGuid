using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelDemo.Models;
using ViewModelDemo.Models.NewModels;

namespace ViewModelDemo.Controllers
{
    public class HomeController : Controller
    {
       


        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 1, Name = "Tv", Price = 800});
            products.Add(new Product { Id = 1, Name = "Smartphon", Price = 1000 });

            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier { Id = 1, Name = "Dell" });
            suppliers.Add(new Supplier { Id = 1, Name = "Samsung" });
            suppliers.Add(new Supplier { Id = 1, Name = "Apple" });

            var viewModel = new ProductSupplierViewModel
            {
                Products = products,
                Suppliers = suppliers
            };
            return View(viewModel);
        }

    }
}
