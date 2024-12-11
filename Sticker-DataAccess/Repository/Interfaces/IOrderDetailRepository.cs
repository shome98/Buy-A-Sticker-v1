using Sticker_Models.Models;

namespace Sticker_DataAccess.Repository.Interfaces
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        Task UpdateAsync(OrderDetail obj);
    }
}
