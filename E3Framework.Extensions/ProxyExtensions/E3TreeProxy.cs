using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3TreeProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name, int position = 0, int before = 0) where T : ITreeInterface
        {
            return proxyRef.Instance.Create(name, position, before);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ITreeInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ITreeInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ITreeInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNamesExt<T>(this ProxyBase<T> proxyRef,ref object names) where T : ITreeInterface
        {
            return proxyRef.Instance.GetNames(ref names);
        }

        public static int GetSelectedAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedAllDeviceIds(ref ids);
        }

        public static int GetSelectedAllDeviceIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedAllDeviceIdsByFolder(ref ids);
        }

        public static int GetSelectedBlockIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedBlockIds(ref ids);
        }

        public static int GetSelectedBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedBundleIds(ref ids);
        }

        public static int GetSelectedCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedCableIds(ref ids);
        }

        public static int GetSelectedConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedConnectorIds(ref ids);
        }

        public static int GetSelectedDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedDeviceIds(ref ids);
        }

        public static int GetSelectedExternalDocumentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedExternalDocumentIds(ref ids);
        }

        public static int GetSelectedExternalDocumentIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedExternalDocumentIdsByFolder(ref ids);
        }

        public static int GetSelectedPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedPinIds(ref ids);
        }

        public static int GetSelectedSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedSheetIds(ref ids);
        }

        public static int GetSelectedSheetIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedSheetIdsByFolder(ref ids);
        }

        public static int GetSelectedStructureNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedStructureNodeIds(ref ids);
        }

        public static int GetSelectedSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedSymbolIds(ref ids);
        }

        public static int GetSelectedTerminalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSelectedTerminalIds(ref ids);
        }

        public static int GetSortingMethodExt<T>(this ProxyBase<T> proxyRef,ref object flags, ref object structure, ref object freetab) where T : ITreeInterface
        {
            return proxyRef.Instance.GetSortingMethod(ref flags, ref structure, ref freetab);
        }

        public static int GetVisibleInfoTypesExt<T>(this ProxyBase<T> proxyRef,ref object views, ref object schematic) where T : ITreeInterface
        {
            return proxyRef.Instance.GetVisibleInfoTypes(ref views, ref schematic);
        }

        public static int GetVisibleInfoTypesExExt<T>(this ProxyBase<T> proxyRef,ref object views, ref object schematicTypes, ref object formboardSheetIds) where T : ITreeInterface
        {
            return proxyRef.Instance.GetVisibleInfoTypesEx(ref views, ref schematicTypes, ref formboardSheetIds);
        }

        public static int GetVisibleObjectTypesExt<T>(this ProxyBase<T> proxyRef,ref object type_array) where T : ITreeInterface
        {
            return proxyRef.Instance.GetVisibleObjectTypes(ref type_array);
        }

        public static int IsActiveExt<T>(this ProxyBase<T> proxyRef) where T : ITreeInterface
        {
            return proxyRef.Instance.IsActive();
        }

        public static int IsVisibleExt<T>(this ProxyBase<T> proxyRef) where T : ITreeInterface
        {
            return proxyRef.Instance.IsVisible();
        }

        public static int SetIconExt<T>(this ProxyBase<T> proxyRef,string filename, int index = 0) where T : ITreeInterface
        {
            return proxyRef.Instance.SetIcon(filename, index);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int treeid) where T : ITreeInterface
        {
            return proxyRef.Instance.SetId(treeid);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ITreeInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetNamesExt<T>(this ProxyBase<T> proxyRef,ref object names) where T : ITreeInterface
        {
            return proxyRef.Instance.SetNames(ref names);
        }

        public static int SetSortingMethodExt<T>(this ProxyBase<T> proxyRef,int flags, ref object structure, ref object freetab) where T : ITreeInterface
        {
            return proxyRef.Instance.SetSortingMethod(flags, ref structure, ref freetab);
        }

        public static int SetVisibleInfoTypesExt<T>(this ProxyBase<T> proxyRef,string views, string schematic) where T : ITreeInterface
        {
            return proxyRef.Instance.SetVisibleInfoTypes(views, schematic);
        }

        public static int SetVisibleInfoTypesExt<T>(this ProxyBase<T> proxyRef,ref object views, ref object schematicTypes, ref object formboardSheetIds) where T : ITreeInterface
        {
            return proxyRef.Instance.SetVisibleInfoTypesEx(ref views, ref schematicTypes, ref formboardSheetIds);
        }

        public static int SetVisibleObjectTypesExt<T>(this ProxyBase<T> proxyRef,ref object type_array) where T : ITreeInterface
        {
            return proxyRef.Instance.SetVisibleObjectTypes(ref type_array);
        }

        public static int ViewSignalTreeExt<T>(this ProxyBase<T> proxyRef,int bShowTree) where T : ITreeInterface
        {
            return proxyRef.Instance.ViewSignalTree(bShowTree);
        }
        
    }
}