using EShop.Models.Dtos;
using EShop.UI.Services.IServicesProduct;
using System.Net.Http.Json;

namespace EShop.UI.Services.ServicesProduct
{
    public class Service : IService
    {
        public HttpClient _httpClient;
        public Logger<IService> _logger;

        public Service(HttpClient httpClient, Logger<IService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<ProductDto>($"v1/home/api/products/{id}");
                return products;
            }
            catch (Exception)
            {
                _logger.LogError("erro ao acessar a api: v1/home/api/products");
                throw;
            }
            
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("v1/home/api/products");
                return products;
            }
            catch (Exception)
            {
                _logger.LogError("erro ao acessar a api: v1/home/api/products");
                throw;
            }
        }
    }
}
