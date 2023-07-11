using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class SignalAbstract : ComponentAbstract, ISignalBase
{
    public ISignalInterface Instance { get; set; }

    public int Id { get; set;}

    public string Name { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}
}