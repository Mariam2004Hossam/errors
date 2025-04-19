using Microsoft.AspNetCore.Mvc;
using TechXpress.Services;
using TechXpress.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechXpress.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // Index action to display products with search and filter
        public async Task<IActionResult> Index(string searchTerm, int? categoryId)
        {
            var categories = await _productService.GetCategoriesAsync(); // Fetch categories for filter
            ViewBag.Categories = categories; // Pass categories to view

            var products = await _productService.GetAllProductsAsync();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm)).ToList();
            }

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value).ToList();
            }

            return View(products);
        }
    }

}
