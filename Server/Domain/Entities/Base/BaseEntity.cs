namespace Domain.Entities.Base;

public class BaseEntity
{
    public virtual Guid Id { get; protected set; }
    public virtual DateTime CreatedAt { get; protected set; }
    public virtual DateTime UpdatedAt { get; protected set; }
}