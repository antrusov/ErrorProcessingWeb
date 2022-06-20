namespace ErrorProcessingWeb.Extensions;

public static class LazyEx
{
    public static void AddLazyScoped<T>(this IServiceCollection services)
    {
        services.AddScoped<Lazy<T>>();
    }

    public static void AddLazyTransient<T>(this IServiceCollection services)
    {
        services.AddTransient<Lazy<T>>();
    }

    public static void AddLazySingleton<T>(this IServiceCollection services)
    {
        services.AddSingleton<Lazy<T>>(); //но вообще Lazy-синглтон странная концепция (это же синглтон)
    }
}