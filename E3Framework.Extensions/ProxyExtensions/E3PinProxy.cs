using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3PinProxy
    {

        public static int AddAttributeValue<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IPinInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddDefaultWire<T>(this ProxyBase<T> proxyRef,IntPtr wiregroup, IntPtr wirename) where T : IPinInterface
        {
            return proxyRef.Instance.AddDefaultWire(wiregroup, wirename);
        }

        public static int AddEndAttributeValue<T>(this ProxyBase<T> proxyRef,int which, string name, string value) where T : IPinInterface
        {
            return proxyRef.Instance.AddEndAttributeValue(which, name, value);
        }

        public static int AddPinsToConnector<T>(this ProxyBase<T> proxyRef,ref object pinidarray, string name, string assignment, string location) where T : IPinInterface
        {
            return proxyRef.Instance.AddPinsToConnector(ref pinidarray, name, assignment, location);
        }

        public static int AssignTo<T>(this ProxyBase<T> proxyRef,ref object pinids) where T : IPinInterface
        {
            return proxyRef.Instance.AssignTo(ref pinids);
        }

        public static int CalculateFittingForWires<T>(this ProxyBase<T> proxyRef,ref object wirids, ref object fittinglst) where T : IPinInterface
        {
            return proxyRef.Instance.CalculateFittingForWires(ref wirids, ref fittinglst);
        }

        public static int Create<T>(this ProxyBase<T> proxyRef,string name, int devi, int pini, int before) where T : IPinInterface
        {
            return proxyRef.Instance.Create(name, devi, pini, before);
        }

        public static int CreateNewConnectorForPinsExt<T>(this ProxyBase<T> proxyRef,ref object pinidarray, string name, string assignment, string location) where T : IPinInterface
        {
            return proxyRef.Instance.CreateNewConnectorForPins(ref pinidarray, name, assignment, location);
        }

        public static int CreateWireExt<T>(this ProxyBase<T> proxyRef,string name, string cabtyp, string wirnam, int devi, int pini, int before) where T : IPinInterface
        {
            return proxyRef.Instance.CreateWire(name, cabtyp, wirnam, devi, pini, before);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DeleteDefaultWireExt<T>(this ProxyBase<T> proxyRef,IntPtr wiregroup, IntPtr wirename) where T : IPinInterface
        {
            return proxyRef.Instance.DeleteDefaultWire(wiregroup, wirename);
        }

        public static int DeleteEndAttributeExt<T>(this ProxyBase<T> proxyRef,int which, string name) where T : IPinInterface
        {
            return proxyRef.Instance.DeleteEndAttribute(which, name);
        }

        public static int DeleteForced<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.DeleteForced();
        }

        public static int DeletePanelPath<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.DeletePanelPath();
        }

        public static int FindPanelPath<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.FindPanelPath();
        }

        public static int GenerateNewWireNamesExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GenerateNewWireNames(ref ids);
        }

        public static int GetAllNetSegmentPathsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int pin1i, int pin2i) where T : IPinInterface
        {
            return proxyRef.Instance.GetAllNetSegmentPaths(ref ids, pin1i, pin2i);
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IPinInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IPinInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static int GetAttributeCount<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IPinInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBlockConnectionNumber<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetBlockConnectionNumber();
        }

        public static int GetCableDuctIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetCableDuctIds(ref ids);
        }

        public static int GetCCT<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCCT();
        }

        public static int GetColour<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetColour();
        }

        public static string GetColourDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetColourDescription();
        }

        public static string GetComponentAttributeValueExt<T>(this ProxyBase<T> proxyRef,ref string name) where T : IPinInterface
        {
            return proxyRef.Instance.GetComponentAttributeValue(name);
        }

        public static int GetConnectedNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetConnectedNodeIds(ref ids);
        }

        public static int GetConnectedPinIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetConnectedPinId();
        }

        public static int GetConnectedPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetConnectedPinIds(ref ids);
        }

        public static int GetConnectionTypeExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetConnectionType();
        }

        public static string GetConnectionTypeDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetConnectionTypeDescription();
        }

        public static int GetCoreChangeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreChangeIds(ref ids);
        }

        public static int GetCoreChangeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, ref object optids) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreChangeIds(ref ids, ref optids);
        }

        public static string GetCoreCostExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreCost();
        }

        public static int GetCoreCountExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreCount();
        }

        public static int GetCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreIds(ref ids);
        }

        public static double GetCoreManufacturingLengthExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreManufacturingLength();
        }

        public static double GetCoreWeightExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCoreWeight();
        }

        public static string GetCounterpartExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCounterpart();
        }

        public static double GetCrossSectionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCrossSection();
        }

        public static string GetCrossSectionDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetCrossSectionDescription();
        }

        public static int GetDefaultWiresExt<T>(this ProxyBase<T> proxyRef,ref object wiregroups, ref object wirenames) where T : IPinInterface
        {
            return proxyRef.Instance.GetDefaultWires(ref wiregroups, ref wirenames);
        }

        public static double GetDefinedOuterDiameterExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetDefinedOuterDiameter();
        }

        public static int GetDestinationCountExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetDestinationCount();
        }

        public static int GetDestinationIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetDestinationIds(ref ids);
        }

        public static int GetDevicePinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetDevicePinIds(ref ids);
        }

        public static double GetDiameterExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetDiameter();
        }

        public static string GetDiameterDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetDiameterDescription();
        }

        public static int GetEndAttributeCountExt<T>(this ProxyBase<T> proxyRef,ref int which) where T : IPinInterface
        {
            return proxyRef.Instance.GetEndAttributeCount(which);
        }

        public static int GetEndAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref int which, ref object ids, string attnam = null) where T : IPinInterface
        {
            return proxyRef.Instance.GetEndAttributeIds(which, ref ids, attnam);
        }

        public static string GetEndAttributeValueExt<T>(this ProxyBase<T> proxyRef,ref int which, string name) where T : IPinInterface
        {
            return proxyRef.Instance.GetEndAttributeValue(which, name);
        }

        public static int GetEndPinIdExt<T>(this ProxyBase<T> proxyRef,ref int which, int flags = 0) where T : IPinInterface
        {
            return proxyRef.Instance.GetEndPinId(which, flags);
        }

        public static int GetExchangeableIDExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetExchangeableID();
        }

        public static string GetExternSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetExternSignalName();
        }

        public static string GetFittingExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetFitting();
        }

        public static int GetFittingIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetFittingIds(ref ids);
        }

        public static int GetFittingIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, ref object optids) where T : IPinInterface
        {
            return proxyRef.Instance.GetFittingIds(ref ids, ref optids);
        }

        public static int GetFuncExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetFunc();
        }

        public static int GetFunctionalPortIDExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetFunctionalPortID();
        }

        public static int GetHarnessIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetHarnessId();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInterruptSignalFlowExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetInterruptSignalFlow();
        }

        public static double GetLengthExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetLength();
        }

        public static int GetLockingExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetLocking();
        }

        public static int GetLogicalEquivalenceIDExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetLogicalEquivalenceID();
        }

        public static int GetLossAngleExt<T>(this ProxyBase<T> proxyRef,ref object lossangle) where T : IPinInterface
        {
            return proxyRef.Instance.GetLossAngle(ref lossangle);
        }

        public static int GetMaterialExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetMaterial();
        }

        public static string GetMaterialDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetMaterialDescription();
        }

        public static int GetMergeSegmentExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetMergeSegment();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNameEquivalenceIDExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetNameEquivalenceID();
        }

        public static int GetNetSegmentCountExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetNetSegmentCount();
        }

        public static int GetNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetNetSegmentIds(ref ids);
        }

        public static int GetNetSegmentPathExt<T>(this ProxyBase<T> proxyRef,ref object ids, int pin1i, int pin2i) where T : IPinInterface
        {
            return proxyRef.Instance.GetNetSegmentPath(ref ids, pin1i, pin2i);
        }

        public static int GetNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetNodeIds(ref ids);
        }

        public static int GetNodeTypeExt<T>(this ProxyBase<T> proxyRef,ref object type) where T : IPinInterface
        {
            return proxyRef.Instance.GetNodeType(ref type);
        }

        public static int GetNumberOfWindingsExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetNumberOfWindings();
        }

        public static int GetOriginalIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetOriginalId();
        }

        public static double GetOuterDiameterExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetOuterDiameter();
        }

        public static int GetOverbraidIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetOverbraidId();
        }

        public static int GetPanelLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object z) where T : IPinInterface
        {
            return proxyRef.Instance.GetPanelLocation(ref x, ref y, ref z);
        }

        public static int GetPanelNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetPanelNetSegmentIds(ref ids);
        }

        public static int GetPanelPathExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr, ref object zarr) where T : IPinInterface
        {
            return proxyRef.Instance.GetPanelPath(ref xarr, ref yarr, ref zarr);
        }

        public static int GetPassPinsExt<T>(this ProxyBase<T> proxyRef,ref object ids, ref object ends, ref object ende) where T : IPinInterface
        {
            return proxyRef.Instance.GetPassPins(ref ids, ref ends, ref ende);
        }

        public static int GetPassWiresExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetPassWires(ref ids);
        }

        public static int GetPhysicalConnectionDirectionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalConnectionDirection();
        }

        public static int GetPhysicalConnectionTypeExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalConnectionType();
        }

        public static string GetPhysicalConnectionTypeDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalConnectionTypeDescription();
        }

        public static int GetPhysicalIDExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalID();
        }

        public static int GetPhysicalMaxConnectionsExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalMaxConnections();
        }

        public static double GetPhysicalMaxCrossSectionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalMaxCrossSection();
        }

        public static double GetPhysicalMinCrossSectionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalMinCrossSection();
        }

        public static int GetPhysicalPositionExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object z) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalPosition(ref x, ref y, ref z);
        }

        public static double GetPhysicalTotalMaxCrossSectionExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPhysicalTotalMaxCrossSection();
        }

        public static int GetPinIndexExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPinIndex();
        }

        public static string GetPortNameExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetPortName();
        }

        public static int GetRelativePermittivityExt<T>(this ProxyBase<T> proxyRef,ref object relativepermittivity) where T : IPinInterface
        {
            return proxyRef.Instance.GetRelativePermittivity(ref relativepermittivity);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : IPinInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value) where T : IPinInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value) where T : IPinInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public static int GetSchematicEndPinIdExt<T>(this ProxyBase<T> proxyRef,ref int which) where T : IPinInterface
        {
            return proxyRef.Instance.GetSchematicEndPinId(which);
        }

        public static int GetSequenceNumberExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetSequenceNumber();
        }

        public static string GetSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetSignalName();
        }

        public static int GetSupplyInfoExt<T>(this ProxyBase<T> proxyRef,ref object supid, ref object signum, ref object signam) where T : IPinInterface
        {
            return proxyRef.Instance.GetSupplyInfo(ref supid, ref signum, ref signam);
        }

        public static int GetTemplateSymbolIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetTemplateSymbolId();
        }

        public static int GetTemplateSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetTemplateSymbolIds(ref ids);
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IPinInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static string GetTranslatedSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetTranslatedSignalName();
        }

        public static int GetTypeIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetTypeId();
        }

        public static int GetValidCounterpartsExt<T>(this ProxyBase<T> proxyRef,ref object strings) where T : IPinInterface
        {
            return proxyRef.Instance.GetValidCounterparts(ref strings);
        }

        public static int GetValidFittingsExt<T>(this ProxyBase<T> proxyRef,ref object strings) where T : IPinInterface
        {
            return proxyRef.Instance.GetValidFittings(ref strings);
        }

        public static int GetVariantObjectPropertiesExt<T>(this ProxyBase<T> proxyRef,ref int iObjectType, string sAttributeName, ref object arr) where T : IPinInterface
        {
            return proxyRef.Instance.GetVariantObjectProperties(iObjectType, sAttributeName, ref arr);
        }

        public static int GetViewCountExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetViewCount();
        }

        public static int GetViewIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IPinInterface
        {
            return proxyRef.Instance.GetViewIds(ref ids);
        }

        public static int GetWireKindIdExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.GetWireKindId();
        }

        public static int GetWireTypeExt<T>(this ProxyBase<T> proxyRef,ref object comp, ref object name) where T : IPinInterface
        {
            return proxyRef.Instance.GetWireType(ref comp, ref name);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,ref string name) where T : IPinInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HasDeviceExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.HasDevice();
        }

        public static int HasEndAttributeExt<T>(this ProxyBase<T> proxyRef,ref int which, string name) where T : IPinInterface
        {
            return proxyRef.Instance.HasEndAttribute(which, name);
        }

        public static int HighlightExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.Highlight();
        }

        public static int IsBackShellExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsBackShell();
        }

        public static int IsCoreEndLockedExt<T>(this ProxyBase<T> proxyRef,ref int which) where T : IPinInterface
        {
            return proxyRef.Instance.IsCoreEndLocked(which);
        }

        public static int IsExternalExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsExternal();
        }

        public static int IsInternalExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsInternal();
        }

        public static int IsLockedExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsLocked();
        }

        public static int IsNoconnExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsNoconn();
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsOffline();
        }

        public static int IsPanelPathLockedExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsPanelPathLocked();
        }

        public static int IsPassWireExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsPassWire();
        }

        public static int IsPinViewExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsPinView();
        }

        public static int IsRoutedExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsRouted();
        }

        public static int IsSupplyExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsSupply();
        }

        public static int IsViewExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.IsView();
        }

        public static int LockCoreEndExt<T>(this ProxyBase<T> proxyRef,ref int which, int @lock) where T : IPinInterface
        {
            return proxyRef.Instance.LockCoreEnd(which, @lock);
        }

        public static int LockObjectExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.LockObject();
        }

        public static int LockPanelPathExt<T>(this ProxyBase<T> proxyRef,int @lock) where T : IPinInterface
        {
            return proxyRef.Instance.LockPanelPath(@lock);
        }

        public static int PlaceNodeExt<T>(this ProxyBase<T> proxyRef,ref int shtId, double x, double y) where T : IPinInterface
        {
            return proxyRef.Instance.PlaceNode(shtId, x, y);
        }

        public static int ResetLengthExt<T>(this ProxyBase<T> proxyRef) where T : IPinInterface
        {
            return proxyRef.Instance.ResetLength();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,ref string name, int devi) where T : IPinInterface
        {
            return proxyRef.Instance.Search(name, devi);
        }

        public static int SetAsExternalExt<T>(this ProxyBase<T> proxyRef,ref int onoff) where T : IPinInterface
        {
            return proxyRef.Instance.SetAsExternal(onoff);
        }

        public static int SetAsInternalExt<T>(this ProxyBase<T> proxyRef,ref int onoff) where T : IPinInterface
        {
            return proxyRef.Instance.SetAsInternal(onoff);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,ref string name, string value) where T : IPinInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetColourExt<T>(this ProxyBase<T> proxyRef,ref int color) where T : IPinInterface
        {
            return proxyRef.Instance.SetColour(color);
        }

        public static int SetColourByDescriptionExt<T>(this ProxyBase<T> proxyRef,ref string color) where T : IPinInterface
        {
            return proxyRef.Instance.SetColourByDescription(color);
        }

        public static int SetColourDescriptionExt<T>(this ProxyBase<T> proxyRef,ref string color) where T : IPinInterface
        {
            return proxyRef.Instance.SetColourDescription(color);
        }

        public static int SetCoreChangeIdExt<T>(this ProxyBase<T> proxyRef,ref int id) where T : IPinInterface
        {
            return proxyRef.Instance.SetCoreChangeId(id);
        }

        public static int SetCoreCostExt<T>(this ProxyBase<T> proxyRef,ref string value) where T : IPinInterface
        {
            return proxyRef.Instance.SetCoreCost(value);
        }

        public static int SetCounterpartExt<T>(this ProxyBase<T> proxyRef,ref string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetCounterpart(name);
        }

        public static int SetCrossSectionExt<T>(this ProxyBase<T> proxyRef,ref double crossec) where T : IPinInterface
        {
            return proxyRef.Instance.SetCrossSection(crossec);
        }

        public static int SetCrossSectionByDescriptionExt<T>(this ProxyBase<T> proxyRef,string description) where T : IPinInterface
        {
            return proxyRef.Instance.SetCrossSectionByDescription(description);
        }

        public static int SetDefaultWiresExt<T>(this ProxyBase<T> proxyRef,ref object wiregroups, ref object wirenames) where T : IPinInterface
        {
            return proxyRef.Instance.SetDefaultWires(ref wiregroups, ref wirenames);
        }

        public static int SetDeviceIdExt<T>(this ProxyBase<T> proxyRef,int devid, int pinid, int before) where T : IPinInterface
        {
            return proxyRef.Instance.SetDeviceId(devid, pinid, before);
        }

        public static int SetEndAttributeValueExt<T>(this ProxyBase<T> proxyRef,int which, string name, string value) where T : IPinInterface
        {
            return proxyRef.Instance.SetEndAttributeValue(which, name, value);
        }

        public static int SetEndPinIdExt<T>(this ProxyBase<T> proxyRef,int which, int pini) where T : IPinInterface
        {
            return proxyRef.Instance.SetEndPinId(which, pini);
        }

        public static int SetFittingExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetFitting(name);
        }

        public static int SetFittingIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IPinInterface
        {
            return proxyRef.Instance.SetFittingId(id);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IPinInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetInterruptSignalFlowExt<T>(this ProxyBase<T> proxyRef,int sigflow = 1) where T : IPinInterface
        {
            return proxyRef.Instance.SetInterruptSignalFlow(sigflow);
        }

        public static int SetLengthExt<T>(this ProxyBase<T> proxyRef,double length) where T : IPinInterface
        {
            return proxyRef.Instance.SetLength(length);
        }

        public static int SetLockingExt<T>(this ProxyBase<T> proxyRef,int bSet) where T : IPinInterface
        {
            return proxyRef.Instance.SetLocking(bSet);
        }

        public static int SetMergeSegmentExt<T>(this ProxyBase<T> proxyRef,int bSet) where T : IPinInterface
        {
            return proxyRef.Instance.SetMergeSegment(bSet);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetNameSymbolExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetNameSymbol(name);
        }

        public static int SetNetSegmentPathIdsExt<T>(this ProxyBase<T> proxyRef,ref object netsegids) where T : IPinInterface
        {
            return proxyRef.Instance.SetNetSegmentPathIds(ref netsegids);
        }

        public static int SetNodeIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IPinInterface
        {
            return proxyRef.Instance.SetNodeId(id);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : IPinInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static double SetOuterDiameterExt<T>(this ProxyBase<T> proxyRef,double newval) where T : IPinInterface
        {
            return proxyRef.Instance.SetOuterDiameter(newval);
        }

        public static int SetPanelPathExt<T>(this ProxyBase<T> proxyRef,int pnts, ref object x, ref object y, ref object z, int use_exact_coords = 0) where T : IPinInterface
        {
            return proxyRef.Instance.SetPanelPath(pnts, ref x, ref y, ref z, use_exact_coords);
        }

        public static int SetPhysicalConnectionDirectionExt<T>(this ProxyBase<T> proxyRef,int conndir) where T : IPinInterface
        {
            return proxyRef.Instance.SetPhysicalConnectionDirection(conndir);
        }

        public static int SetPhysicalConnectionTypeExt<T>(this ProxyBase<T> proxyRef,int conntyp) where T : IPinInterface
        {
            return proxyRef.Instance.SetPhysicalConnectionType(conntyp);
        }

        public static int SetPhysicalMaxConnectionsExt<T>(this ProxyBase<T> proxyRef,int conncount) where T : IPinInterface
        {
            return proxyRef.Instance.SetPhysicalMaxConnections(conncount);
        }

        public static int SetSignalNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetSignalName(name);
        }

        public static int SetWireTypeExt<T>(this ProxyBase<T> proxyRef,string comp, string name) where T : IPinInterface
        {
            return proxyRef.Instance.SetWireType(comp, name);
        }

        public static int UnassignFromExt<T>(this ProxyBase<T> proxyRef,int id) where T : IPinInterface
        {
            return proxyRef.Instance.UnassignFrom(id);
        }

        public static int UnlockObjectExt<T>(this ProxyBase<T> proxyRef,string password) where T : IPinInterface
        {
            return proxyRef.Instance.UnlockObject(password);
        }
        
    }
}