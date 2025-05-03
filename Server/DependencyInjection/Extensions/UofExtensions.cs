using Data.Repositories.Uof;
using Domain.Interfaces.Uof;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Extensions;

public static class UofExtensions
{
    public static IServiceCollection AddUof(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}