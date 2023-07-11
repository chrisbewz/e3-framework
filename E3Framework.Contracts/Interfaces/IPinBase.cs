using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IPinBase : IComponentBase<IPinInterface>
{
    IEnumerable<IAttributeBase> Attributes { get; set;}
}