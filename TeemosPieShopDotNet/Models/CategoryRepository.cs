namespace TeemosPieShopDotNet.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TeemosPieShopDbContext _teemosPieShopDbContext;
        public CategoryRepository(TeemosPieShopDbContext teemosPieShopDbContext)
        {
            _teemosPieShopDbContext = teemosPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => 
            _teemosPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
