using e3;
using E3Framework.Abstractions;
using E3Framework.Abstractions.Types;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Sheet : SheetAbstract
{
    
    private Sheet(int id) : base(id)
    {
        this.Id = id;
    }
    
    private Sheet(int id, ISheetInterface instance) : base(id, instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    public static Sheet FromId(int id)
    {
        return new Sheet(id);
    }
    
    public static Sheet FromId(int id, ISheetInterface instance)
    {
        return new Sheet(id, instance);
    }
}