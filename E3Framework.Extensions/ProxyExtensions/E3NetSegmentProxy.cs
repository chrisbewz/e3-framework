using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3NetSegmentProxy
    {
        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : INetSegmentInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AdjustSchemaLengthExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.AdjustSchemaLength();
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.DisplayAttributeValue(name);
        }

        public static int DisplayAttributeValueAtExt<T>(this ProxyBase<T> proxyRef,string name, int sheetid, double x, double y) where T : INetSegmentInterface
        {
            return proxyRef.Instance.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static string GetBusNameExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetBusName();
        }

        public static int GetConnectedSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetConnectedSymbolIds(ref ids);
        }

        public static int GetConnectLineIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetConnectLineIds(ref ids);
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static int GetEffectiveDirectionExt<T>(this ProxyBase<T> proxyRef,ref object fromID, ref object toID) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetEffectiveDirection(ref fromID, ref toID);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static double GetLengthExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLength();
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static int GetLineColourExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLineColour();
        }

        public static int GetLineSegmentsExt<T>(this ProxyBase<T> proxyRef,ref object shtId, ref object xarr, ref object yarr) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLineSegments(ref shtId, ref xarr, ref yarr);
        }

        public static int GetLineSegmentsExt<T>(this ProxyBase<T> proxyRef,ref object shtId, ref object xarr, ref object yarr, ref object PointTypArr) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLineSegments(ref shtId, ref xarr, ref yarr, ref PointTypArr);
        }

        public static int GetLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLineStyle();
        }

        public static double GetLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetLineWidth();
        }

        public static double GetManufacturingLengthExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetManufacturingLength();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetIdExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetNetId();
        }

        public static int GetNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetNodeIds(ref ids);
        }

        public static double GetOuterDiameterExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetOuterDiameter();
        }

        public static double GetRotationExt<T>(this ProxyBase<T> proxyRef,int anchorid) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetRotation(anchorid);
        }

        public static double GetSchemaLengthExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetSchemaLength();
        }

        public static int GetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetSignalIds(ref ids);
        }

        public static string GetSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetSignalName();
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static string GetTranslatedSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.GetTranslatedSignalName();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HighlightExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.Highlight();
        }

        public static int IsBusExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.IsBus();
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.IsOffline();
        }

        public static int IsPanelPathExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.IsPanelPath();
        }

        public static int IsViewExt<T>(this ProxyBase<T> proxyRef) where T : INetSegmentInterface
        {
            return proxyRef.Instance.IsView();
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeVisibilityExt<T>(this ProxyBase<T> proxyRef,string name, int onoff) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetAttributeVisibility(name, onoff);
        }

        public static int SetBusNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetBusName(name);
        }

        public static int SetEffectiveDirectionExt<T>(this ProxyBase<T> proxyRef,int toID) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetEffectiveDirection(toID);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetIgnoreForCablingTableExt<T>(this ProxyBase<T> proxyRef,int set) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetIgnoreForCablingTable(set);
        }

        public static double SetLengthExt<T>(this ProxyBase<T> proxyRef,double newlen) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLength(newlen);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int level) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLevel(level);
        }

        public static int SetLineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLineColour(newcol);
        }

        public static int SetLineLevelExt<T>(this ProxyBase<T> proxyRef,int newlev) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLineLevel(newlev);
        }

        public static int SetLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstl) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLineStyle(newstl);
        }

        public static int SetLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetLineWidth(newwid);
        }

        public static double SetManufacturingLengthExt<T>(this ProxyBase<T> proxyRef,double newval) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetManufacturingLength(newval);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static double SetRotationExt<T>(this ProxyBase<T> proxyRef,int anchorid, double newval) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetRotation(anchorid, newval);
        }

        public static double SetSchemaLengthExt<T>(this ProxyBase<T> proxyRef,double newval) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetSchemaLength(newval);
        }

        public static int SetSignalNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : INetSegmentInterface
        {
            return proxyRef.Instance.SetSignalName(name);
        }
        
    }
}