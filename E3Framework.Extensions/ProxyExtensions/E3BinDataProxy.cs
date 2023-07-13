using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3BinDataProxy
    {
        public static int GetDataExt<T>(this ProxyBase<T> proxyRef,string name, ref object data, int maxlen) where T : IBinDataInterface
        {
            return proxyRef.Instance.GetData(name, ref data, maxlen);
        }

        public static int SetDataExt<T>(this ProxyBase<T> proxyRef,string name, ref object data, int maxlen) where T : IBinDataInterface
        {
            return proxyRef.Instance.SetData(name, ref data, maxlen);
        }
    }
}