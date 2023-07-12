using e3;
using E3Framework.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Job : JobAbstract
{
    
    private Job(int id) : base(id)
    {
        this.Id = id;
    }
    
    private Job(int id, IJobInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static Job FromId(int id)
    {
        return new Job(id);
    }
    
    public static Job FromId(int id, IJobInterface instance)
    {
        return new Job(id, instance);
    }
    
    
}