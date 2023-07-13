using e3;
using E3Framework.Abstractions;
using E3Framework.Abstractions.Types;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Pin : PinAbstract
{
    
    private Pin(int id, IPinInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    private Pin(int id) : base(id)
    {
        this.Id = id;
    }

    public static Pin FromId(int id, IPinInterface instance)
    {
        return new Pin(id,instance);
    }

    public override async Task Init()
    {
        // await this.ConfigureAttributes();
    }
    

}