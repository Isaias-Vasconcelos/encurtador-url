using Domain.Entities.Base;

namespace Domain.Entities;

public class WebhookEntity:BaseEntity
{
    private WebhookEntity(){}
    public WebhookEntity(Guid id, string name, string description, Guid userId, string? callbackUrl, bool isNewAccess, bool isNewLink, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        UserId = userId;
        CallbackUrl = callbackUrl;
        IsNewAccess = isNewAccess;
        IsNewLink = isNewLink;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    public string? Name { get;private set; }
    public string? Description { get;private set; }
    public Guid UserId { get;private set; }
    public string? CallbackUrl { get;private set; }
    public bool IsNewAccess { get;private set; }
    public bool IsNewLink { get;private set; }
    public UserEntity? User { get; set; }
}