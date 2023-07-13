using System.Runtime.CompilerServices;
using e3;
using E3Framework.Abstractions;
using E3Framework.Abstractions.Types;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Symbol : SymbolAbstract
{
    
    private Symbol(int id) : base(id)
    {
        this.Id = id;
    }
    
    private Symbol(int id, ISymbolInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static Symbol FromId(int id)
    {
        return new Symbol(id);
    }
    
    public static Symbol FromId(int id, ISymbolInterface instance)
    {
        return new Symbol(id, instance);
    }
}