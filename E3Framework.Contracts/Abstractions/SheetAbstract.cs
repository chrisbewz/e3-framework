using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class SheetAbstract : ComponentAbstract, ISheetBase
{
    public ISheetInterface Instance { get; set; }

    public int Id { get; set;}

    public string Name { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}

    public IEnumerable<IGraphBase> Graphics { get; set;}

    public IArea DrawingArea { get; set;}

    public IEnumerable<INetSegmentBase> NetSegments { get; set;}

    public IEnumerable<ISymbolBase> Symbols { get; set;}
}