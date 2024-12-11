using Sticker_web.Models;

namespace Sticker_web.Repository.Interfaces
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        Task UpdateAsync(OrderHeader obj);
        Task UpdateStatusAsync(int id, string orderStatus, string? paymentStatus = null);
        Task UpdateStripePaymentIdAsync(int id, string sessionId, string paymentIntentId);
    }
}
