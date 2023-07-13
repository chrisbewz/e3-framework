using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ConnectLineProxy
    {
        public static int AddProtectionSymbolIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IConnectLineInterface
        {
            return proxyRef.Instance.AddProtectionSymbolId(id);
        }

        public static int GetCoordinatesExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr, ref object zarr) where T : IConnectLineInterface
        {
            return proxyRef.Instance.GetCoordinates(ref xarr, ref yarr, ref zarr);
        }

        public static int GetCoordinatesExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr, ref object zarr, ref object PointTypArr) where T : IConnectLineInterface
        {
            return proxyRef.Instance.GetCoordinates(ref xarr, ref yarr, ref zarr, ref PointTypArr);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IConnectLineInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetProtectionSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectLineInterface
        {
            return proxyRef.Instance.GetProtectionSymbolIds(ref ids);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IConnectLineInterface
        {
            return proxyRef.Instance.SetId(id);
        }
    }
}