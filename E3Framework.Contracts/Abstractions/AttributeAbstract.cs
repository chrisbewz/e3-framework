using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class AttributeAbstract : ComponentAbstract, IAttributeBase
{
    public IAttributeInterface Instance { get; set; }

    public int Id { get; set; }

    public string Value { get; set; }

    public string Name { get; set; }

    public string InternalName { get; set; }

    public string FormattedValue { get; set; }

    public string Owner { get; set; }

    public IEnumerable<int> TextIds { get; set; }
}