using LibrarySystem.Domain.Interfaces;
using LibrarySystem.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LibrarySystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddSingleton<ILivroRepository, LivroRepositoryEmMemoria>();

        return services;
    }
}