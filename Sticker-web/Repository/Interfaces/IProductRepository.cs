using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task UpdateAsync(Product obj);
    }
}
