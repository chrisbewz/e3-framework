using System.Buffers;
using System.Reflection;
using e3;
using E3Framework.Abstractions;
using Attribute = E3Framework.BaseTypes.E3ContentHandlers.Attribute;

namespace E3Framework.Extensions;

public static class ComponentExtensions
{
    public static async Task<Tout[]> AsPoolAsync<Tin, Tout>(this Tin instance, IEnumerable<int> ids)
    {
        var minLength = ids.Count();
        try
        {
            var pool = ArrayPool<Tout>.Shared.Rent(minLength);
            pool = ArrayPool<Tout>.Shared.Rent(minLength);
            var methods = instance.GetExtensions();
            var method = methods.First(meth => meth.Name.Equals("CreateAsync"));

            if (method != null)
            {
                for (int i = 0; i < minLength; i++)
                {
                    
                    var result = await method?.InvokeAsync(instance, new object[] { instance,ids.ElementAt(i) });
                    pool[i] = (Tout)result;
                }
            }
            return pool;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            
        }
    }
    public static IEnumerable<MethodInfo> GetExtensions<T>(this T typeObj)
    {
        var methods = (IEnumerable<MethodInfo>)default;
        try
        {
            var query = from type in Assembly.GetExecutingAssembly().GetTypes()
                where !type.IsGenericType && !type.IsNested
                from method in type.GetMethods(BindingFlags.Static
                                               | BindingFlags.Public | BindingFlags.NonPublic)
                where method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false)
                where method.GetParameters()[0].ParameterType == typeof(T)
                select method;
            return query;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return methods;
    }
    public static async Task<object> InvokeAsync(this MethodInfo @this, object obj, params object[] parameters)
    {
        var task = (Task)@this.Invoke(obj, parameters);
        await task.ConfigureAwait(false);
        var resultProperty = task.GetType().GetProperty("Result");
        return resultProperty.GetValue(task);
    }
    public static async Task<IEnumerable<Attribute>> ConfigureAttributes<TComponent>(this TComponent component,IAttributeInterface attRef)
    {
        List<Attribute> attributes = new List<Attribute>();
        try
        {
            var castComponent = (dynamic)component!;
            castComponent.Instance.SetId(castComponent.Id);
            object attIds = default!;
            castComponent.Instance.GetAttributeIds(ref attIds);
            var content = ((object[])attIds)
                .Skip(1)
                .Cast<int>();

            foreach (var attId in content)
            {
                var created = await attRef.CreateAsync(attId);
                attributes.Add(created);
            }
            return attributes;
        }
        catch (NullReferenceException nullEx)
        {
            throw nullEx;
        }
        finally
        {
            
        }
    }
}