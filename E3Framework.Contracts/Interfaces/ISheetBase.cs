using e3;

namespace E3Framework.Contracts.Interfaces;

public interface ISheetBase
{
    string Name { get; set;}

    IEnumerable<IAttributeBase> Attributes { get; set;}

    IEnumerable<IGraphBase> Graphics { get; set;}

    IArea DrawingArea { get; set;}

    IEnumerable<INetSegmentBase> NetSegments { get; set;}

    IEnumerable<ISymbolBase> Symbols { get; set;}
}