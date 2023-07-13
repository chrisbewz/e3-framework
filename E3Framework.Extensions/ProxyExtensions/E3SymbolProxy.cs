using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3SymbolProxy
    {
        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISymbolInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddToSheetReferenceExt<T>(this ProxyBase<T> proxyRef,int symi) where T : ISymbolInterface
        {
            return proxyRef.Instance.AddToSheetReference(symi);
        }

        public static int AssignFunctionalPortsExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.AssignFunctionalPorts();
        }

        public static int AssignFunctionalPortsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.AssignFunctionalPorts(ref ids);
        }

        public static int AssignToExt<T>(this ProxyBase<T> proxyRef,int AssignTo, int nonodeassignment = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.AssignTo(AssignTo, nonodeassignment);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBlockHatchColourExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockHatchColour();
        }

        public static double GetBlockHatchDistanceExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockHatchDistance();
        }

        public static int GetBlockHatchPatternExt<T>(this ProxyBase<T> proxyRef,ref object angle1, ref object angle2) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockHatchPattern(ref angle1, ref angle2);
        }

        public static int GetBlockHatchStyleExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockHatchStyle();
        }

        public static double GetBlockHatchWidthExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockHatchWidth();
        }

        public static int GetBlockOutlineColourExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockOutlineColour();
        }

        public static int GetBlockOutlineStyleExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockOutlineStyle();
        }

        public static double GetBlockOutlineWidthExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBlockOutlineWidth();
        }

        public static int GetBoundIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetBoundIds(ref ids);
        }

        public static string GetCharacteristicExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetCharacteristic();
        }

        public static int GetCodeExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetCode();
        }

        public static int GetDBTextSizeExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDBTextSize();
        }

        public static int GetDevicePinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDevicePinIds(ref ids);
        }

        public static double GetDisplayLengthExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDisplayLength();
        }

        public static double GetDisplayWidthExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDisplayWidth();
        }

        public static int GetDynamicChildrenIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDynamicChildrenIds(ref ids);
        }

        public static int GetDynamicParentIdExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetDynamicParentId();
        }

        public static int GetGateIdExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetGateId();
        }

        public static int GetGroupIdExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetGroupId();
        }

        public static int GetHyperlinkTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetHyperlinkTextIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static int GetMasterCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetMasterCount();
        }

        public static int GetMasterIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetMasterIds(ref ids);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetPinCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetPinCount();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetPlacedAreaExt<T>(this ProxyBase<T> proxyRef,ref object xMin, ref object yMin, ref object xMax, ref object yMax) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetPlacedArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public static int GetPlacedPolygonExt<T>(this ProxyBase<T> proxyRef,ref object npnts, ref object xarr, ref object yarr) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetPlacedPolygon(ref npnts, ref xarr, ref yarr);
        }

        public static string GetReferenceTextExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetReferenceText();
        }

        public static int GetReferenceTextExtentExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetReferenceTextExtent(ref xarr, ref yarr);
        }

        public static int GetReferenceTextExtentSingleLineExt<T>(this ProxyBase<T> proxyRef,ref object nlines, ref object xarr, ref object yarr) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetReferenceTextExtentSingleLine(ref nlines, ref xarr, ref yarr);
        }

        public static int GetReferenceTextSingleLineExt<T>(this ProxyBase<T> proxyRef,ref object textarr) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetReferenceTextSingleLine(ref textarr);
        }

        public static string GetRotationExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetRotation();
        }

        public static double GetScalingExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetScaling();
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public static int GetSchemaLocationSharedExt<T>(this ProxyBase<T> proxyRef,int shtId, ref object x, ref object y, ref object grid) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocationShared(shtId, ref x, ref y, ref grid);
        }

        public static int GetSchemaLocationSharedExt<T>(this ProxyBase<T> proxyRef,int shtId, ref object x, ref object y, ref object grid, ref object column_value) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocationShared(shtId, ref x, ref y, ref grid, ref column_value);
        }

        public static int GetSchemaLocationSharedExt<T>(this ProxyBase<T> proxyRef,int shtId, ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchemaLocationShared(shtId, ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public static int GetSchematicTypesExt<T>(this ProxyBase<T> proxyRef,ref object types) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSchematicTypes(ref types);
        }

        public static int GetSharedPinGroupStateExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSharedPinGroupState();
        }

        public static int GetSheetReferenceInfoExt<T>(this ProxyBase<T> proxyRef,out object inout, out object type, out object refnam, out object signam) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSheetReferenceInfo(out inout, out type, out refnam, out signam);
        }

        public static int GetSlaveCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSlaveCount();
        }

        public static int GetSlaveIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSlaveIds(ref ids);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static int GetSymbolExtendExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSymbolExtend(ref xarr, ref yarr);
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids);
        }

        public static string GetSymbolTypeNameExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetSymbolTypeName();
        }

        public static int GetTargetObjectIdExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetTargetObjectId();
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : ISymbolInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static int GetTransformationMatrixExt<T>(this ProxyBase<T> proxyRef,ref object array) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetTransformationMatrix(ref array);
        }

        public static string GetTypeNameExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetTypeName();
        }

        public static int GetValidCharacteristicsExt<T>(this ProxyBase<T> proxyRef,ref object characteristics) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetValidCharacteristics(ref characteristics);
        }

        public static string GetVersionExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.GetVersion();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HasNoGraphicExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.HasNoGraphic();
        }

        public static int HasPassWirePinsExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.HasPassWirePins();
        }

        public static int IsBlockExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsBlock();
        }

        public static int IsBundleExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsBundle();
        }

        public static int IsConnectedExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsConnected();
        }

        public static int IsConnectorMasterExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsConnectorMaster();
        }

        public static int IsDynamicExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsDynamic();
        }

        public static int IsDynamicFixedExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsDynamicFixed();
        }

        public static int IsFormboardExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsFormboard();
        }

        public static int IsMasterExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsMaster();
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsOffline();
        }

        public static int IsPinViewExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsPinView();
        }

        public static int IsProtectionExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsProtection();
        }

        public static int IsShieldExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsShield();
        }

        public static int IsTwistedExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.IsTwisted();
        }

        public static int JumpExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.Jump();
        }

        public static int LoadExt<T>(this ProxyBase<T> proxyRef,string name, string version) where T : ISymbolInterface
        {
            return proxyRef.Instance.Load(name, version);
        }

        public static int PlaceExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, string rot = null, double scale = 0, int maintaintextsize = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.Place(shti, x, y, rot, scale, maintaintextsize);
        }

        public static int PlaceAsGraphicExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, string rot, double scale, int maintaintextsize, int srcid) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlaceAsGraphic(shti, x, y, rot, scale, maintaintextsize, srcid);
        }

        public static int PlaceBlockExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, double width, double height, int parent = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlaceBlock(shti, x, y, width, height, parent);
        }

        public static int PlaceDynamicExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, double height, double width, string texttemplate = null,
            short fitsymbol = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlaceDynamic(shti, x, y, height, width, texttemplate, fitsymbol);
        }

        public static int PlaceInteractivelyExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlaceInteractively();
        }

        public static int PlacePinsExt<T>(this ProxyBase<T> proxyRef,ref object pinarray, string symname, string vers, int shti, double x, double y, string rot,
            double scale = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlacePins(ref pinarray, symname, vers, shti, x, y, rot, scale);
        }

        public static int PlacePinViewExt<T>(this ProxyBase<T> proxyRef,int pinid, int shti, string symname, string version, double x, double y, string rot, double scale = 0,
            int maintaintextsize = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlacePinView(pinid, shti, symname, version, x, y, rot, scale, maintaintextsize);
        }

        public static int PlaceTableExt<T>(this ProxyBase<T> proxyRef,int fromID, double x, double y, string rot = null, double scale = 0, int maintaintextsize = 0) where T : ISymbolInterface
        {
            return proxyRef.Instance.PlaceTable(fromID, x, y, rot, scale, maintaintextsize);
        }

        public static int SetAsMasterExt<T>(this ProxyBase<T> proxyRef,int on) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetAsMaster(on);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetBlockHatchColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockHatchColour(value);
        }

        public static double SetBlockHatchDistanceExt<T>(this ProxyBase<T> proxyRef,double value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockHatchDistance(value);
        }

        public static int SetBlockHatchPatternExt<T>(this ProxyBase<T> proxyRef,int value, double angle1, double angle2) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockHatchPattern(value, angle1, angle2);
        }

        public static int SetBlockHatchStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockHatchStyle(value);
        }

        public static double SetBlockHatchWidthExt<T>(this ProxyBase<T> proxyRef,double value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockHatchWidth(value);
        }

        public static int SetBlockOutlineColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockOutlineColour(value);
        }

        public static int SetBlockOutlineStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockOutlineStyle(value);
        }

        public static double SetBlockOutlineWidthExt<T>(this ProxyBase<T> proxyRef,double value) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetBlockOutlineWidth(value);
        }

        public static int SetCharacteristicExt<T>(this ProxyBase<T> proxyRef,string characteristic) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetCharacteristic(characteristic);
        }

        public static int SetDBTextSizeExt<T>(this ProxyBase<T> proxyRef,int txtsiz) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDBTextSize(txtsiz);
        }

        public static int SetDeviceAssignmentExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDeviceAssignment(name);
        }

        public static int SetDeviceCompleteNameExt<T>(this ProxyBase<T> proxyRef,string name, string ass, string loc, int onlygiven = 1) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDeviceCompleteName(name, ass, loc, onlygiven);
        }

        public static int SetDeviceLocationExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDeviceLocation(name);
        }

        public static int SetDeviceNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDeviceName(name);
        }

        public static int SetDisplayLengthExt<T>(this ProxyBase<T> proxyRef,double length) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDisplayLength(length);
        }

        public static int SetDisplayWidthExt<T>(this ProxyBase<T> proxyRef,double width) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetDisplayWidth(width);
        }

        public static int SetGateIdExt<T>(this ProxyBase<T> proxyRef,int symid) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetGateId(symid);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int level) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetLevel(level);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static double SetScalingExt<T>(this ProxyBase<T> proxyRef,double scale) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetScaling(scale);
        }

        public static int SetSharedPinGroupStateExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetSharedPinGroupState(newval);
        }

        public static int SetTypeExt<T>(this ProxyBase<T> proxyRef,string name, string version) where T : ISymbolInterface
        {
            return proxyRef.Instance.SetType(name, version);
        }

        public static int UnGroupExt<T>(this ProxyBase<T> proxyRef) where T : ISymbolInterface
        {
            return proxyRef.Instance.UnGroup();
        }
    }
}