using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3OptionProxy
    {


        public static int ActivateExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.Activate();
        }

        public static int ActivateAndLockOtherActivationsExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.ActivateAndLockOtherActivations();
        }

        public static int AddExt<T>(this ProxyBase<T> proxyRef,int devi) where T : IOptionInterface
        {
            return proxyRef.Instance.Add(devi);
        }

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IOptionInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AssignToIDExt<T>(this ProxyBase<T> proxyRef,int parentid, int how) where T : IOptionInterface
        {
            return proxyRef.Instance.AssignToID(parentid, how);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name, int parent = 0, int position = 0, int before = 0) where T : IOptionInterface
        {
            return proxyRef.Instance.Create(name, parent, position, before);
        }

        public static int CreateConfigurationExt<T>(this ProxyBase<T> proxyRef,string name, int posId, int before) where T : IOptionInterface
        {
            return proxyRef.Instance.CreateConfiguration(name, posId, before);
        }

        public static int CreateHarnessDerivativeExt<T>(this ProxyBase<T> proxyRef,string name, int posId, int before) where T : IOptionInterface
        {
            return proxyRef.Instance.CreateHarnessDerivative(name, posId, before);
        }

        public static int CreateHarnessFamilyExt<T>(this ProxyBase<T> proxyRef,string name, int posId, int before) where T : IOptionInterface
        {
            return proxyRef.Instance.CreateHarnessFamily(name, posId, before);
        }

        public static int CreatePackageExt<T>(this ProxyBase<T> proxyRef,string name, int posId, int before) where T : IOptionInterface
        {
            return proxyRef.Instance.CreatePackage(name, posId, before);
        }

        public static int DeactivateExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.Deactivate();
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef,int del) where T : IOptionInterface
        {
            return proxyRef.Instance.Delete(del);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetAllDeviceIds(ref ids);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IOptionInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static string GetDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetDescription();
        }

        public static int GetExclusiveOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetExclusiveOptionIds(ref ids);
        }

        public static int GetFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetFieldIds(ref ids);
        }

        public static string GetFullInternalNameExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetFullInternalName();
        }

        public static string GetFullNameExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetFullName();
        }

        public static int GetGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetGraphIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInclusiveOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetInclusiveOptionIds(ref ids);
        }

        public static string GetInternalDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetInternalDescription();
        }

        public static string GetInternalNameExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetInternalName();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetOptionIds(ref ids);
        }

        public static int GetParentOptionIdExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetParentOptionId();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetPropertyFlagsExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetPropertyFlags();
        }

        public static int GetSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetSheetIds(ref ids);
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IOptionInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IOptionInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static string GetXMLVariantIDExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.GetXMLVariantID();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HighlightExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.Highlight();
        }

        public static int IsActiveExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsActive();
        }

        public static int IsAssignableExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsAssignable();
        }

        public static int IsConfigurationExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsConfiguration();
        }

        public static int IsHarnessDerivativeExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsHarnessDerivative();
        }

        public static int IsHarnessFamilyExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsHarnessFamily();
        }

        public static int IsHighlightedExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsHighlighted();
        }

        public static int IsObjectActiveExt<T>(this ProxyBase<T> proxyRef,int objid) where T : IOptionInterface
        {
            return proxyRef.Instance.IsObjectActive(objid);
        }

        public static int IsPackageExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsPackage();
        }

        public static int IsVariantExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.IsVariant();
        }

        public static int MoveToExt<T>(this ProxyBase<T> proxyRef,int vari, int before = 0) where T : IOptionInterface
        {
            return proxyRef.Instance.MoveTo(vari, before);
        }

        public static int RemoveExt<T>(this ProxyBase<T> proxyRef,int devi) where T : IOptionInterface
        {
            return proxyRef.Instance.Remove(devi);
        }

        public static int ResetHighlightExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.ResetHighlight();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.Search(name);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IOptionInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetDescriptionExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IOptionInterface
        {
            return proxyRef.Instance.SetDescription(newval);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IOptionInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetPropertyFlagsExt<T>(this ProxyBase<T> proxyRef,int newflags) where T : IOptionInterface
        {
            return proxyRef.Instance.SetPropertyFlags(newflags);
        }

        public static int SetXMLVariantIDExt<T>(this ProxyBase<T> proxyRef,string name) where T : IOptionInterface
        {
            return proxyRef.Instance.SetXMLVariantID(name);
        }

        public static int SortExt<T>(this ProxyBase<T> proxyRef,int @ascending = 0) where T : IOptionInterface
        {
            return proxyRef.Instance.Sort(@ascending);
        }

        public static int UnassignFromIDExt<T>(this ProxyBase<T> proxyRef,int parentid) where T : IOptionInterface
        {
            return proxyRef.Instance.UnassignFromID(parentid);
        }

        public static int UnLockOtherActivationsExt<T>(this ProxyBase<T> proxyRef) where T : IOptionInterface
        {
            return proxyRef.Instance.UnLockOtherActivations();
        }
    }
}