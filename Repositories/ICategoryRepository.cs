using TechXpress.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechXpress.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
    }
}
