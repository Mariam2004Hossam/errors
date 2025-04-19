using Microsoft.EntityFrameworkCore;
using TechXpress.Models;
using TechXpress.Data.Repositories;


namespace TechXpress.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TechXpressDbContext _context;

        public CategoryRepository(TechXpressDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }
    }
}
