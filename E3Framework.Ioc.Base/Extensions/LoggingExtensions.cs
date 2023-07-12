using Microsoft.Extensions.Hosting;

namespace E3Framework.Ioc.Base.Extensions;

public static class LoggingExtensions
{
    public static IHostBuilder ConfigureLogging(this IHostBuilder builder)
    {
        return builder;
    }
}