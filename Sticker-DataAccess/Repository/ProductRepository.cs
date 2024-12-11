using Microsoft.EntityFrameworkCore;
using Sticker_Models.Models;
using Sticker_DataAccess.Data;
using Sticker_DataAccess.Repository.Interfaces;

namespace Sticker_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Product obj)
        {
            var objFromDb = await _db.Products.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
            await _db.SaveChangesAsync();
        }
    }
}
