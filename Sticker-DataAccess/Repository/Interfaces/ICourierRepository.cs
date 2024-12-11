using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface ICourierRepository : IRepository<Courier>
    {
        Task UpdateAsync(Courier obj);
    }
}
