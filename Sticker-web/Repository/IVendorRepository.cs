using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task UpdateAsync(Vendor obj);
    }
}
