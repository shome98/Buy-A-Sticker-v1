using Sticker_web.Data;
using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
