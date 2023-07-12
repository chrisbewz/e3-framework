using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class DeviceAbstract : ComponentAbstract<IDeviceInterface>, IDeviceBase
{
    public string Name { get; set; }

    public string Assembly { get; set; }

    public IEnumerable<IPinBase> Pins { get; set; }
    
    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public ICartesian Location { get; set; }
    
    protected DeviceAbstract(int id, IDeviceInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected DeviceAbstract(int id)
    {
        this.Id = id;
    }
}