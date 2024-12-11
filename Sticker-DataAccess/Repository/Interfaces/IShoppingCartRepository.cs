using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        Task UpdateAsync(ShoppingCart obj);
    }
}
