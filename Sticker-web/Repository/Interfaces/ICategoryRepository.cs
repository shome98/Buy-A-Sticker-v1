using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task UpdateAsync(Category obj);
    }
}
