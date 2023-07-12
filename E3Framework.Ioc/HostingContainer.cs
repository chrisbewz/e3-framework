using e3;
using E3Framework.Contracts.Interfaces;
using E3Framework.Ioc.Base.Extensions;
using E3Framework.Ioc.Base.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace E3Framework.Ioc;

public partial class HostingContainer : ReferenceHandler
{

    private IHost _host;
    private HostingContainer() : base()
    {
        var args = new string[] { };
        this._host = ConfigureHost(args)
            .ConfigureLogging()
            .Build();
        

    }

    private void OnReferenceRequested(object sender, Type e)
    {
        Console.WriteLine("Hi! Im Invoked!");
    }

    public T? Require<T>()
    
    where T : class
    {
        return (T)this._host.Services.GetService<T>()!;
    }
    public static HostingContainer Build()
    {
        return new HostingContainer();
    }
    private IHostBuilder ConfigureHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                services
                    .AddSingleton<IApplicationInterface>(s => ConfigureDispatcher())
                    .AddTransient<IJobInterface>(s => ConfigureJob(s))
                    .AddTransient<IDeviceInterface>(s => ConfigureDevices(s))
                    .AddTransient<IPinInterface>(s => ConfigurePins(s))
                    .AddTransient<ISymbolInterface>(s => ConfigureSymbols(s))
                    .AddTransient<IConnectionInterface>(s => ConfigureConnections(s))
                    .AddTransient<IDimensionInterface>(s => ConfigureDimensions(s))
                    .AddTransient<ISheetInterface>(s => ConfigureSheets(s))
                    .AddTransient<ISignalInterface>(s => ConfigureSignals(s))
                    .AddTransient<INetSegmentInterface>(s => ConfigureNetSegments(s))
                    .AddTransient<INetInterface>(s => ConfigureNets(s))
                    .AddTransient<ITextInterface>(s => ConfigureTexts(s))
                    .AddTransient<IAttributeInterface>(s=> ConfigureAttributes(s));
            });
    }
}