using Sticker_Models.Models;
using Sticker_DataAccess.Data;
using Sticker_DataAccess.Repository.Interfaces;

namespace Sticker_DataAccess.Repository
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
