using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e3;
using E3Framework.BaseTypes.E3ContentHandlers;
using E3Framework.Contracts.Interfaces;
using E3Framework.Exceptions;
using E3Framework.Extensions;
using E3Framework.Ioc;
using Xunit;
using Attribute = E3Framework.BaseTypes.E3ContentHandlers.Attribute;

namespace E3Framework.Tests.NetFramework48;

public class DeviceTests
{
    private readonly HostingContainer _provider;
    public DeviceTests()
    {
        this._provider = HostingContainer.Build();
    }
    
    [Fact]
    private async Task TestAttributeInitializingAsync()
    {
        var _app = _provider.Require<IApplicationInterface>();
        var job = (IJobInterface)_app.CreateJobObject();
        Job j = Job.FromId(0, job);
        object devId = default;
        var devCount = job.GetAllDeviceIds(ref devId);
        var id = (devId as object[])?.Skip(1).Cast<int>();

        var res = await _provider.Require<IDeviceInterface>()!
            .CreateAsync(id.First());
        var atts= await res.ConfigureAttributes(_provider.Require<IAttributeInterface>()!);
        Assert.True(atts != null && atts.Any());
    }
    
    [Fact]
    private async Task TestHeavyAttributeInitializingAsync()
    {
        var _app = _provider.Require<IApplicationInterface>();
        var job = (IJobInterface)_app.CreateJobObject();
        Job j = Job.FromId(0, job);
        object devId = default;
        var devCount = job.GetAllDeviceIds(ref devId);
        var id = (devId as object[])?.Skip(1).Cast<int>();
        var contents = new Dictionary<Device, IEnumerable<Attribute>>();

        foreach (var identifier in id)
        {
            Device res = await _provider.Require<IDeviceInterface>()!.CreateAsync(identifier);
            IEnumerable<Attribute> atts= await res.ConfigureAttributes(_provider.Require<IAttributeInterface>()!);
            contents.Add(res, atts);
        }
        
        Assert.True(contents != null && contents.Any());
    }

    [Fact]
    private async Task TestUndefinedServiceProviderInstanceForDevice()
    {
        Func<Task> act = () =>
        {
            var _app = _provider.Require<IApplicationInterface>();
            var job = (IJobInterface)_app.CreateJobObject();
            Job j = Job.FromId(0, job);
            object devId = default;
            var devCount = job.GetAllDeviceIds(ref devId);
            var id = (devId as object[])?.Skip(1).Cast<int>();

            IDeviceInterface c = (IDeviceInterface)default;
            
            return c.CreateAsync(id.First());
        };
        await Assert.ThrowsAsync<InstanceUndefinedException>(act);
    }
}