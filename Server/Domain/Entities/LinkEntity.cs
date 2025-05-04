using Domain.Entities.Base;

namespace Domain.Entities;

public class LinkEntity : BaseEntity
{
    public LinkEntity(Guid userId, string fullUrl, string shortUrl, DateTime expireTime)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        FullUrl = fullUrl;
        ShortUrl = shortUrl;
        ExpireTime = expireTime;
        CreatedAt = DateTime.Now;
    }
    public LinkEntity(Guid id, Guid userId, string? fullUrl, string? shortUrl, DateTime expireTime, DateTime createdAt,
        DateTime updatedAt)
    {
        Id = id;
        UserId = userId;
        FullUrl = fullUrl;
        ShortUrl = shortUrl;
        ExpireTime = expireTime;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
    private LinkEntity()
    {
    }
    public Guid UserId { get; private set; }
    public string? FullUrl { get; private set; }
    public string? ShortUrl { get; private set; }
    public DateTime ExpireTime { get; private set; }
    public UserEntity User { get; set; }
    public ICollection<AccessEntity>? Access { get; set; }
}