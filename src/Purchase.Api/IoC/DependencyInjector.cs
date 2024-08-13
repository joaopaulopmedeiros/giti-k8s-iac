namespace Purchase.Api.IoC;

public static class DependencyInjector 
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services.AddTransient<PurchaseService>();
        return services;
    }
}