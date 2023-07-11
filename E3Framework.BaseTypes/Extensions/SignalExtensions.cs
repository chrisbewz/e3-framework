using e3;
using E3Framework.Contracts.Interfaces;
using Attribute = E3Framework.BaseTypes.E3ContentHandlers.Attribute;
namespace E3Framework.BaseTypes.Extensions;

public static class SignalExtensions
{
    public static async Task<IEnumerable<IAttributeBase>> ConfigureAttributes(this IComponentBase<ISignalInterface> component, IAttributeInterface instance)
    {
        var id = component.Id;
        var attributesRead = new List<IAttributeBase>();
        
        if (component != null)
        {
            
        }
        
        var res = component.Instance.SetId(id);
        var parser = new Task<IEnumerable<IAttributeBase>>(() =>
        {
            object attIds = (object)default;
            if (res > 0)
            {
                component.Instance.GetAttributeIds(ref attIds);
            }

            (attIds as object[])?.AsEnumerable()?.AsParallel().ForAll(attId => { attributesRead.Add(Attribute.FromId((int)attId)); });

            return attributesRead;
        });
        return await parser;
    }
}