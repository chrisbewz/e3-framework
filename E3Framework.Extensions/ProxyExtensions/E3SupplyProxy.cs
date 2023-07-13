using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SupplyProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int devid, string name) where T : ISupplyInterface
        {
            return proxyRef.Instance.Create(devid, name);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ISupplyInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int GetBlockIdExt<T>(this ProxyBase<T> proxyRef) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetBlockId();
        }

        public static int GetComponentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetComponentIds(ref ids);
        }

        public static int GetDevCompIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetDevCompIds(ref ids);
        }

        public static int GetDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetDeviceIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static string GetOwnerNameExt<T>(this ProxyBase<T> proxyRef) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetOwnerName();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetSignalIds(ref ids);
        }

        public static string GetSignalTypeNameExt<T>(this ProxyBase<T> proxyRef,int which) where T : ISupplyInterface
        {
            return proxyRef.Instance.GetSignalTypeName(which);
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,int devid, string name) where T : ISupplyInterface
        {
            return proxyRef.Instance.Search(devid, name);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISupplyInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISupplyInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISupplyInterface
        {
            return proxyRef.Instance.SetSignalIds(ref ids);
        }
    }
}