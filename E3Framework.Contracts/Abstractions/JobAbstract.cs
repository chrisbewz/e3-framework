using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class JobAbstract : ComponentAbstract, IJobBase
{
    public IJobInterface Instance { get; set; }

    public int Id { get; set; }
}