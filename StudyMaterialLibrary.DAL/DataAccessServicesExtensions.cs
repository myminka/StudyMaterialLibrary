using Microsoft.Extensions.DependencyInjection;
using StudyLibrary.DataAccess.Abstractions.Providers;
using StudyLibrary.DataAccess.Providers;

namespace StudyLibrary.DataAccess;

public static class DataAccessServicesExtensions
{
    public static IServiceCollection AddProviders(this IServiceCollection services)
    {
        services.AddScoped<IUserProvider, UserProvider>();

        return services;
    }
}
