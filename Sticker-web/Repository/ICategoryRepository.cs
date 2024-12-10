using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task UpdateAsync(Category obj);
    }
}
