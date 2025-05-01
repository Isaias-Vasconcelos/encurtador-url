using Domain.Entities.Base;

namespace Domain.Entities;

public class AccessEntity : BaseEntity
{
    private AccessEntity(){}

    public AccessEntity(Guid id, Guid linkId, string? device, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        LinkId = linkId;
        Device = device;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    public Guid LinkId { get; private set; }
    public string? Device { get; private set; }
}