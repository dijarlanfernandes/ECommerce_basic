using EShop.Models.Dtos;

namespace Ecommerce.Services.Web.IServices
{
    public interface IServiceProduct
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
    }
}
