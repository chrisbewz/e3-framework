using System;
using System.Collections.Generic;
using System.Linq;
using e3;
using E3Framework.BaseTypes.E3ContentHandlers;
using E3Framework.BaseTypes.Wrappers;
using E3Framework.Ioc;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace E3Framework.Tests.NetFramework48;

public class JobInterfaceTests
{
    private ReferenceContainer _provider;
    public JobInterfaceTests()
    {
        this._provider = new ReferenceContainer();
    }
    
    [Fact]
    public void TestDeviceReadingFromClass()
    {
        
        var devs = new List<Device>();
        var _app = _provider.Services.GetService<IApplicationInterface>();
        var job = (IJobInterface)_app.CreateJobObject();
        Job j = Job.FromId(0, job);
        object devId = default;
            
        var devCount = job.GetAllDeviceIds(ref devId);

        foreach (var id in ((object[])devId).AsEnumerable().Skip(1))
        {
            devs.Add(Device.FromId((int)id, (IDeviceInterface)job.CreateDeviceObject()));
        }
        Console.WriteLine("");
    }
}