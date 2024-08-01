namespace EcrOneClick.DI;

public static class ServiceHelper
{
    private static IServiceProvider Services { get; set; }

    public static void Initialize(IServiceProvider serviceProvider) => Services = serviceProvider;

    public static T? GetService<T>() => Services.GetService<T>();
}