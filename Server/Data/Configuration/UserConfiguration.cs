using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class UserConfiguration:IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Password).IsRequired();
        
        builder.HasMany(p => p.Links)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .HasConstraintName("FK_User_Link")
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
        
        builder.HasMany(p => p.Webhooks)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .HasConstraintName("FK_User_Webhook")
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}