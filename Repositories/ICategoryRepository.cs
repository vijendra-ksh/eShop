using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Models;

namespace eShop.Repositories
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
