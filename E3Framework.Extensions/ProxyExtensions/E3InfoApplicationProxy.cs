using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3InfoApplicationProxy
    {

        public static string GetWindowPosExt<T>(this ProxyBase<T> proxyRef,double x, double y, string text) where T : IInfoApplicationInterface
        {
            return proxyRef.Instance.GetWindowPos(x, y, text);
        }
        
    }
}