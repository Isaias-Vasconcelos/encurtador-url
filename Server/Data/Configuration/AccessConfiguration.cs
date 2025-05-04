using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class AccessConfiguration:IEntityTypeConfiguration<AccessEntity>
{
    public void Configure(EntityTypeBuilder<AccessEntity> builder)
    {
        builder.ToTable("Access");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.LinkId).IsRequired();
        builder.Property(x => x.Device).IsRequired();
        
        builder.HasOne(p => p.Link)
            .WithMany(p => p.Access)
            .HasForeignKey(p => p.LinkId)
            .HasConstraintName("FK_Access_Link")
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}