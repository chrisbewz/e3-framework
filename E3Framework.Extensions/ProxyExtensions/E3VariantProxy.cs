using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3VariantProxy
    {

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name) where T : IVariantInterface
        {
            return proxyRef.Instance.Create(name);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef,int del) where T : IVariantInterface
        {
            return proxyRef.Instance.Delete(del);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IVariantInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IVariantInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int IsActiveExt<T>(this ProxyBase<T> proxyRef) where T : IVariantInterface
        {
            return proxyRef.Instance.IsActive();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name) where T : IVariantInterface
        {
            return proxyRef.Instance.Search(name);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IVariantInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IVariantInterface
        {
            return proxyRef.Instance.SetName(name);
        }
    }
}