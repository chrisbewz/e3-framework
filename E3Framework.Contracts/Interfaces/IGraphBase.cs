using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IGraphBase
{
    IEnumerable<IAttributeBase> Attributes { get; set; }

    int ParentId { get; set; }

    string Name { get; set; }
}