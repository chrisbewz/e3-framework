using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SignalClassProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISignalClassInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddSignalIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISignalClassInterface
        {
            return proxyRef.Instance.AddSignalId(id);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.Create(name);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ISignalClassInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayaAttributeValueAtExt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : ISignalClassInterface
        {
            return proxyRef.Instance.DisplayaAttributeValueAt(name, sheetid, x, y);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : ISignalClassInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISignalInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISignalClassInterface
        {
            return proxyRef.Instance.GetSignalIds(ref ids);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int RemoveSignalIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISignalClassInterface
        {
            return proxyRef.Instance.RemoveSignalId(id);
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.Search(name);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISignalClassInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeVisibilityExt<T>(this ProxyBase<T> proxyRef,string name, int onoff) where T : ISignalClassInterface
        {
            return proxyRef.Instance.SetAttributeVisibility(name, onoff);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISignalClassInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISignalClassInterface
        {
            return proxyRef.Instance.SetName(name);
        }
    }
}