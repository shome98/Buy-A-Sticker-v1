using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public interface ICourierRepository : IRepository<Courier>
    {
        Task UpdateAsync(Courier obj);
    }
}
