namespace Domain.Interfaces.Uof;

public interface IUnitOfWork
{
    ILinkRepository LinkRepository { get; }
    IUserRepository UserRepository { get; }
    IAccessRepository AccessRepository { get; }
    IWebhookRepository WebhookRepository { get; }
    Task CommitAsync();
    void Dispose();
}