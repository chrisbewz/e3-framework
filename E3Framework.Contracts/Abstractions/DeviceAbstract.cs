using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class DeviceAbstract : ComponentAbstract, IDeviceBase
{
    public IDeviceInterface Instance { get; set; }

    public string Name { get; set; }
    public int Id { get; set; }

    public string Assembly { get; set; }

    public IEnumerable<IPinBase> Pins { get; set; }

    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public ICartesian Location { get; set; }
}