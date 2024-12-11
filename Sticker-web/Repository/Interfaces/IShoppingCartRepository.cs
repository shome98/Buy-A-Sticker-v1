using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        Task UpdateAsync(ShoppingCart obj);
    }
}
