using EShop.WebApi.Entities;

namespace EShop.WebApi.Repository.IProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> getProductsAll();        
       Task<Product> getProductById(int id);
        Task<IEnumerable<Product>> getProductsCategoryById(int id);
        
    }
}
