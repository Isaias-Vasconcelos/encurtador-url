using Data.Context;
using Domain.Interfaces;
using Domain.Interfaces.Uof;

namespace Data.Repositories.Uof;

public class UnitOfWork(ApplicationContext context) : IUnitOfWork
{
    private readonly ApplicationContext _context = context;

    public void Dispose()
    {
        _context.Dispose();
    }

    private ILinkRepository? _linkRepository;
    private IUserRepository? _userRepository;
    private IAccessRepository? _accessRepository;
    private IWebhookRepository? _webhookRepository;
    
    public ILinkRepository LinkRepository => _linkRepository ??= new LinkRepository(_context);
    public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
    public IAccessRepository AccessRepository => _accessRepository ??= new AccessRepository(_context);
    public IWebhookRepository WebhookRepository => _webhookRepository ??= new WebhookRepository(_context);
    
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}