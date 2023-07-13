using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3BoardProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name) where T : IBoardInterface
        {
            return proxyRef.Instance.Create(name);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef)where T : IBoardInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetLayerIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids)where T : IBoardInterface
        {
            return proxyRef.Instance.GetLayerIds(ref ids);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IBoardInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetOutlineIdExt<T>(this ProxyBase<T> proxyRef) where T : IBoardInterface
        {
            return proxyRef.Instance.GetOutlineId();
        }

        public static int GetSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBoardInterface
        {
            return proxyRef.Instance.GetSheetIds(ref ids);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IBoardInterface
        {
            return proxyRef.Instance.SetId(id);
        }
    }
}