using e3;
using E3Framework.Contracts.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Graphic : GraphicAbstract
{
    private Graphic(int id)
    {
        this.Id = id;
    }
    
    private Graphic(int id, IGraphInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static Graphic FromId(int id)
    {
        return new Graphic(id);
    }
    
    public static Graphic FromId(int id, IGraphInterface instance)
    {
        return new Graphic(id, instance);
    }
}