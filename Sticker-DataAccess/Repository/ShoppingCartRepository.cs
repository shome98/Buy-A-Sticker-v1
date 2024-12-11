using Sticker_Models.Models;
using Sticker_DataAccess.Data;
using Sticker_DataAccess.Repository.Interfaces;

namespace Sticker_DataAccess.Repository
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
