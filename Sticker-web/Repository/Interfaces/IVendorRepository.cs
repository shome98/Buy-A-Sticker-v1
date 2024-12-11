using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task UpdateAsync(Vendor obj);
    }
}
