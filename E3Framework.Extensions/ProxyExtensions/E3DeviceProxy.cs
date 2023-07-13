using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3DeviceProxy
    {

        // [Obsolete("Obsolete: wrong name. Use AddAttributeValue() instead", true)]
        // // public static int AddAttibuteValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IDeviceInterface
        // // {
        // //     return AddAttributeValue(name, value);
        // // }

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddToAssemblyExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToAssembly();
        }

        public static int AddToAssemblyExt<T>(this ProxyBase<T> proxyRef,ref object ids, int position = 0, int before = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToAssembly(ref ids, position, before);
        }

        public static int AddToInstallationSpaceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToInstallationSpace();
        }

        public static int AddToInstallationSpaceExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToInstallationSpace(ref ids);
        }

        public static int AddToOverbraidExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToOverbraid();
        }

        public static int AddToOverbraidExt<T>(this ProxyBase<T> proxyRef,ref object ids, int position = 0, int before = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.AddToOverbraid(ref ids, position, before);
        }

        public static int AssignAsVariantInstanceExt<T>(this ProxyBase<T> proxyRef,int devid, string expression) where T : IDeviceInterface
        {
            return proxyRef.Instance.AssignAsVariantInstance(devid, expression);
        }

        public static int AssignFunctionalUnitsExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.AssignFunctionalUnits();
        }

        public static int AssignFunctionalUnitsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.AssignFunctionalUnits(ref ids);
        }

        public static int AssignFunctionalUnitsDynamicExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, int type) where T : IDeviceInterface
        {
            return proxyRef.Instance.AssignFunctionalUnitsDynamic(name, assignment, location, type);
        }

        public static int AssignFunctionalUnitsDynamicExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, int type, ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.AssignFunctionalUnitsDynamic(name, assignment, location, type, ref ids);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, string comp, string vers, int after) where T : IDeviceInterface
        {
            return proxyRef.Instance.Create(name, assignment, location, comp, vers, after);
        }

        public static int Create2DViewExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position, int before) where T : IDeviceInterface
        {
            return proxyRef.Instance.Create2DView(modi, name, symbol, position, before);
        }

        public static int Create2DViewExExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string symbol, int position = 0, int before = 0, int shtId = 0,
            double xMin = 0, double yMin = 0, double xMax = 0, double yMax = 0, double scale = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.Create2DViewEx(modi, name, symbol, position, before, shtId, xMin, yMin, xMax, yMax, scale);
        }

        public static int CreateAssemblyExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateAssembly();
        }

        public static int CreateAssemblyExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateAssembly(ref ids);
        }

        public static int CreateBlockExt<T>(this ProxyBase<T> proxyRef,string name = null, string assignment = null, string location = null, string cmpname = null,
            string version = null, string filename = null) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateBlock(name, assignment, location, cmpname, version, filename);
        }

        public static int CreateCableExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateCable(name, assignment, location);
        }

        public static int CreateCableDuctExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, double xlen, double ywid, double zhgt,
            string templ) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateCableDuct(name, assignment, location, xlen, ywid, zhgt, templ);
        }

        public static int CreateCableDuctExExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, double xlen, double ywid, double zhgt,
            string templ, int flags, double combwidth) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateCableDuctEx(name, assignment, location, xlen, ywid, zhgt, templ, flags, combwidth);
        }

        public static int CreateConnectorExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateConnector(name, assignment, location);
        }

        public static int CreateConnectorOnBlockExt<T>(this ProxyBase<T> proxyRef,int blkid, string name, string assignment, string location) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateConnectorOnBlock(blkid, name, assignment, location);
        }

        public static int CreateFormboardExt<T>(this ProxyBase<T> proxyRef,int from, int shtId, int blockid = 0, string databaseDeviceView = "") where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateFormboard(from, shtId, blockid, databaseDeviceView);
        }

        public static int CreateFunctionalDesignBlockExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, string cmpname, string version) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateFunctionalDesignBlock(name, assignment, location, cmpname, version);
        }

        public static int CreateInstanceExt<T>(this ProxyBase<T> proxyRef,int vari) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateInstance(vari);
        }

        public static int CreateMountExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, double xlen, double ywid, double zhgt, string slotdes,
            string templ) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateMount(name, assignment, location, xlen, ywid, zhgt, slotdes, templ);
        }

        public static int CreateOverbraidExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, string cmpname, string version) where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateOverbraid(name, assignment, location, cmpname, version);
        }

        public static int CreateViewExt<T>(this ProxyBase<T> proxyRef,int from, int level, int blockid = 0, string databaseDeviceView = "") where T : IDeviceInterface
        {
            return proxyRef.Instance.CreateView(from, level, blockid, databaseDeviceView);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DeleteEndAttributeExt<T>(this ProxyBase<T> proxyRef,int which, string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.DeleteEndAttribute(which, name);
        }

        public static int DeleteForcedExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.DeleteForced();
        }

        public static int DeleteInstanceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.DeleteInstance();
        }

        public static int DeleteInstanceForcedExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.DeleteInstanceForced();
        }

        public static int FindPanelPathExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.FindPanelPath();
        }

        public static int Get3DTransparencyExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.Get3DTransparency();
        }

        public static int GetAllCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAllCoreCount();
        }

        public static int GetAllCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAllCoreIds(ref ids);
        }

        public static int GetAllPinCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAllPinCount();
        }

        public static int GetAllPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAllPinIds(ref ids);
        }

        public static int GetAnyCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAnyCount();
        }

        public static int GetAnyIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAnyIds(ref ids);
        }

        public static int GetAssemblyIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssemblyId();
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static string GetAssignmentExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssignment();
        }

        public static int GetAssignmentLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAssignmentLockChangeable();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBlockIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetBlockId();
        }

        public static int GetBundleCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetBundleCount();
        }

        public static int GetBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetBundleIds(ref ids);
        }

        public static int GetCableCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableCount();
        }

        public static int GetCableDuctInletOutletExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableDuctInletOutlet();
        }

        public static int GetCableDuctInletOutletExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableDuctInletOutlet(ref ids);
        }

        public static int GetCableDuctInletOutletIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableDuctInletOutletId();
        }

        public static double GetCableDuctLengthExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableDuctLength();
        }

        public static int GetCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCableIds(ref ids);
        }

        public static int GetCarrierIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCarrierId();
        }

        public static string GetComponentAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetComponentAttributeValue(name);
        }

        public static string GetComponentNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetComponentName();
        }

        public static string GetComponentVersionExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetComponentVersion();
        }

        public static int GetConnectorCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetConnectorCount();
        }

        public static int GetConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetConnectorIds(ref ids);
        }

        public static int GetConnWithInsertsIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetConnWithInsertsId();
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static string GetCounterpartComponentNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCounterpartComponentName();
        }

        public static string GetCounterpartComponentVersionExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetCounterpartComponentVersion();
        }

        public static int GetDeviceCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetDeviceCount();
        }

        public static int GetDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetDeviceIds(ref ids);
        }

        public static int GetDisconnectingExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetDisconnecting();
        }

        public static int GetDynamicModelSizeExt<T>(this ProxyBase<T> proxyRef,out object x, out object y, out object z) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetDynamicModelSize(out x, out y, out z);
        }

        public static int GetEndAttributeCountExt<T>(this ProxyBase<T> proxyRef,int which) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetEndAttributeCount(which);
        }

        public static int GetEndAttributeIdsExt<T>(this ProxyBase<T> proxyRef,int which, ref object ids, string attnam = null) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetEndAttributeIds(which, ref ids, attnam);
        }

        public static string GetEndAttributeValueExt<T>(this ProxyBase<T> proxyRef,int which, string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetEndAttributeValue(which, name);
        }

        public static string GetFileNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetFileName();
        }

        public static int GetFormboardIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetFormboardIds(ref ids);
        }

        public static int GetFormboardSheetIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetFormboardSheetId();
        }

        public static int GetFunctionalBlockSymbolIDsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetFunctionalBlockSymbolIDs(ref ids);
        }

        public static int GetFunctionalUnitIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetFunctionalUnitIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInheritNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetInheritName();
        }

        public static int GetInstallationSpaceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetInstallationSpace();
        }

        public static int GetInterruptSignalFlowExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetInterruptSignalFlow();
        }

        public static string GetLocationExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetLocation();
        }

        public static int GetLocationLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetLocationLockChangeable();
        }

        public static string GetMasterPinNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetMasterPinName();
        }

        public static string GetModelCharacteristicExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetModelCharacteristic();
        }

        public static string GetModelNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetModelName();
        }

        public static int GetMountedCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetMountedCount();
        }

        public static int GetMountedIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetMountedIds(ref ids);
        }

        public static double GetMountLengthExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetMountLength();
        }

        public static int GetMountTypesExt<T>(this ProxyBase<T> proxyRef,ref object types) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetMountTypes(ref types);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNameLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetNameLockChangeable();
        }

        public static int GetNetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetNetIds(ref ids);
        }

        public static int GetNoconnPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetNoconnPinIds(ref ids);
        }

        public static int GetOriginalIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetOriginalId();
        }

        public static double GetOuterDiameterExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetOuterDiameter();
        }

        public static int GetOutlineCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetOutlineCount();
        }

        public static int GetOutlineIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetOutlineIds(ref ids);
        }

        public static int GetOverbraidIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetOverbraidId();
        }

        public static int GetPanelFreePlacementExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPanelFreePlacement();
        }

        public static int GetPanelLevelExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPanelLevel();
        }

        public static int GetPanelLocationExt<T>(this ProxyBase<T> proxyRef,out object x, out object y, out object z, out object rot) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPanelLocation(out x, out y, out z, out rot);
        }

        public static int GetPanelLocationExt<T>(this ProxyBase<T> proxyRef,out object x, out object y, out object z, out object rot, ref object pivot) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPanelLocation(out x, out y, out z, out rot, ref pivot);
        }

        public static int GetPanelPositionLockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPanelPositionLock();
        }

        public static int GetPinCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPinCount();
        }

        public static int GetPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetPinIds(ref ids);
        }

        public static int GetReferenceTypeExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetReferenceType();
        }

        public static int GetRootAssemblyIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetRootAssemblyId();
        }

        public static int GetSchematicTypesExt<T>(this ProxyBase<T> proxyRef,ref object types) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSchematicTypes(ref types);
        }

        public static int GetSlotIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSlotIds(ref ids);
        }

        public static int GetSupplyIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSupplyId();
        }

        public static int GetSupplyIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSupplyIds(ref ids);
        }

        public static int GetSupplyPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSupplyPinIds(ref ids);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef,int get_mode = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSymbolCount(get_mode);
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int get_mode = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids, get_mode);
        }

        public static int GetTableSymbolIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetTableSymbolId();
        }

        public static int GetTerminalBlockIdExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetTerminalBlockId();
        }

        public static int GetTerminalPlanSettingsExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetTerminalPlanSettings(ref parameters);
        }

        public static int GetTerminalPlanSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object shtids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetTerminalPlanSheetIds(ref shtids);
        }

        public static int GetValidComponentCodesExt<T>(this ProxyBase<T> proxyRef,ref object names) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetValidComponentCodes(ref names);
        }

        public static int GetValidModelCharacteristicsExt<T>(this ProxyBase<T> proxyRef,ref object characteristics) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetValidModelCharacteristics(ref characteristics);
        }

        public static int GetVariantObjectPropertiesExt<T>(this ProxyBase<T> proxyRef,int iObjectType, string sAttributeName, ref object arr) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetVariantObjectProperties(iObjectType, sAttributeName, ref arr);
        }

        public static int GetViewCountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetViewCount();
        }

        public static int GetViewIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetViewIds(ref ids);
        }

        public static int GetViewNumberExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.GetViewNumber();
        }

        public static int Has2DViewExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.Has2DView();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HasEndAttributeExt<T>(this ProxyBase<T> proxyRef,int which, string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.HasEndAttribute(which, name);
        }

        public static int HasNoconnExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.HasNoconn();
        }

        public static int HasPassWirePinsExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.HasPassWirePins();
        }

        public static int InsertTerminalPlanExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IDeviceInterface
        {
            return proxyRef.Instance.InsertTerminalPlan(ref parameters);
        }

        public static int IsAssemblyExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsAssembly();
        }

        public static int IsAssemblyPartExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsAssemblyPart();
        }

        public static int IsAssignmentLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsAssignmentLockChangeable();
        }

        public static int IsBlockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsBlock();
        }

        public static int IsCableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsCable();
        }

        public static int IsCableDuctExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsCableDuct();
        }

        public static int IsCableDuctInletOutletExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsCableDuctInletOutlet();
        }

        public static int IsCableDuctInletOutletPartExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsCableDuctInletOutletPart();
        }

        public static int IsClipboardPartExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsClipboardPart();
        }

        public static int IsConnectorExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsConnector();
        }

        public static int IsConnWithInsertsExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsConnWithInserts();
        }

        public static int IsConnWithInsertsPartExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsConnWithInsertsPart();
        }

        public static int IsDeviceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsDevice();
        }

        public static int IsDynamicModelExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsDynamicModel();
        }

        public static int IsFormboardExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsFormboard();
        }

        public static int IsFunctionalBlockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsFunctionalBlock();
        }

        public static int IsFunctionalDesignBlockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsFunctionalDesignBlock();
        }

        public static int IsHarnessExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsHarness();
        }

        public static int IsHierarchicalBlockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsHierarchicalBlock();
        }

        public static int IsHoseExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsHose();
        }

        public static int IsInstallationSpaceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsInstallationSpace();
        }

        public static int IsLocationLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsLocationLockChangeable();
        }

        public static int IsLockedExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsLocked();
        }

        public static int IsLockPurgeUnusedExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsLockPurgeUnused();
        }

        public static int IsModuleExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsModule();
        }

        public static int IsMountExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsMount();
        }

        public static int IsNameLockChangeableExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsNameLockChangeable();
        }

        public static int IsOverbraidExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsOverbraid();
        }

        public static int IsOverbraidPartExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsOverbraidPart();
        }

        public static int IsPinTerminalSymbolsUsedExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsPinTerminalSymbolsUsed();
        }

        public static int IsTerminalExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsTerminal();
        }

        public static int IsTerminalBlockExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsTerminalBlock();
        }

        public static int IsTubeExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsTube();
        }

        public static int IsViewExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsView();
        }

        public static int IsWireGroupExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.IsWireGroup();
        }

        public static int JumpExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.Jump();
        }

        public static int LoadAndCreateExt<T>(this ProxyBase<T> proxyRef,string comp, string vers, int type) where T : IDeviceInterface
        {
            return proxyRef.Instance.LoadAndCreate(comp, vers, type);
        }

        public static int LoadAndPlaceComponentExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, string comp, string vers, string wirename,
            int after, int options) where T : IDeviceInterface
        {
            return proxyRef.Instance.LoadAndPlaceComponent(name, assignment, location, comp, vers, wirename, after, options);
        }

        public static int LockObjectExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.LockObject();
        }

        public static int MergeHarnessesExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.MergeHarnesses();
        }

        public static int MergeHarnessesExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.MergeHarnesses(ref ids);
        }

        public static int RemoveFromAssemblyExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromAssembly();
        }

        public static int RemoveFromAssemblyExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromAssembly(ref ids);
        }

        public static int RemoveFromInstallationSpaceExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromInstallationSpace();
        }

        public static int RemoveFromInstallationSpaceExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromInstallationSpace(ref ids);
        }

        public static int RemoveFromOverbraidExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromOverbraid();
        }

        public static int RemoveFromOverbraidExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.RemoveFromOverbraid(ref ids);
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location) where T : IDeviceInterface
        {
            return proxyRef.Instance.Search(name, assignment, location);
        }

        public static int SearchAllExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.SearchAll(name, assignment, location, ref ids);
        }

        public static int Set3DTransparencyExt<T>(this ProxyBase<T> proxyRef,int mode) where T : IDeviceInterface
        {
            return proxyRef.Instance.Set3DTransparency(mode);
        }

        public static int SetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetAssignedOptionIds(ref ids);
        }

        public static int SetAssignmentExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetAssignment(name);
        }

        public static int SetAssignmentLockChangeableExt<T>(this ProxyBase<T> proxyRef,int lockchangeable) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetAssignmentLockChangeable(lockchangeable);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetAttributeValueVariantExt<T>(this ProxyBase<T> proxyRef,string name, string value, int copy, string VariantExpression) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetAttributeValueVariant(name, value, copy, VariantExpression);
        }

        public static int SetCableDuctLengthExt<T>(this ProxyBase<T> proxyRef,double newlen) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetCableDuctLength(newlen);
        }

        public static int SetCompleteNameExt<T>(this ProxyBase<T> proxyRef,string name, string assignment, string location, int onlygiven = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetCompleteName(name, assignment, location, onlygiven);
        }

        public static int SetComponentNameExt<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetComponentName(name, version);
        }

        public static int SetDisconnectingExt<T>(this ProxyBase<T> proxyRef,int onoff) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetDisconnecting(onoff);
        }

        public static int SetDynamicModelSizeExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object z) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetDynamicModelSize(ref x, ref y, ref z);
        }

        public static int SetEndAttributeValueExt<T>(this ProxyBase<T> proxyRef,int which, string name, string value) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetEndAttributeValue(which, name, value);
        }

        public static int SetFileNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetFileName(name);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetInheritNameExt<T>(this ProxyBase<T> proxyRef,int onoff) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetInheritName(onoff);
        }

        public static int SetInterruptSignalFlowExt<T>(this ProxyBase<T> proxyRef,int sigflow = 1) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetInterruptSignalFlow(sigflow);
        }

        public static int SetLocationExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetLocation(name);
        }

        public static int SetLocationLockChangeableExt<T>(this ProxyBase<T> proxyRef,int lockchangeable) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetLocationLockChangeable(lockchangeable);
        }

        public static int SetLockPurgeUnusedExt<T>(this ProxyBase<T> proxyRef,int id) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetLockPurgeUnused(id);
        }

        public static int SetMasterPinNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetMasterPinName(name);
        }

        public static int SetModelCharacteristicExt<T>(this ProxyBase<T> proxyRef,string characteristic) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetModelCharacteristic(characteristic);
        }

        public static int SetModuleExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetModule(newval);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetNameLockChangeableExt<T>(this ProxyBase<T> proxyRef,int lockchangeable) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetNameLockChangeable(lockchangeable);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static double SetOuterDiameterExt<T>(this ProxyBase<T> proxyRef,double newval) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetOuterDiameter(newval);
        }

        public static int SetPanelFreePlacementExt<T>(this ProxyBase<T> proxyRef,int freeplacement = 1) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPanelFreePlacement(freeplacement);
        }

        public static int SetPanelLevelExt<T>(this ProxyBase<T> proxyRef,int nLevel, int bChangeMounted) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPanelLevel(nLevel, bChangeMounted);
        }

        public static int SetPanelLocationExt<T>(this ProxyBase<T> proxyRef,int world, int shti, double x, double y, double z, string rot, int use_start_z = 0,
            int place_combined = 0, int pivot = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPanelLocation(world, shti, x, y, z, rot, use_start_z, place_combined, pivot);
        }

        public static int SetPanelLocationExExt<T>(this ProxyBase<T> proxyRef,int world, int shti, double x, double y, double z, string rot, int use_start_z = 0,
            int place_combined = 0, int pivot = 0, int shift_key = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPanelLocationEx(world, shti, x, y, z, rot, use_start_z, place_combined, pivot, shift_key);
        }

        public static int SetPanelPositionLockExt<T>(this ProxyBase<T> proxyRef,int onoff) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPanelPositionLock(onoff);
        }

        public static int SetPinTerminalSymbolsUsedExt<T>(this ProxyBase<T> proxyRef,int use) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetPinTerminalSymbolsUsed(use);
        }

        public static int SetReferenceTypeExt<T>(this ProxyBase<T> proxyRef,int type) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetReferenceType(type);
        }

        public static int SetSupplyIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetSupplyId(id);
        }

        public static int SetTerminalPlanSettingsExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetTerminalPlanSettings(ref parameters);
        }

        public static int SetTerminalSequenceExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetTerminalSequence(ref ids);
        }

        public static int SetViewNumberExt<T>(this ProxyBase<T> proxyRef,int id) where T : IDeviceInterface
        {
            return proxyRef.Instance.SetViewNumber(id);
        }

        public static int SortExt<T>(this ProxyBase<T> proxyRef,int Sort = 0) where T : IDeviceInterface
        {
            return proxyRef.Instance.Sort(Sort);
        }

        public static int SortHarnessExt<T>(this ProxyBase<T> proxyRef,ref object ids, int postion, int options) where T : IDeviceInterface
        {
            return proxyRef.Instance.SortHarness(ref ids, postion, options);
        }

        public static int UnlockObjectExt<T>(this ProxyBase<T> proxyRef,string password) where T : IDeviceInterface
        {
            return proxyRef.Instance.UnlockObject(password);
        }

        public static int UnplacePanelExt<T>(this ProxyBase<T> proxyRef) where T : IDeviceInterface
        {
            return proxyRef.Instance.UnplacePanel();
        }

        public static int UpdateDisconnectingExt<T>(this ProxyBase<T> proxyRef,int options) where T : IDeviceInterface
        {
            return proxyRef.Instance.UpdateDisconnecting(options);
        }

        public static int UpdateDisconnectingExt<T>(this ProxyBase<T> proxyRef,int options, ref object ids) where T : IDeviceInterface
        {
            return proxyRef.Instance.UpdateDisconnecting(options, ref ids);
        }

    }
}