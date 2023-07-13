using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SlotProxy
    {

        public static int GetFixTypeExt<T>(this ProxyBase<T> proxyRef) where T : ISlotInterface
        {
            return proxyRef.Instance.GetFixType();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISlotInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetMountTypeExt<T>(this ProxyBase<T> proxyRef) where T : ISlotInterface
        {
            return proxyRef.Instance.GetMountType();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISlotInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetPositionExt<T>(this ProxyBase<T> proxyRef,int point, ref object x, ref object y, ref object z) where T : ISlotInterface
        {
            return proxyRef.Instance.GetPosition(point, ref x, ref y, ref z);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISlotInterface
        {
            return proxyRef.Instance.SetId(id);
        }

    }
}