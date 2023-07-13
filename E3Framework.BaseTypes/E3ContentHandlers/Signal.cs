using e3;
using E3Framework.Abstractions;
using E3Framework.Abstractions.Types;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Signal : SignalAbstract
{
    private Signal(int id) : base(id)
    {
        this.Id = id;
    }
    
    private Signal(int id, ISignalInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static Signal FromId(int id)
    {
        return new Signal(id);
    }
    
    public static Signal FromId(int id, ISignalInterface instance)
    {
        return new Signal(id, instance);
    }
}