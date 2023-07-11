using e3;
using E3Framework.Contracts.Enumerations;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class SymbolAbstract : ComponentAbstract, ISymbolBase
{
    public ISymbolInterface Instance { get; set; }

    public int Id { get; set;}

    public IArea PlacedArea { get; set;}

    public IArea CommomArea { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}

    public int Level { get; set;}

    public string Name { get; set;}

    public double Scale { get; set;}

    public ICartesian SchemaLocation { get; set;}

    public string Version { get; set;}

    public SymbolCodes Code { get; set;}

    public SymbolStates GraphicState { get; set;}

    public bool HasWiresAttached { get; set;}

    public IDisplayInfo DisplayInfo { get; set;}

    public ISymbolStyle Style { get; set;}
}