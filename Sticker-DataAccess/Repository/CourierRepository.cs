using Sticker_Models.Models;
using Sticker_DataAccess.Data;
using Sticker_DataAccess.Repository.Interfaces;

namespace Sticker_DataAccess.Repository
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
