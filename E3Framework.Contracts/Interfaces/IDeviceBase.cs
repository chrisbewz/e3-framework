using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IDeviceBase : IComponentBase<IDeviceInterface>
{
    string Name { get; set; }

    int Id { get; set; }

    string Assembly { get; set; }

    IEnumerable<IPinBase> Pins { get; set; }

    IEnumerable<IAttributeBase> Attributes { get; set; }

    ICartesian Location { get; set; }
}