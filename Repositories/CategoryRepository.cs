using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Models;

namespace eShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
    private AppDbContext _appDbContext;
    public CategoryRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}
