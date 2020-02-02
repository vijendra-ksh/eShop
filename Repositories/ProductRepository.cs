using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Models;

namespace eShop.Repositories
{
public class ProductRepository : IProductRepository
{
private readonly AppDbContext _appDbContext;
public ProductRepository(AppDbContext appDbContext)
{
    _appDbContext = appDbContext;
}
public IEnumerable<Product> GetAllProduct
{
    get
    {
        return _appDbContext.Products.Include(c => c.Category);
            
    }
}

public IEnumerable<Product> GetProductOnSale
{
    get
    {
        return _appDbContext.Products.Include(c => c.Category).Where(p=>p.IsOnSale);

    }
}

public Product GetProductById(int ProudctId)
{
    return _appDbContext.Products.FirstOrDefault(p=>p.ProductId== ProudctId);
}
}
}
