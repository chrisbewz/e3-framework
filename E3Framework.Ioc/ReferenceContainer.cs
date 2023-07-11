using Autofac;
using e3;
using E3Framework.BaseTypes.Wrappers;
using Microsoft.Extensions.DependencyInjection;
namespace E3Framework.Ioc;

public partial class ReferenceContainer : IContainerProvider
{
    public IServiceProvider Services { get; set; }

    public ReferenceContainer()
    {
        this.Services = this.ConfigureServices().BuildServiceProvider();
    }

    public void Build()
    {
        
    }

    private ServiceCollection ConfigureServices()
    {
        
        var services = new ServiceCollection();

        services.AddSingleton<IApplicationInterface>(s => ConfigureDispatcher());
        services.AddTransient<IJobInterface>(s => ConfigureJob(s));
        services.AddTransient<IDeviceInterface>(s => ConfigureDevices(s));
        services.AddTransient<IPinInterface>(s => ConfigurePins(s));
        services.AddTransient<ISymbolInterface>(s => ConfigureSymbols(s));
        services.AddTransient<IConnectionInterface>(s => ConfigureConnections(s));
        services.AddTransient<IDimensionInterface>(s => ConfigureDimensions(s));
        services.AddTransient<ISheetInterface>(s => ConfigureSheets(s));
        services.AddTransient<ISignalInterface>(s => ConfigureSignals(s));
        services.AddTransient<INetSegmentInterface>(s => ConfigureNetSegments(s));
        services.AddTransient<INetInterface>(s => ConfigureNets(s));
        services.AddTransient<ITextInterface>(s => ConfigureTexts(s));
        
        return services;
    }

}