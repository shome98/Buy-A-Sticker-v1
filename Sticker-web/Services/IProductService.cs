using Sticker_web.Models.ViewModels;
using Sticker_web.Models;

namespace Sticker_web.Services
{
    public interface IProductService
    {
        Task AddAsync(Product obj);
        Task<IEnumerable<Product>> GetAllAsync(string include);
        Task<Product> GetAsync(int? id);
        ProductVM ImageHandle(ProductVM productVM, IFormFile? file);
        Task RemoveAsync(Product obj);
        Task UpdateAsync(Product obj);
    }
}
