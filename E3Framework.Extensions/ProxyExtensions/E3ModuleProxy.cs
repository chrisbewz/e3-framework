using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ModuleProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IModuleInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModuleInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IModuleInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModuleInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static string GetFileNameExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetFileName();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static int GetModuleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IModuleInterface
        {
            return proxyRef.Instance.GetModuleIds(ref ids);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetParentModuleIdExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetParentModuleId();
        }

        public static int GetParentSheetIdExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetParentSheetId();
        }

        public static int GetPortCountExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetPortCount();
        }

        public static int GetPortIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IModuleInterface
        {
            return proxyRef.Instance.GetPortIds(ref ids);
        }

        public static int GetSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IModuleInterface
        {
            return proxyRef.Instance.GetSheetIds(ref ids);
        }

        public static string GetTypeNameExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.GetTypeName();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModuleInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsTypeLoadableExt<T>(this ProxyBase<T> proxyRef) where T : IModuleInterface
        {
            return proxyRef.Instance.IsTypeLoadable();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModuleInterface
        {
            return proxyRef.Instance.Search(name);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IModuleInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IModuleInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IModuleInterface
        {
            return proxyRef.Instance.SetName(name);
        }
        
    }
}