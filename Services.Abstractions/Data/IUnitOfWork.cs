namespace Services.Abstractions.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        void RevertChanges();
    }
}
