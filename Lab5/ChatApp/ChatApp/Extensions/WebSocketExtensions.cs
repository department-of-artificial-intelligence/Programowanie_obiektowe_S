using System.Reflection;

public static class WebSocketExtensions
{
    public static IApplicationBuilder MapWebSocketManager(this IApplicationBuilder app, PathString path, WebSocketHandler handler)
    {
        return app.Map(path, (_app) => _app.UseMiddleware<WebSocketManagerMiddleware>(handler));
    }

    public static IServiceCollection AddWebSocketManager(this IServiceCollection services)
    {
        services.AddTransient<ConnectionManager>();

        foreach (var type in Assembly.GetEntryAssembly().ExportedTypes)
        {
            if (type.GetTypeInfo().BaseType == typeof(WebSocketHandler))
            {
                services.AddSingleton(type);
            }
        }
        return services;
    }
}