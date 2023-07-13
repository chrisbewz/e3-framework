using System.Linq;
using e3;
using E3Framework.BaseTypes.E3ContentHandlers;
using E3Framework.Extensions;
using E3Framework.Extensions.ProxyExtensions;
using E3Framework.Ioc;
using Xunit;

namespace E3Framework.Tests.NetFramework48;

public class ProxyClassTests
{
    private readonly HostingContainer _provider;
    public ProxyClassTests()
    {
        this._provider = HostingContainer.Build();
    }

    [Fact]
    private void TestProxyCallFromComponentAbstract()
    {
        var _app = _provider.Require<IApplicationInterface>();
        var job = (IJobInterface)_app.CreateJobObject();
        Job j = Job.FromId(0, job);
        object devId = default;
        var id = j.GetActiveSheetIdExt();
        Assert.NotNull(id);
    }
}