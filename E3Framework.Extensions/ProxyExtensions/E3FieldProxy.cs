using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3FieldProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IFieldInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int Delete<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFieldInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAllInsideFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAllInsideFieldIds(ref ids);
        }

        public static int GetAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : IFieldInterface
        {
            return proxyRef.Instance.GetArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAttributeCount<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFieldInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetCrossingFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetCrossingFieldIds(ref ids);
        }

        public static int GetCrossingNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetCrossingNetSegmentIds(ref ids);
        }

        public static int GetCrossingPanelConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetCrossingPanelConnectionIds(ref ids);
        }

        public static string GetDeviceAssignment<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetDeviceAssignment();
        }

        public static string GetDeviceLocation<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetDeviceLocation();
        }

        public static string GetDeviceName<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetDeviceName();
        }

        public static int GetGraphId<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetGraphId();
        }

        public static int GetId<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInsideFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsideFieldIds(ref ids);
        }

        public static int GetInsideGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsideGraphIds(ref ids);
        }

        public static int GetInsideNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsideNetSegmentIds(ref ids);
        }

        public static int GetInsidePanelConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsidePanelConnectionIds(ref ids);
        }

        public static int GetInsideSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsideSymbolIds(ref ids);
        }

        public static int GetInsideTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInsideTextIds(ref ids);
        }

        public static int GetInterruptBorderExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInterruptBorder();
        }

        public static double GetInterruptBorderGapExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetInterruptBorderGap();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetParentFieldIdExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetParentFieldId();
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : IFieldInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value) where T : IFieldInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value) where T : IFieldInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFieldInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IFieldInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static string GetTypeNameExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetTypeName();
        }

        public static string GetVersionExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.GetVersion();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFieldInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int JumpExt<T>(this ProxyBase<T> proxyRef) where T : IFieldInterface
        {
            return proxyRef.Instance.Jump();
        }

        public static int PlaceExt<T>(this ProxyBase<T> proxyRef,int shti, double x1, double y1, double x2, double y2, int moveall = 0) where T : IFieldInterface
        {
            return proxyRef.Instance.Place(shti, x1, y1, x2, y2, moveall);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IFieldInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetCompleteNameExt<T>(this ProxyBase<T> proxyRef,string newdev, string newass, string newloc, int onlygiven = 0) where T : IFieldInterface
        {
            return proxyRef.Instance.SetCompleteName(newdev, newass, newloc, onlygiven);
        }

        public static int SetDeviceAssignmentExt<T>(this ProxyBase<T> proxyRef,string newass) where T : IFieldInterface
        {
            return proxyRef.Instance.SetDeviceAssignment(newass);
        }

        public static int SetDeviceLocationExt<T>(this ProxyBase<T> proxyRef,string newloc) where T : IFieldInterface
        {
            return proxyRef.Instance.SetDeviceLocation(newloc);
        }

        public static int SetDeviceNameExt<T>(this ProxyBase<T> proxyRef,string newdev) where T : IFieldInterface
        {
            return proxyRef.Instance.SetDeviceName(newdev);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IFieldInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetInterruptBorderExt<T>(this ProxyBase<T> proxyRef,int interrupt) where T : IFieldInterface
        {
            return proxyRef.Instance.SetInterruptBorder(interrupt);
        }

        public static double SetInterruptBorderGapExt<T>(this ProxyBase<T> proxyRef,double gap) where T : IFieldInterface
        {
            return proxyRef.Instance.SetInterruptBorderGap(gap);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFieldInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : IFieldInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }
        
    }
}