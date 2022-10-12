using EShop.WebApi.Context;
using EShop.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EShop.WebApi.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository.IProductRepository
    {
        private readonly EShopContext _context;

        public ProductRepository(EShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> getProductsAll()
        {
            var list = await _context.products.Include(p => p.category).ToListAsync();   

            return list;    
        }
        
        public async Task<Product> getProductById(int id)
        {
            var product = await _context.products.Include(c=>c.category)
                                .FirstOrDefaultAsync(x => x.id == id);

            if (product == null)
            {
                return null;
            }
            return product;
        }           

        public async Task<IEnumerable<Product>> getProductsCategoryById(int id)
        {
            var productCategory = await _context.products.Include(c => c.category)
                                        .Where(x => x.categoryid == id).ToListAsync();
            
            if (productCategory == null)
            {
                return null;
            }
            return productCategory;
        }
    }
}
