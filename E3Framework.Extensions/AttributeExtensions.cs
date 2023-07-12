using e3;
using E3Framework.Abstractions;
using E3Framework.Contracts.Interfaces;
using Attribute = E3Framework.BaseTypes.E3ContentHandlers.Attribute;

namespace E3Framework.Extensions;

public static class AttributeExtensions
{
    public static IEnumerable<Attribute> Create(this IDeviceInterface parent, int id)
    {
        object attIds = new object[]{};
        var result = new List<Attribute>();
        
        try
        {
            var res = parent.SetId(id);

            if (res > 0)
            {
                parent.GetAttributeIds(ref attIds);
            }
            
            ((int[])attIds).AsEnumerable().AsParallel().ForAll(attid =>
            {
                result.Add(Attribute.FromId(attid));
            });
        }
        catch
        {
            
        }
        return result;
    }
    public static async Task<Attribute> CreateAsync(this IAttributeInterface instance, int id)
    {
        var dev = Attribute.FromId(id, instance);
        await dev.Init();
        return dev;
    }
}