using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ModulePortProxy
    {

        public static string GetBusNameExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetBusName();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetModuleIdExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetModuleId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetSignalIdExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetSignalId();
        }

        public static int GetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetSignalIds(ref ids);
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object OnBlockId, ref object OnSheetId) where T : IModulePortInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref OnBlockId, ref OnSheetId);
        }

        public static int IsBusExt<T>(this ProxyBase<T> proxyRef) where T : IModulePortInterface
        {
            return proxyRef.Instance.IsBus();
        }

        public static int SetBusNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModulePortInterface
        {
            return proxyRef.Instance.SetBusName(name);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IModulePortInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModulePortInterface
        {
            return proxyRef.Instance.SetName(name);
        }

    }
}