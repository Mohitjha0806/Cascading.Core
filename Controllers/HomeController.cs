using Cascading.Core.Data;
using Cascading.Core.Models;
using Cascading.Core.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Collections;

namespace Cascading.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            var product = new List<Product>();

            categories.Add(new Category()
            {
                Id = 0,
                CategoryName = "--Select Category--"
            });

            product.Add(new Product()
            {
                Id = 0,
                Name = "--Select Product--"
            });

            ViewBag.categories = new SelectList(categories, "Id", "CategoryName");
            ViewBag.Products = new SelectList(product, "Id", "Name");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
