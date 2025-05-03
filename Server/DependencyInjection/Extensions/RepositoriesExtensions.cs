using Data.Repositories.Generic;
using Domain.Interfaces.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Extensions;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        return services;
    }
}