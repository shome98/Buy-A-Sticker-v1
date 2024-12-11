using Sticker_web.Data;
using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
