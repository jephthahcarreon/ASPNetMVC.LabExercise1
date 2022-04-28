using ASPNetMVC.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult List()
        {
            ViewData["ProductCatalog"] = this.productService.GetCatalog();
            ViewData["GrandTotal"] = this.productService.GetGrandTotal().ToString("C2");
            return View("~/Views/Product/List.cshtml");
        }
    }
}
