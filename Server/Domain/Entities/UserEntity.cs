using Domain.Entities.Base;

namespace Domain.Entities;

public class UserEntity : BaseEntity
{
    private UserEntity()
    {
    }

    public UserEntity(Guid id, string? name, string? email, string? password, string? token, string? refreshToken,
        DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        Token = token;
        RefreshToken = refreshToken;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    public UserEntity(string? name, string? email, string? password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now;
    }

    public string? Name { get; private set; }
    public string? Email { get; private set; }
    public string? Password { get; private set; }
    public string? Token { get; private set; }
    public string? RefreshToken { get; private set; }
}