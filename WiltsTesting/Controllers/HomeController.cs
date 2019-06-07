using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WiltsTesting.Models;
using WiltsTesting.Services;

namespace WiltsTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IOptions<SampleWebSettings> settingsOptions;

        public HomeController(IProductService productService, IOptions<SampleWebSettings> settingsOptions)
        {
            this.productService = productService;
            this.settingsOptions = settingsOptions;
        }

        public IActionResult Index()
        {
            return View("Products", this.productService.SearchProducts(""));
        }

        public IActionResult Product()
        {
            return View("Product", this.productService.GetProduct(Guid.Empty));
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
