using e3;
using E3Framework.Contracts.Abstractions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class NetSegment : NetSegmentAbstract
{
    
    private NetSegment(int id)
    {
        this.Id = id;
    }
    
    private NetSegment(int id, INetSegmentInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static NetSegment FromId(int id)
    {
        return new NetSegment(id);
    }
    
    public static NetSegment FromId(int id, INetSegmentInterface instance)
    {
        return new NetSegment(id, instance);
    }
}