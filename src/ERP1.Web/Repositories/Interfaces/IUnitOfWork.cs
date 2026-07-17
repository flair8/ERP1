namespace ERP1.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
