using System.Runtime.CompilerServices;
using e3;
using E3Framework.Contracts.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Symbol : SymbolAbstract
{
    
    private Symbol(int id)
    {
        this.Id = id;
    }
    
    private Symbol(int id, ISymbolInterface instance)
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