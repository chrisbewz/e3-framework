using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3OutlineProxy
    {

        public static int CreateBoardOutlineExt<T>(this ProxyBase<T> proxyRef,ref int brdi, int pnts, ref object x, ref object y) where T : IOutlineInterface
        {
            return proxyRef.Instance.CreateBoardOutline(brdi, pnts, ref x, ref y);
        }

        public static double GetHeightExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetHeight();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetPathExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetPath(ref xarr, ref yarr);
        }

        public static int GetPathExExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr, ref object zarr) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetPathEx(ref xarr, ref yarr, ref zarr);
        }

        public static int GetPositionExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object z) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetPosition(ref x, ref y, ref z);
        }

        public static double GetRadiusExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetRadius();
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static int GetTypeIdExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.GetTypeId();
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,ref int id) where T : IOutlineInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int UseInE3CutOutExt<T>(this ProxyBase<T> proxyRef) where T : IOutlineInterface
        {
            return proxyRef.Instance.UseInE3CutOut();
        }
        
    }
}