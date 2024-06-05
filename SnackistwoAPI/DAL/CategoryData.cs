using Microsoft.EntityFrameworkCore;

namespace SnackistwoAPI.DAL
{
    public class CategoryData
    {
        private readonly MyDBContext _context;

        public CategoryData(MyDBContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Category>> GetCategoriesAsync()
        {
            List<Models.Category> categories = await _context.Category.ToListAsync();

            return categories;
        }
    }
}
