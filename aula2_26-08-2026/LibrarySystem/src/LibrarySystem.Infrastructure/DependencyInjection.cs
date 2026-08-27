using LibrarySystem.Domain.Interfaces;
using LibrarySystem.Infrastructure.Repositories;
using LibrarySystem.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibrarySystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ILivroRepository, LivroRepositoryEmMemoria>();
        services.AddSingleton<IServicoNotificacao, ConsoleNotificacaoService>();

        return services;
    }
}