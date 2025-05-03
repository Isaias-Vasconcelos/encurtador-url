using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class AccessConfiguration:IEntityTypeConfiguration<AccessEntity>
{
    public void Configure(EntityTypeBuilder<AccessEntity> builder)
    {
    }
}