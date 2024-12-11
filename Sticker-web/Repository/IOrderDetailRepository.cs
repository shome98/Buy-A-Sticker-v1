using Sticker_web.Models;

namespace Sticker_web.Repository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        Task UpdateAsync(OrderDetail obj);
    }
}
