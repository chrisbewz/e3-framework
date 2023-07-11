using e3;
using E3Framework.Contracts.Enumerations;

namespace E3Framework.Contracts.Interfaces;

public interface ISymbolBase : IComponentBase<ISymbolInterface>
{
    IArea PlacedArea { get;set; }

    IArea CommomArea { get; set;}

    IEnumerable<IAttributeBase> Attributes { get; set;}

    int Level { get; set;}

    string Name { get; set;}

    double Scale { get; set;}

    ICartesian SchemaLocation { get; set;}

    string Version { get; set;}

    SymbolCodes Code { get;set; }

    SymbolStates GraphicState { get; set;}

    bool HasWiresAttached { get; set;}

    IDisplayInfo DisplayInfo { get;set; }

    ISymbolStyle Style { get; set;}
}