using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Enumerations;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class SymbolAbstract : ComponentAbstract<ISymbolInterface>, ISymbolBase
{
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
    
    protected SymbolAbstract(int id, ISymbolInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected SymbolAbstract(int id)
    {
        this.Id = id;
    }
}