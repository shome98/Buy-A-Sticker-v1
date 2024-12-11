using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task UpdateAsync(Category obj);
    }
}
