using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IAttributeBase : IComponentBase<IAttributeInterface>
{
    public string Value { get; set; }

    public string Name { get; set; }

    public string InternalName { get; set; }

    public string FormattedValue { get; set; }

    public string Owner { get; set; }

    public IEnumerable<int> TextIds { get; set; }
}