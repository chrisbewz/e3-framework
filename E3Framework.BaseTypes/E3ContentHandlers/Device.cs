using System.Net.Mail;
using e3;
using E3Framework.Abstractions;
using E3Framework.Abstractions.Types;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Device : DeviceAbstract
{
    private Device(int id): base(id)
    {
        this.Id = id;
    }

    private Device(int id, IDeviceInterface instance): base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }

    public static Device FromId(int id)
    {
        return new Device(id);
    }
    
    public static Device FromId(int id, IDeviceInterface instance)
    {
        return new Device(id,instance);
    }

    // public override async Task Init()
    // {
    //     this.Instance.SetId(this.Id);
    //     this.Attributes = await this.ConfigureAttributes();
    // }
}