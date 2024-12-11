using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface ICourierRepository : IRepository<Courier>
    {
        Task UpdateAsync(Courier obj);
    }
}
