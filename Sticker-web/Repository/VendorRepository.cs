using Sticker_web.Data;
using Sticker_web.Models;
using Sticker_web.Repository.Interfaces;

namespace Sticker_web.Repository
{
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        private readonly ApplicationDbContext _db;

        public VendorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Vendor obj)
        {
            _db.Vendors.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
