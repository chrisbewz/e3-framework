using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3BundleProxy
    {
        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IBundleInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int CaptureExt<T>(this ProxyBase<T> proxyRef,ref object cabwirids) where T : IBundleInterface
        {
            return proxyRef.Instance.Capture(ref cabwirids);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,ref object aroundids) where T : IBundleInterface
        {
            return proxyRef.Instance.Create(ref aroundids);
        }

        public static int CreateBundleExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateBundle();
        }

        public static int CreateBundleExt<T>(this ProxyBase<T> proxyRef,ref object aroundids) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateBundle(ref aroundids);
        }

        public static int CreateBundleInExt<T>(this ProxyBase<T> proxyRef,int cableid) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateBundleIn(cableid);
        }

        public static int CreateInExt<T>(this ProxyBase<T> proxyRef,int cableid) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateIn(cableid);
        }

        public static int CreateShieldExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateShield();
        }

        public static int CreateShieldExt<T>(this ProxyBase<T> proxyRef,ref object aroundids) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateShield(ref aroundids);
        }

        public static int CreateShieldInExt<T>(this ProxyBase<T> proxyRef,int cableid) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateShieldIn(cableid);
        }

        public static int CreateTwistExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateTwist();
        }

        public static int CreateTwistExt<T>(this ProxyBase<T> proxyRef,ref object aroundids) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateTwist(ref aroundids);
        }

        public static int CreateTwistInExt<T>(this ProxyBase<T> proxyRef,int cableid) where T : IBundleInterface
        {
            return proxyRef.Instance.CreateTwistIn(cableid);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IBundleInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAnyCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetAnyCount();
        }

        public static int GetAnyIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetAnyIds(ref ids);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IBundleInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IBundleInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBundleCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetBundleCount();
        }

        public static int GetBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetBundleIds(ref ids);
        }

        public static int GetCableCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetCableCount();
        }

        public static int GetCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetCableIds(ref ids);
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetOverbraidIdExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetOverbraidId();
        }

        public static int GetParentBundleIdExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetParentBundleId();
        }

        public static int GetPinCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetPinCount();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetRootBundleIdExt<T>(this ProxyBase<T> proxyRef,int bndid) where T : IBundleInterface
        {
            return proxyRef.Instance.GetRootBundleId(bndid);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IBundleInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsBundleExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.IsBundle();
        }

        public static int IsShieldExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.IsShield();
        }

        public static int IsTwistedExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.IsTwisted();
        }

        public static int PlaceAllExt<T>(this ProxyBase<T> proxyRef) where T : IBundleInterface
        {
            return proxyRef.Instance.PlaceAll();
        }

        public static int ReleaseIDsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IBundleInterface
        {
            return proxyRef.Instance.ReleaseIDs(ref ids);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IBundleInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IBundleInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IBundleInterface
        {
            return proxyRef.Instance.SetName(name);
        }

    }
}