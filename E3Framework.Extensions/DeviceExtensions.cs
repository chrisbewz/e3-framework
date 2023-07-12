using System.Buffers;
using e3;
using E3Framework.Abstractions;
using E3Framework.BaseTypes.E3ContentHandlers;

namespace E3Framework.Extensions;

public static class DeviceExtensions
{

    public static async Task<Device> CreateAsync(this int id, IDeviceInterface instance)
    {
        var dev = Device.FromId(id, instance);
        await dev.Init();
        return dev;
    }

    public static async Task<Device> CreateAsync(this IDeviceInterface instance, int id)
    {
        try
        {
            var dev = Device.FromId(id, instance);
            await dev.Init();
            return dev;
        }
        finally
        {
            
        }
    }

    public static async Task<IEnumerable<Device>> CreateAsync(this IDeviceInterface instance, IEnumerable<int> ids)
    {
        var minLength = ids.Count();
        try
        {
            var pool = ArrayPool<Device>.Shared.Rent(minLength);
            pool = ArrayPool<Device>.Shared.Rent(minLength);
            
            for (int i = 0; i < minLength; i++)
            {
                pool[i] = await instance.CreateAsync(ids.ElementAt(i));
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
}