using LibrarySystem.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibrarySystem.Application;


public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<LivroAppService>();

        return services;
    }
}