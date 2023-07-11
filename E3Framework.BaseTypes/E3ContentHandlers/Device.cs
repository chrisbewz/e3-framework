using System.Net.Mail;
using e3;
using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;
using E3Framework.BaseTypes.Extensions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Device : DeviceAbstract
{
    private Device(int id)
    {
        this.Id = id;
        Task.Factory.StartNew(this.Init);
    }
    
    private Device(int id, IDeviceInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
        Task.Factory.StartNew(this.Init);
    }

    public static Device FromId(int id)
    {
        return new Device(id);
    }
    
    public static Device FromId(int id, IDeviceInterface instance)
    {
        return new Device(id,instance);
    }

    public override async Task Init()
    {
        this.Instance.SetId(this.Id);
        this.Attributes = await this.ConfigureAttributes();
    }
}