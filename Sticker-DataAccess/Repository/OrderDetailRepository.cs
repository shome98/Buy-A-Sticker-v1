using Sticker_Models.Models;
using Sticker_DataAccess.Data;
using Sticker_DataAccess.Repository.Interfaces;

namespace Sticker_DataAccess.Repository
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
