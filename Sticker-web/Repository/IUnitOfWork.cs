namespace Sticker_web.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        Task SaveAsync();
    }
}
