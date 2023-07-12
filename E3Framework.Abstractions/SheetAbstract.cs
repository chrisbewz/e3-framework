using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class SheetAbstract : ComponentAbstract<ISheetInterface>, ISheetBase
{
    public string Name { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}

    public IEnumerable<IGraphBase> Graphics { get; set;}

    public IArea DrawingArea { get; set;}

    public IEnumerable<INetSegmentBase> NetSegments { get; set;}

    public IEnumerable<ISymbolBase> Symbols { get; set;}
    
    protected SheetAbstract(int id, ISheetInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected SheetAbstract(int id)
    {
        this.Id = id;
    }
}