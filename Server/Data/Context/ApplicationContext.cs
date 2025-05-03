using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class ApplicationContext: DbContext
{
    public ApplicationContext(){}
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }
}