using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SheetProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISheetInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int checkinExt<T>(this ProxyBase<T> proxyRef,int unlock = 1) where T : ISheetInterface
        {
            return proxyRef.Instance.checkin(unlock);
        }

        public static int checkinExt<T>(this ProxyBase<T> proxyRef,int unlock, ref object sheetids) where T : ISheetInterface
        {
            return proxyRef.Instance.checkin(unlock, ref sheetids);
        }

        public static int CheckInAllExt<T>(this ProxyBase<T> proxyRef,int unlock = 1) where T : ISheetInterface
        {
            return proxyRef.Instance.CheckInAll(unlock);
        }

        public static int CheckOutExt<T>(this ProxyBase<T> proxyRef,int @lock = 1) where T : ISheetInterface
        {
            return proxyRef.Instance.CheckOut(@lock);
        }

        public static int CheckOutExt<T>(this ProxyBase<T> proxyRef,int @lock, ref object sheetids) where T : ISheetInterface
        {
            return proxyRef.Instance.CheckOut(@lock, ref sheetids);
        }

        public static int CheckOutAllExt<T>(this ProxyBase<T> proxyRef,int @lock = 1) where T : ISheetInterface
        {
            return proxyRef.Instance.CheckOutAll(@lock);
        }

        public static int CheckoutReadonlyReferencedSheets<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.CheckoutReadonlyReferencedSheets();
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before) where T : ISheetInterface
        {
            return proxyRef.Instance.Create(modi, name, symbol, position, before);
        }

        public static int CreateBoardExt<T>(this ProxyBase<T> proxyRef,int brdi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale) where T : ISheetInterface
        {
            return proxyRef.Instance.CreateBoard(brdi, name, symbol, position, before, refx, refy, refscale);
        }

        public static int CreateFormboardExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before, int flags) where T : ISheetInterface
        {
            return proxyRef.Instance.CreateFormboard(modi, name, symbol, position, before, flags);
        }

        public static int CreateFormboardExExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale) where T : ISheetInterface
        {
            return proxyRef.Instance.CreateFormboardEx(modi, name, symbol, position, before, refx, refy, refscale);
        }

        public static int CreateFunctionalDesignExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before, int flags) where T : ISheetInterface
        {
            return proxyRef.Instance.CreateFunctionalDesign(modi, name, symbol, position, before, flags);
        }

        public static int CreatePanelExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale) where T : ISheetInterface
        {
            return proxyRef.Instance.CreatePanel(modi, name, symbol, position, before, refx, refy, refscale);
        }

        public static int CreateTopologyExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before, double refscale) where T : ISheetInterface
        {
            return proxyRef.Instance.CreateTopology(modi, name, symbol, position, before, refscale);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISheetInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.Display();
        }

        public static int ExportExt<T>(this ProxyBase<T> proxyRef,string format, int version, string file, int flags = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.Export(format, version, file, flags);
        }

        public static int ExportImageExt<T>(this ProxyBase<T> proxyRef,string format, int version, string file, int dpi = 0, int compressionmode = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.ExportImage(format, version, file, dpi, compressionmode);
        }

        public static int ExportImageAreaExt<T>(this ProxyBase<T> proxyRef,string format, int version, string file, double xl, double yl, double xr, double yr, int width,
            int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode) where T : ISheetInterface
        {
            return proxyRef.Instance.ExportImageArea(format, version, file, xl, yl, xr, yr, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
        }

        public static int ExportImageSelectionExt<T>(this ProxyBase<T> proxyRef,string format, int version, string file, int percentage, int width, int height, int clrdepth,
            int gray, int dpiX, int dpiY, int compressionmode) where T : ISheetInterface
        {
            return proxyRef.Instance.ExportImageSelection(format, version, file, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static string GetAssignmentExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAssignment();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISheetInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBaseIdExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetBaseId();
        }

        public static string GetCharacteristicExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetCharacteristic();
        }

        public static int GetContentModifiedExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetContentModified();
        }

        public static int GetDimensionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetDimensionIds(ref ids);
        }

        public static int GetDrawingAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISheetInterface
        {
            return proxyRef.Instance.GetDrawingArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetEmbeddedSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetEmbeddedSheetIds(ref ids);
        }

        public static string GetFormatExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetFormat();
        }

        public static int GetGetterOptionHandlingModeExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetGetterOptionHandlingMode();
        }

        public static int GetGraphCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetGraphCount();
        }

        public static int GetGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetGraphIds(ref ids);
        }

        public static int GetGroupIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetGroupIds(ref ids);
        }

        public static int GetHyperlinkTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetHyperlinkTextIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInsideGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetInsideGraphIds(ref ids);
        }

        public static int GetInsideNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetInsideNetSegmentIds(ref ids);
        }

        public static int GetInsidePanelConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetInsidePanelConnectionIds(ref ids);
        }

        public static int GetInsideSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetInsideSymbolIds(ref ids);
        }

        public static string GetLocationExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetLocation();
        }

        public static int GetModuleCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetModuleCount();
        }

        public static int GetModuleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetModuleIds(ref ids);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetNetIds(ref ids);
        }

        public static int GetNetSegmentCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetNetSegmentCount();
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetOpenNetsegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetOpenNetsegmentIds(ref ids);
        }

        public static string GetOwnerExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetOwner();
        }

        public static int GetPanelConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetPanelConnectionIds(ref ids);
        }

        public static int GetPanelRegionExt<T>(this ProxyBase<T> proxyRef,ref object xoff, ref object yoff, ref object scale) where T : ISheetInterface
        {
            return proxyRef.Instance.GetPanelRegion(ref xoff, ref yoff, ref scale);
        }

        public static int GetParentSheetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetParentSheetId();
        }

        public static int GetRedlinedGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetRedlinedGraphIds(ref ids);
        }

        public static int GetRedlinedGraphTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetRedlinedGraphTextIds(ref ids);
        }

        public static int GetRegionAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISheetInterface
        {
            return proxyRef.Instance.GetRegionArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetSchematicTypesExt<T>(this ProxyBase<T> proxyRef,ref object types) where T : ISheetInterface
        {
            return proxyRef.Instance.GetSchematicTypes(ref types);
        }

        public static int GetSharedIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetSharedIds(ref ids);
        }

        public static int GetSheetRegionExt<T>(this ProxyBase<T> proxyRef,ref object xoff, ref object yoff, ref object scale) where T : ISheetInterface
        {
            return proxyRef.Instance.GetSheetRegion(ref xoff, ref yoff, ref scale);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISheetInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : ISheetInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static int GetTopologyRegionExt<T>(this ProxyBase<T> proxyRef,ref object xoff, ref object yoff, ref object scale) where T : ISheetInterface
        {
            return proxyRef.Instance.GetTopologyRegion(ref xoff, ref yoff, ref scale);
        }

        public static int GetValidCharacteristicsExt<T>(this ProxyBase<T> proxyRef,ref object characteristics) where T : ISheetInterface
        {
            return proxyRef.Instance.GetValidCharacteristics(ref characteristics);
        }

        public static int GetVisibleAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISheetInterface
        {
            return proxyRef.Instance.GetVisibleArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetWorkingAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISheetInterface
        {
            return proxyRef.Instance.GetWorkingArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISheetInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int ImportDGNExt<T>(this ProxyBase<T> proxyRef,string filename, double scale, double x, double y, int rot, string font, int flags) where T : ISheetInterface
        {
            return proxyRef.Instance.ImportDGN(filename, scale, x, y, rot, font, flags);
        }

        public static int ImportDXFExt<T>(this ProxyBase<T> proxyRef,string filename, double scale, double x, double y, int rot, string font, int inbox = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.ImportDXF(filename, scale, x, y, rot, font, inbox);
        }

        public static int Is2DViewExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.Is2DView();
        }

        public static int IsClipboardPartExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsClipboardPart();
        }

        public static int IsEmbeddedExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsEmbedded();
        }

        public static int IsFormboardExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsFormboard();
        }

        public static int IsFunctionalDesignExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsFunctionalDesign();
        }

        public static int IsLockedExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsLocked();
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsOffline();
        }

        public static int IsPanelExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsPanel();
        }

        public static int IsParentSheetExt<T>(this ProxyBase<T> proxyRef,int flags) where T : ISheetInterface
        {
            return proxyRef.Instance.IsParentSheet(flags);
        }

        public static int IsReadOnlyExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsReadOnly();
        }

        public static int IsSharedExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsShared();
        }

        public static int IsTerminalPlanExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsTerminalPlan();
        }

        public static int IsTopologyExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.IsTopology();
        }

        public static int LockObjectExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.LockObject();
        }

        public static int MoveToExt<T>(this ProxyBase<T> proxyRef,int position, int before = 0) where T : ISheetInterface
        {
            return proxyRef.Instance.MoveTo(position, before);
        }

        public static int PlacePartExt<T>(this ProxyBase<T> proxyRef,string name, string version, double x, double y, double rot) where T : ISheetInterface
        {
            return proxyRef.Instance.PlacePart(name, version, x, y, rot);
        }

        public static int PlacePartExExt<T>(this ProxyBase<T> proxyRef,string name, string version, int flags, double x, double y, double rot) where T : ISheetInterface
        {
            return proxyRef.Instance.PlacePartEx(name, version, flags, x, y, rot);
        }

        public static int PrintOutExt<T>(this ProxyBase<T> proxyRef,double scale) where T : ISheetInterface
        {
            return proxyRef.Instance.PrintOut(scale);
        }

        public static int RemoveExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.Remove();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,int modi, string name) where T : ISheetInterface
        {
            return proxyRef.Instance.Search(modi, name);
        }

        public static int SetAssignmentExt<T>(this ProxyBase<T> proxyRef,string newass) where T : ISheetInterface
        {
            return proxyRef.Instance.SetAssignment(newass);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISheetInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetCharacteristicExt<T>(this ProxyBase<T> proxyRef,string characteristic) where T : ISheetInterface
        {
            return proxyRef.Instance.SetCharacteristic(characteristic);
        }

        public static int SetCompleteNameExt<T>(this ProxyBase<T> proxyRef,string newnam, string newass, string newloc) where T : ISheetInterface
        {
            return proxyRef.Instance.SetCompleteName(newnam, newass, newloc);
        }

        public static int SetCompleteNameExt<T>(this ProxyBase<T> proxyRef,string newnam, string newass, string newloc, int onlygiven) where T : ISheetInterface
        {
            return proxyRef.Instance.SetCompleteNameEx(newnam, newass, newloc, onlygiven);
        }

        public static int SetContentModifiedExt<T>(this ProxyBase<T> proxyRef,int value) where T : ISheetInterface
        {
            return proxyRef.Instance.SetContentModified(value);
        }

        public static int SetFormatExt<T>(this ProxyBase<T> proxyRef,string sym, string rot = null) where T : ISheetInterface
        {
            return proxyRef.Instance.SetFormat(sym, rot);
        }

        public static int SetGetterOptionHandlingModeExt<T>(this ProxyBase<T> proxyRef,int mode) where T : ISheetInterface
        {
            return proxyRef.Instance.SetGetterOptionHandlingMode(mode);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISheetInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetLocationExt<T>(this ProxyBase<T> proxyRef,string newloc) where T : ISheetInterface
        {
            return proxyRef.Instance.SetLocation(newloc);
        }

        public static string SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISheetInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : ISheetInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static int SetPanelRegionExt<T>(this ProxyBase<T> proxyRef,double xoff, double yoff, double scale) where T : ISheetInterface
        {
            return proxyRef.Instance.SetPanelRegion(xoff, yoff, scale);
        }

        public static int SetSchematicTypesExt<T>(this ProxyBase<T> proxyRef,ref object types) where T : ISheetInterface
        {
            return proxyRef.Instance.SetSchematicTypes(ref types);
        }

        public static int SetSheetRegionExt<T>(this ProxyBase<T> proxyRef,double xoff, double yoff, double scale) where T : ISheetInterface
        {
            return proxyRef.Instance.SetSheetRegion(xoff, yoff, scale);
        }

        public static int SetTopologyRegionExt<T>(this ProxyBase<T> proxyRef,double xoff, double yoff, double scale) where T : ISheetInterface
        {
            return proxyRef.Instance.SetTopologyRegion(xoff, yoff, scale);
        }

        public static int SetVisibleAreaExt<T>(this ProxyBase<T> proxyRef,double xMin, double yMin, double xMax, double yMax) where T : ISheetInterface
        {
            return proxyRef.Instance.SetVisibleArea(xMin, yMin, xMax, yMax);
        }

        public static int ShareWithIDExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISheetInterface
        {
            return proxyRef.Instance.ShareWithID(id);
        }

        public static int ToGridExt<T>(this ProxyBase<T> proxyRef,ref object xpos, ref object ypos) where T : ISheetInterface
        {
            return proxyRef.Instance.ToGrid(ref xpos, ref ypos);
        }

        public static int UnlockObjectExt<T>(this ProxyBase<T> proxyRef,string password) where T : ISheetInterface
        {
            return proxyRef.Instance.UnlockObject(password);
        }

        public static int VisibleExt<T>(this ProxyBase<T> proxyRef) where T : ISheetInterface
        {
            return proxyRef.Instance.Visible();
        }
    }
}