using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3AttributeProxy
    {

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DisplayAttributeExt<T>(this ProxyBase<T> proxyRef,int id = 0) where T : IAttributeInterface
        {
            return proxyRef.Instance.DisplayAttribute(id);
        }

        public static int DisplayValueAtExt<T>(this ProxyBase<T> proxyRef,int sheetid, double x, double y, int bindid = 0) where T : IAttributeInterface
        {
            return proxyRef.Instance.DisplayValueAt(sheetid, x, y, bindid);
        }

        public static string FormatValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IAttributeInterface
        {
            return proxyRef.Instance.FormatValue(name, value);
        }

        public static string GetFormattedValueExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetFormattedValue();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetInternalNameExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetInternalName();
        }

        public static string GetInternalValueExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetInternalValue();
        }

        public static int GetLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetLockChangeable();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetOwnerIdExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetOwnerId();
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IAttributeInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static string GetValueExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.GetValue();
        }

        public static int IsLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IAttributeInterface
        {
            return proxyRef.Instance.IsLockChangeable();
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IAttributeInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetLockChangeableExt<T>(this ProxyBase<T> proxyRef,int lockchangeable) where T : IAttributeInterface
        {
            return proxyRef.Instance.SetLockChangeable(lockchangeable);
        }

        public static int SetValueExt<T>(this ProxyBase<T> proxyRef,string value) where T : IAttributeInterface
        {
            return proxyRef.Instance.SetValue(value);
        }
    }
}