using OF.Data.Repository;
using OF.Manager.Implementation;
using OF.Manager.Interfaces.Manager;
using OF.Manager.Interfaces.Repositories;


namespace OF.WebApi.Configuration;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IUserManager, UserManager>();
    }
}
