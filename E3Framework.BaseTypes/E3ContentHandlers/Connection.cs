using e3;
using E3Framework.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Connection : ConnectionAbstract
{
    
    private Connection(int id) : base(id)
    {
        this.Id = id;
    }

    private Connection(int id, IConnectionInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    public static Connection FromId(int id)
    {
        return new Connection(id);
    }
    
    public static Connection FromId(int id,IConnectionInterface instance)
    {
        return new Connection(id, instance);
    }
}