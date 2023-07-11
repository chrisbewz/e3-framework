using e3;
using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;
using E3Framework.BaseTypes.Extensions;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Pin : PinAbstract
{
    
    private Pin(int id, IPinInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
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