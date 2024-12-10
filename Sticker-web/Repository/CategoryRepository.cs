using Sticker_web.Data;
using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Category obj)
        {
            _db.Categories.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
