using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class PinAbstract : ComponentAbstract, IPinBase
{
    public IPinInterface Instance { get; set; }

    public int Id { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}
}