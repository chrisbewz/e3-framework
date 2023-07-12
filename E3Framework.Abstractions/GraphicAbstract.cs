using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class GraphicAbstract : ComponentAbstract<IGraphInterface>, IGraphBase
{
    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; }
    
    protected GraphicAbstract(int id, IGraphInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected GraphicAbstract(int id)
    {
        this.Id = id;
    }
}