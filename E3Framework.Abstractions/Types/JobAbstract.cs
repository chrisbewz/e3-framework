using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class JobAbstract : ComponentAbstract<IJobInterface>, IJobBase
{
    protected JobAbstract(int id, IJobInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected JobAbstract(int id)
    {
        this.Id = id;
    }
}