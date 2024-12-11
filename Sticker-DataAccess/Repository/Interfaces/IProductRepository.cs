using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task UpdateAsync(Product obj);
    }
}
