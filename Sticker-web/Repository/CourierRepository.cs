using Sticker_web.Data;
using Sticker_web.Models;
using Sticker_web.Repository.Interfaces;

namespace Sticker_web.Repository
{
    public class CourierRepository : Repository<Courier>, ICourierRepository
    {
        private readonly ApplicationDbContext _db;
        public CourierRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Courier obj)
        {
            _db.Couriers.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
