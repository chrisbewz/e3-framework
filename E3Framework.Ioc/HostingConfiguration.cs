using e3;
using E3Framework.BaseTypes.Wrappers;
using Microsoft.Extensions.DependencyInjection;

namespace E3Framework.Ioc;

public partial class HostingContainer
{

    private IApplicationInterface ConfigureDispatcher()
    {
        var dispatch = DispatcherExtensions.CreateDispatcherWithInstance();
        return (IApplicationInterface)dispatch.ActiveInstance;
    }
    
    private readonly Func<IServiceProvider,IAttributeInterface> ConfigureAttributes = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (IAttributeInterface)job?.CreateAttributeObject()!;
    };

    private readonly Func<IServiceProvider,IJobInterface> ConfigureJob = (IServiceProvider pr) =>
    {
        var app = pr.GetService<IApplicationInterface>();
        return (IJobInterface)app?.CreateJobObject()!;
    };
    
    private readonly Func<IServiceProvider,IPinInterface> ConfigurePins = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (IPinInterface)job?.CreatePinObject()!;
    };
    
    private readonly Func<IServiceProvider,IDeviceInterface> ConfigureDevices = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (IDeviceInterface)job?.CreateDeviceObject()!;
    };
    
    private readonly Func<IServiceProvider,ISymbolInterface> ConfigureSymbols = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (ISymbolInterface)job?.CreateSymbolObject()!;
    };
    
    private readonly Func<IServiceProvider,IConnectionInterface> ConfigureConnections = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (IConnectionInterface)job?.CreateConnectionObject()!;
    };
    
    private readonly Func<IServiceProvider,IDimensionInterface> ConfigureDimensions = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (IDimensionInterface)job?.CreateDimensionObject()!;
    };
    
    private readonly Func<IServiceProvider,ISheetInterface> ConfigureSheets = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (ISheetInterface)job?.CreateSheetObject()!;
    };
    
    private readonly Func<IServiceProvider,ISignalInterface> ConfigureSignals = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (ISignalInterface)job?.CreateSignalObject()!;
    };
    
    private readonly Func<IServiceProvider,INetInterface> ConfigureNets = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (INetInterface)job?.CreateNetObject()!;
    };
    
    private readonly Func<IServiceProvider,INetSegmentInterface> ConfigureNetSegments = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (INetSegmentInterface)job?.CreateNetSegmentObject()!;
    };
    
    private readonly Func<IServiceProvider,ITextInterface> ConfigureTexts = (IServiceProvider pr) =>
    {
        var job = pr.GetService<IJobInterface>();
        return (ITextInterface)job?.CreateTextObject()!;
    }; 
}
