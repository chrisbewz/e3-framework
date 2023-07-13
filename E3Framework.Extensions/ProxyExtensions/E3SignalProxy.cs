using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SignalProxy
    {

    public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISignalInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddDefaultWireExt<T>(this ProxyBase<T> proxyRef,IntPtr wiregroup, IntPtr wirename) where T : ISignalInterface
        {
            return proxyRef.Instance.AddDefaultWire(wiregroup, wirename);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.Create(name);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DeleteDefaultWireExt<T>(this ProxyBase<T> proxyRef,IntPtr wiregroup, IntPtr wirename) where T : ISignalInterface
        {
            return proxyRef.Instance.DeleteDefaultWire(wiregroup, wirename);
        }

        public static int DisplayaAttributeValueAtExt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : ISignalInterface
        {
            return proxyRef.Instance.DisplayaAttributeValueAt(name, sheetid, x, y);
        }

        public static int DisplayAttributeValueAtExt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : ISignalInterface
        {
            return proxyRef.Instance.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public static int FindPanelPathExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.FindPanelPath();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : ISignalInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISignalInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static int GetDefaultWiresExt<T>(this ProxyBase<T> proxyRef,ref object wiregroups, ref object wirenames) where T : ISignalInterface
        {
            return proxyRef.Instance.GetDefaultWires(ref wiregroups, ref wirenames);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static string GetNameFormatExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetNameFormat();
        }

        public static int GetNetSegmentCountExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetNetSegmentCount();
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISignalInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetPinCountExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetPinCount();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISignalInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetRecalcFormattedNameExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetRecalcFormattedName();
        }

        public static int GetSignalClassIdExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetSignalClassId();
        }

        public static string GetTranslatedNameExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetTranslatedName();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HighlightExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.Highlight();
        }

        public static int HighlightCoreLogicLinesOfSignalExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.HighlightCoreLogicLinesOfSignal();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.Search(name);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISignalInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeVisibilityExt<T>(this ProxyBase<T> proxyRef,string name, int onoff) where T : ISignalInterface
        {
            return proxyRef.Instance.SetAttributeVisibility(name, onoff);
        }

        public static int SetDefaultWiresExt<T>(this ProxyBase<T> proxyRef,ref object wiregroups, ref object wirenames) where T : ISignalInterface
        {
            return proxyRef.Instance.SetDefaultWires(ref wiregroups, ref wirenames);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISignalInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetNameFormatExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalInterface
        {
            return proxyRef.Instance.SetNameFormat(name);
        }

        public static int SetRecalcFormattedNameExt<T>(this ProxyBase<T> proxyRef,int recalculate) where T : ISignalInterface
        {
            return proxyRef.Instance.SetRecalcFormattedName(recalculate);
        }
    }
}