using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class GraphicAbstract : ComponentAbstract, IGraphBase
{
    public IGraphInterface Instance { get; set; }

    public int Id { get; set; }

    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; }
    
    
}