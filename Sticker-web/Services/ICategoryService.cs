using Sticker_web.Models;

namespace Sticker_web.Services
{
    public interface ICategoryService
    {
        Task AddAsync(Category obj);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetAsync(int id);
        Task RemoveAsync(Category obj);
        Task UpdateAsync(Category obj);
    }
}
