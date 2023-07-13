using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3DllProxy
    {
        
        public static int CallExt<T>(this ProxyBase<T> proxyRef,string method, string item1 = "-353353", string item2 = "-353353", string item3 = "-353353",
            string item4 = "-353353", string item5 = "-353353") where T : IDllInterface
        {
            return proxyRef.Instance.Call(method, item1, item2, item3, item4, item5);
        }

        public static int LoadExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDllInterface
        {
            return proxyRef.Instance.Load(name);
        }

        public static int UnloadExt<T>(this ProxyBase<T> proxyRef) where T : IDllInterface
        {
            return proxyRef.Instance.Unload();
        }
        
    }
}