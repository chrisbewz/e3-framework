using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3LayerProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name, int type, int copper, int layer_id, int before) where T : ILayerInterface
        {
            return proxyRef.Instance.Create(name, type, copper, layer_id, before);
        }

        public static int GetBoardLayerIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ILayerInterface
        {
            return proxyRef.Instance.GetBoardLayerIds(ref ids);
        }

        public static int GetId<T>(this ProxyBase<T> proxyRef) where T : ILayerInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetName<T>(this ProxyBase<T> proxyRef) where T : ILayerInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int IsGlobalLayer<T>(this ProxyBase<T> proxyRef) where T : ILayerInterface
        {
            return proxyRef.Instance.IsGlobalLayer();
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ILayerInterface
        {
            return proxyRef.Instance.SetId(id);
        }
    }
}