using Serilog;

namespace PimoBlazorWasmHostedTemplate.Server;

public static class DependencyInjection
{
    public static IServiceCollection AddServer(
        this IServiceCollection services,
        ConfigureHostBuilder hostBuilder
    )
    {
        hostBuilder.UseSerilog();
        Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        #if UseControllers
        services.AddControllersWithViews();
        #endif

        services.AddEndpointsApiExplorer();
        services.AddHealthChecks();
        services.AddRazorPages();
        services.AddCors();
        services.AddSwaggerGen();

        return services;
    }
}
