using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Models;

namespace eShop.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct { get; }
        IEnumerable<Product> GetProductOnSale { get; }
        Product GetProductById(int ProudctId);
    }
}
