//using TechXpress.Models;
//using TechXpress.Repositories;
//using TechXpress.Web.Models;

//namespace TechXpress.Services
//{
//    public class ProductService
//    {
//        private readonly IProductRepository _productRepository;

//        public ProductService(IProductRepository productRepository)
//        {
//            _productRepository = productRepository;
//        }

//        public async Task<IEnumerable<Product>> GetAllProductsAsync()
//        {
//            return await _productRepository.GetAllAsync();
//        }

//        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
//        {
//            return await _productRepository.SearchProductsAsync(searchTerm);
//        }

//        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
//        {
//            return await _productRepository.GetProductsByCategoryAsync(categoryId);
//        }

//        public async Task<IEnumerable<Category>> GetCategoriesAsync()
//        {
//            return await _productRepository.GetCategoriesAsync();  // Add a method to fetch categories
//        }
//    }

//}
using TechXpress.Repositories;
using TechXpress.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechXpress.Data.Repositories;

namespace TechXpress.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        // Ensure this method exists to get all products asynchronously
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            // Call the corresponding method in the ProductRepository to fetch all products
            return await _productRepository.GetAllAsync();
        }


        // Example method to get categories
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetCategoriesAsync();
        }

        // Example method to get products by category
        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _productRepository.GetProductsByCategoryAsync(categoryId);
        }

        // Other product-related methods
    }
}
