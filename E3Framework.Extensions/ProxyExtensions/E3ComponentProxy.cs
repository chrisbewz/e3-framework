using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ComponentProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IComponentInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IComponentInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IComponentInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IComponentInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IComponentInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetFormboardSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IComponentInterface
        {
            return proxyRef.Instance.GetFormboardSymbolIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IComponentInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetModelNameExt<T>(this ProxyBase<T> proxyRef) where T : IComponentInterface
        {
            return proxyRef.Instance.GetModelName();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IComponentInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetSupplyPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IComponentInterface
        {
            return proxyRef.Instance.GetSupplyPinIds(ref ids);
        }

        public static int GetValidModelCharacteristicsExt<T>(this ProxyBase<T> proxyRef,ref object characteristics) where T : IComponentInterface
        {
            return proxyRef.Instance.GetValidModelCharacteristics(ref characteristics);
        }

        public static string GetVersionExt<T>(this ProxyBase<T> proxyRef) where T : IComponentInterface
        {
            return proxyRef.Instance.GetVersion();
        }

        public static int GetViewDefinitionsExt<T>(this ProxyBase<T> proxyRef,ref object viewDefinitions) where T : IComponentInterface
        {
            return proxyRef.Instance.GetViewDefinitions(ref viewDefinitions);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IComponentInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int RenameExt<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IComponentInterface
        {
            return proxyRef.Instance.Rename(name, version);
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IComponentInterface
        {
            return proxyRef.Instance.Search(name, version);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IComponentInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IComponentInterface
        {
            return proxyRef.Instance.SetId(id);
        }
    }
}