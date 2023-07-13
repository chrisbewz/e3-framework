using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3NetProxy
    {
        public static int AddAttributeValue<T>(this ProxyBase<T> proxyRef,string name, string value) where T : INetInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int DeleteAttribute<T>(this ProxyBase<T> proxyRef,string name) where T : INetInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayAttributeValueAt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : INetInterface
        {
            return proxyRef.Instance.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public static int GetAttributeCount<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIds<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : INetInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValue<T>(this ProxyBase<T> proxyRef,string name) where T : INetInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetCoreIds<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static int GetHarnessId<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetHarnessId();
        }

        public static int GetId<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetName<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetInterface
        {
            return proxyRef.Instance.GetNetIds(ref ids);
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetParentID<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetParentID();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static string GetSignalName<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetSignalName();
        }

        public static string GetTranslatedSignalName<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.GetTranslatedSignalName();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsSignalTransferred<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.IsSignalTransferred();
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : INetInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeVisibilityExt<T>(this ProxyBase<T> proxyRef,string name, int onoff) where T : INetInterface
        {
            return proxyRef.Instance.SetAttributeVisibility(name, onoff);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : INetInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetSignalNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetInterface
        {
            return proxyRef.Instance.SetSignalName(name);
        }

        public static int SetSignalNameOnLocalNetExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetInterface
        {
            return proxyRef.Instance.SetSignalNameOnLocalNet(name);
        }

        public static int SetTransferSignalExt<T>(this ProxyBase<T> proxyRef,int value) where T : INetInterface
        {
            return proxyRef.Instance.SetTransferSignal(value);
        }

        public static int SplitHarness<T>(this ProxyBase<T> proxyRef) where T : INetInterface
        {
            return proxyRef.Instance.SplitHarness();
        }
        
    }
}