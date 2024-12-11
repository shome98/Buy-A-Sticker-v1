using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task UpdateAsync(Product obj);
    }
}
