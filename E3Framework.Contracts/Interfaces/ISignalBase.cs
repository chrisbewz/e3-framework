using e3;

namespace E3Framework.Contracts.Interfaces;

public interface ISignalBase
{
    string Name { get; set;}

    IEnumerable<IAttributeBase> Attributes { get; set;}
}