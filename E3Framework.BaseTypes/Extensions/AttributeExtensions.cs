using System.Reflection;
using e3;
using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;
using Attribute = E3Framework.BaseTypes.E3ContentHandlers.Attribute;

namespace E3Framework.BaseTypes.Extensions;

public static class AttributeExtensions
{
    // public static IEnumerable<IAttributeBase> Map(this int parentId)
    // {
    //     
    // }
    
    public static IEnumerable<IAttributeBase> Map(this IDeviceInterface parent,int id)
    {
        object attIds = new object[]{};
        var result = new List<IAttributeBase>();
        
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
    
}