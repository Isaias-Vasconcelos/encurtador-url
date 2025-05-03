using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

public class WebhookConfiguration:IEntityTypeConfiguration<WebhookEntity>
{
    public void Configure(EntityTypeBuilder<WebhookEntity> builder)
    {
    }
}