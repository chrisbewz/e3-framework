using e3;
using E3Framework.Contracts.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Job : JobAbstract
{
    
    private Job(int id)
    {
        this.Id = id;
    }
    
    private Job(int id, IJobInterface instance)
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