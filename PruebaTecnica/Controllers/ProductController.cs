using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using Services;

namespace PruebaTecnica.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return  Ok(_productService.GetProducts());
        }

        [HttpGet]
        public IActionResult GetProductsInDiscount()
        {
            return Ok(_productService.GetProductsInDiscount());
        }
    }
}
