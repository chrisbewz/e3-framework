using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ConnectionProxy
    {
        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IConnectionInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y) where T : IConnectionInterface
        {
            return proxyRef.Instance.Create(shti, pnts, ref x, ref y);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y, ref object PointTypArr) where T : IConnectionInterface
        {
            return proxyRef.Instance.Create(shti, pnts, ref x, ref y, ref PointTypArr);
        }

        public static int CreateBusExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y) where T : IConnectionInterface
        {
            return proxyRef.Instance.CreateBus(shti, pnts, ref x, ref y);
        }

        public static object CreateOnFormboardExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y) where T : IConnectionInterface
        {
            return proxyRef.Instance.CreateOnFormboard(shti, pnts, ref x, ref y);
        }

        public static object CreateOnFormboardExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y, ref object PointTypArr) where T : IConnectionInterface
        {
            return proxyRef.Instance.CreateOnFormboard(shti, pnts, ref x, ref y, ref PointTypArr);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.DisplayAttributeValue(name);
        }

        public static int DisplayAttributeValueAtExt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : IConnectionInterface
        {
            return proxyRef.Instance.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetIdExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetNetId();
        }

        public static int GetNetSegmentCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetNetSegmentCount();
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetPinCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinCount();
        }

        public static int GetPinGroupCountExt<T>(this ProxyBase<T> proxyRef,int num) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinGroupCount(num);
        }

        public static int GetPinGroupIdsExt<T>(this ProxyBase<T> proxyRef,int num, ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinGroupIds(num, ref ids);
        }

        public static int GetPinGroupsCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinGroupsCount();
        }

        public static int GetPinGroupsIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinGroupsIds(ref ids);
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetReferenceSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetReferenceSymbolCount();
        }

        public static int GetReferenceSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetReferenceSymbolIds(ref ids);
        }

        public static string GetSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetSignalName();
        }

        public static string GetTranslatedSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetTranslatedSignalName();
        }

        public static int GetViewNumberExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.GetViewNumber();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HighlightExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.Highlight();
        }

        public static int IsValidExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.IsValid();
        }

        public static int IsViewExt<T>(this ProxyBase<T> proxyRef) where T : IConnectionInterface
        {
            return proxyRef.Instance.IsView();
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IConnectionInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeVisibilityExt<T>(this ProxyBase<T> proxyRef,string name, int onoff) where T : IConnectionInterface
        {
            return proxyRef.Instance.SetAttributeVisibility(name, onoff);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IConnectionInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetSignalNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.SetSignalName(name);
        }

        public static int SetSignalNameOnLocalNetExt<T>(this ProxyBase<T> proxyRef,string name) where T : IConnectionInterface
        {
            return proxyRef.Instance.SetSignalNameOnLocalNet(name);
        }
    }
}