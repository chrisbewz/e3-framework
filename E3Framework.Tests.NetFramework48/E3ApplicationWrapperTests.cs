using Xunit;
using e3;
using E3Framework.BaseTypes.Wrappers;
using E3Framework.Ioc;

namespace E3Framework.Tests.NetFramework48;

public class E3ApplicationWrapperTests
{
    [Fact]
    public void TestDispatcherCreationFromActiveInstance()
    {
        var rot = DispatcherExtensions.CreateDispatcherWithInstance();
        Assert.True(rot != null);
    }

    [Fact]
    public void TestComObjectCastFromActiveDispatcher()
    {
        var rot = DispatcherExtensions.CreateDispatcherWithInstance();
        Assert.True((IApplicationInterface)rot.ActiveInstance != null);
    }
    
    [Fact]
    public void TestIocContainerInterfacesRegistry()
    {
        // var cont = new ReferenceContainer();
        // Assert.True(cont != null);
    }
}