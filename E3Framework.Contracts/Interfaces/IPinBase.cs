using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IPinBase
{
    IEnumerable<IAttributeBase> Attributes { get; set;}
}