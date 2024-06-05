using Microsoft.AspNetCore.Mvc;
using SnackistwoAPI.DAL;

namespace SnackistwoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly CategoryData _categoryData;

        public CategoryController(CategoryData categoryData)
        {
            _categoryData = categoryData;
        }


        [HttpGet]
        public async Task<List<Models.Category>> Get()
        {
            var categories = await _categoryData.GetCategoriesAsync();

            return categories;
        }

    }
}
