using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IGraphBase : IComponentBase<IGraphInterface>
{
    IEnumerable<IAttributeBase> Attributes { get; set; }

    int ParentId { get; set; }

    string Name { get; set; }
}