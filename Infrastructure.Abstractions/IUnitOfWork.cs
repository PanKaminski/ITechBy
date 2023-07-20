namespace Infrastructure.Abstractions
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        void RevertChanges();
    }
}
