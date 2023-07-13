using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3JobProxy
    {
        public static int ActivateOptionAlias<T>(this ProxyBase<T> proxyRef,string alias) where T : IJobInterface
        {
            return proxyRef.Instance.ActivateOptionAlias(alias);
        }

        public static int ActivateOptionIds<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.ActivateOptionIds(ref ids);
        }

        public static int AddAttributeValue<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IJobInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int AddOptionAlias<T>(this ProxyBase<T> proxyRef,string name, string description) where T : IJobInterface
        {
            return proxyRef.Instance.AddOptionAlias(name, description);
        }

        public static int ClearItemCollectors<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.ClearItemCollectors();
        }

        public static int Close<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.Close();
        }

        public static int ConvertMultiByteToWideChar<T>(this ProxyBase<T> proxyRef,int code_page) where T : IJobInterface
        {
            return proxyRef.Instance.ConvertMultiByteToWideChar(code_page);
        }

        public static int Create<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.Create(name);
        }

        public static object CreateAttributeObject<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateAttributeObject();
        }

        public static object CreateBinDataObject<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateBinDataObject();
        }

        public static object CreateBoardObject<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateBoardObject();
        }

        public static object CreateBundleObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateBundleObject();
        }

        public static object CreateComponentObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateComponentObject();
        }

        public static object CreateConnectionObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateConnectionObject();
        }

        public static object CreateConnectLineObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateConnectLineObject();
        }

        public static object CreateDebugObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateDebugObject();
        }

        public static object CreateDeviceObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateDeviceObject();
        }

        public static object CreateDimensionObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateDimensionObject();
        }

        public static object CreateExternalDocumentObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateExternalDocumentObject();
        }

        public static object CreateFieldObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateFieldObject();
        }

        public static object CreateFunctionalPortObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateFunctionalPortObject();
        }

        public static object CreateFunctionalUnitObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateFunctionalUnitObject();
        }

        public static object CreateGraphObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateGraphObject();
        }

        public static object CreateGroupObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateGroupObject();
        }

        public static int CreateInlineConnectorsExt<T>(this ProxyBase<T> proxyRef,out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs,
            ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion) where T : IJobInterface
        {
            return proxyRef.Instance.CreateInlineConnectors(out newCoreIDs, out newDeviceIDs, flags, ref fromPinIDs, ref toPinIDs, ref viewNumbers, ref fBSheetIDs, CompName, CompVersion);
        }

        public static int CreateInlineConnectorsExExt<T>(this ProxyBase<T> proxyRef,out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs,
            ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion,
            ref object newSymbolIDs) where T : IJobInterface
        {
            return proxyRef.Instance.CreateInlineConnectorsEx(out newCoreIDs, out newDeviceIDs, flags, ref fromPinIDs, ref toPinIDs, ref viewNumbers, ref fBSheetIDs, CompName, CompVersion, ref newSymbolIDs);
        }

        public static object CreateLayerObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateLayerObject();
        }

        public static object CreateModuleObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateModuleObject();
        }

        public static object CreateModulePortObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateModulePortObject();
        }

        public static object CreateNetObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateNetObject();
        }

        public static object CreateNetSegmentObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateNetSegmentObject();
        }

        public static object CreateOptionObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateOptionObject();
        }

        public static object CreateOutlineObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateOutlineObject();
        }

        public static object CreatePinObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreatePinObject();
        }

        public static object CreateSheetObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSheetObject();
        }

        public static object CreateSignalClassObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSignalClassObject();
        }

        public static object CreateSignalObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSignalObject();
        }

        public static object CreateSlotObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSlotObject();
        }

        public static object CreateStructureNodeObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateStructureNodeObject();
        }

        public static object CreateSupplyObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSupplyObject();
        }

        public static object CreateSymbolObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateSymbolObject();
        }

        public static object CreateTestpointObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateTestpointObject();
        }

        public static object CreateTextObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateTextObject();
        }

        public static object CreateTreeObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateTreeObject();
        }

        public static object CreateVariantObjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.CreateVariantObject();
        }

        public static int DeactivateOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.DeactivateOptionIds(ref ids);
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DeleteAttributeDefinitionExt<T>(this ProxyBase<T> proxyRef,string attnam) where T : IJobInterface
        {
            return proxyRef.Instance.DeleteAttributeDefinition(attnam);
        }

        public static int DeleteMultiuserExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.DeleteMultiuser(name);
        }

        public static int DeleteOptionAliasExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.DeleteOptionAlias(name);
        }

        public static int DisablePointGridDisplayExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.DisablePointGridDisplay();
        }

        public static int DisableRulerGridDisplayExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.DisableRulerGridDisplay();
        }

        public static void DisableSuffixSuppressionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            proxyRef.Instance.DisableSuffixSuppression();
        }

        public static int DumpItemExt<T>(this ProxyBase<T> proxyRef,int id) where T : IJobInterface
        {
            return proxyRef.Instance.DumpItem(id);
        }

        public static int EnablePointGridDisplayExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.EnablePointGridDisplay();
        }

        public static int EnableRulerGridDisplayExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.EnableRulerGridDisplay();
        }

        public static void EnableSuffixSuppressionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            proxyRef.Instance.EnableSuffixSuppression();
        }

        public static int ExportAllComponentsToDBExt<T>(this ProxyBase<T> proxyRef,int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportAllComponentsToDB(bOverwrite);
        }

        public static int ExportAllModelsToDBExt<T>(this ProxyBase<T> proxyRef,int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportAllModelsToDB(bOverwrite);
        }

        public static int ExportAllSymbolsToDBExt<T>(this ProxyBase<T> proxyRef,int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportAllSymbolsToDB(bOverwrite);
        }

        public static int ExportBoardLayoutExt<T>(this ProxyBase<T> proxyRef,string type, string file = null, int flags = 0, string map = null) where T : IJobInterface
        {
            return proxyRef.Instance.ExportBoardLayout(type, file, flags, map);
        }

        public static int ExportBoardLayoutExt<T>(this ProxyBase<T> proxyRef,string type, string file, int flags, string map, ref object exclusions) where T : IJobInterface
        {
            return proxyRef.Instance.ExportBoardLayout(type, file, flags, map, ref exclusions);
        }

        public static int ExportCGMExt<T>(this ProxyBase<T> proxyRef,string file, ref object shtids, int options) where T : IJobInterface
        {
            return proxyRef.Instance.ExportCGM(file, ref shtids, options);
        }

        public static int ExportComponentToDBExt<T>(this ProxyBase<T> proxyRef,string CompName, string CompVersion, int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportComponentToDB(CompName, CompVersion, bOverwrite);
        }

        public static int ExportDrawingExt<T>(this ProxyBase<T> proxyRef,string name, ref object shtids, int options) where T : IJobInterface
        {
            return proxyRef.Instance.ExportDrawing(name, ref shtids, options);
        }

        public static int ExportForeignExt<T>(this ProxyBase<T> proxyRef,string format, string file) where T : IJobInterface
        {
            return proxyRef.Instance.ExportForeign(format, file);
        }

        public static int ExportImageItemsExt<T>(this ProxyBase<T> proxyRef,string format, int version, string file, ref object items, int percentage, int width, int height,
            int clrdepth, int gray, int dpiX, int dpiY, int compressionmode) where T : IJobInterface
        {
            return proxyRef.Instance.ExportImageItems(format, version, file, ref items, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
        }

        public static int ExportModelToDBExt<T>(this ProxyBase<T> proxyRef,string CompName, string CompVersion, int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportModelToDB(CompName, CompVersion, bOverwrite);
        }

        public static int ExportMultiuserExt<T>(this ProxyBase<T> proxyRef,string file, uint fileformat, string name) where T : IJobInterface
        {
            return proxyRef.Instance.ExportMultiuser(file, fileformat, name);
        }

        public static int ExportPDFExt<T>(this ProxyBase<T> proxyRef,string file, ref object shtids, int options, string password = null) where T : IJobInterface
        {
            return proxyRef.Instance.ExportPDF(file, ref shtids, options, password);
        }

        public static int ExportPDFExExt<T>(this ProxyBase<T> proxyRef,string file, ref object shtids, int options, int itemListType, ref object items, int alternativeColour,
            int imageBrightness, string password = null) where T : IJobInterface
        {
            return proxyRef.Instance.ExportPDFEx(file, ref shtids, options, itemListType, ref items, alternativeColour, imageBrightness, password);
        }

        public static int ExportSVGByAreaExt<T>(this ProxyBase<T> proxyRef,string file, int shtId, double xMin, double yMin, double xMax, double yMax, double originX,
            double originY, int selectionMode) where T : IJobInterface
        {
            return proxyRef.Instance.ExportSVGByArea(file, shtId, xMin, yMin, xMax, yMax, originX, originY, selectionMode);
        }

        public static int ExportSVGBySheetExt<T>(this ProxyBase<T> proxyRef,string file, ref object shtids) where T : IJobInterface
        {
            return proxyRef.Instance.ExportSVGBySheet(file, ref shtids);
        }

        public static int ExportSVGBySheetExExt<T>(this ProxyBase<T> proxyRef,string file, ref object shtids, int options) where T : IJobInterface
        {
            return proxyRef.Instance.ExportSVGBySheetEx(file, ref shtids, options);
        }

        public static int ExportSymbolToDBExt<T>(this ProxyBase<T> proxyRef,string SymbolName, string SymbolVersion, int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportSymbolToDB(SymbolName, SymbolVersion, bOverwrite);
        }

        public static int ExportTemplateExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.ExportTemplate(filename);
        }

        public static int ExportToDBExt<T>(this ProxyBase<T> proxyRef,int bOverwrite) where T : IJobInterface
        {
            return proxyRef.Instance.ExportToDB(bOverwrite);
        }

        public static int ExportXVLExt<T>(this ProxyBase<T> proxyRef,string file, ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.ExportXVL(file, ref ids);
        }

        public static int FinalizeTransactionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.FinalizeTransaction();
        }

        public static int FindPanelPathExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.FindPanelPath();
        }

        public static int FreeWireNumberExt<T>(this ProxyBase<T> proxyRef,int number) where T : IJobInterface
        {
            return proxyRef.Instance.FreeWireNumber(number);
        }

        public static int GetActiveOptionCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveOptionCount();
        }

        public static int GetActiveOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveOptionIds(ref ids);
        }

        public static int GetActiveSheetIdExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveSheetId();
        }

        public static int GetActiveSheetTreeIDExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveSheetTreeID();
        }

        public static int GetActiveTreeIDExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveTreeID();
        }

        public static int GetActiveVariantIdExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetActiveVariantId();
        }

        public static int GetAddDeviceDesignationOfConnectionTargetExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAddDeviceDesignationOfConnectionTarget();
        }

        public static int GetAllComponentCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllComponentCount();
        }

        public static int GetAllComponentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllComponentIds(ref ids);
        }

        public static int GetAllConnectionCountExt<T>(this ProxyBase<T> proxyRef,int flags = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllConnectionCount(flags);
        }

        public static int GetAllConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int flags = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllConnectionIds(ref ids, flags);
        }

        public static int GetAllDeviceCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllDeviceCount();
        }

        public static int GetAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllDeviceIds(ref ids);
        }

        public static int GetAllOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllOptionIds(ref ids);
        }

        public static int GetAllParentSheetIdsExt<T>(this ProxyBase<T> proxyRef,int flags, ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllParentSheetIds(flags, ref ids);
        }

        public static int GetAllSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAllSheetIds(ref ids);
        }

        public static double GetAltGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAltGridSize();
        }

        public static int GetAnyAttributeIdsExt<T>(this ProxyBase<T> proxyRef,string attnam, ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetAnyAttributeIds(attnam, ref ids);
        }

        public static string GetAssignmentSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAssignmentSeparator();
        }

        public static string GetAssignmentSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAssignmentSuffixSeparator();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IJobInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static int GetAttributeNotInheritableExt<T>(this ProxyBase<T> proxyRef,string attnam) where T : IJobInterface
        {
            return proxyRef.Instance.GetAttributeNotInheritable(attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetAvailableLanguagesExt<T>(this ProxyBase<T> proxyRef,ref object languages) where T : IJobInterface
        {
            return proxyRef.Instance.GetAvailableLanguages(ref languages);
        }

        public static int GetBlockCopyGraphicInSplitExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockCopyGraphicInSplit();
        }

        public static int GetBlockCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockCount();
        }

        public static int GetBlockIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockIds(ref ids);
        }

        public static int GetBlockReferenceTextDirectionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockReferenceTextDirection();
        }

        public static double GetBlockReferenceTextGapExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockReferenceTextGap();
        }

        public static int GetBlockReferenceTextLevelExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockReferenceTextLevel();
        }

        public static int GetBlockReferenceTextRotateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockReferenceTextRotate();
        }

        public static int GetBlockReferenceTypeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockReferenceType();
        }

        public static int GetBlockTextAlignmentExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextAlignment();
        }

        public static int GetBlockTextColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextColour();
        }

        public static string GetBlockTextFontExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextFont();
        }

        public static int GetBlockTextRatioExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextRatio();
        }

        public static double GetBlockTextSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextSize();
        }

        public static int GetBlockTextStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBlockTextStyle();
        }

        public static int GetBoardIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetBoardIds(ref ids);
        }

        public static int GetBomPartListExt<T>(this ProxyBase<T> proxyRef,string consumer, string outputFormatVersion, int flags, string keyAttribut, string quantityAttribut,
            string lengthAttribut, ref object additionalAttributes) where T : IJobInterface
        {
            return proxyRef.Instance.GetBomPartList(consumer, outputFormatVersion, flags, keyAttribut, quantityAttribut, lengthAttribut, ref additionalAttributes);
        }

        public static int GetBomPartListExt<T>(this ProxyBase<T> proxyRef,string consumer, string outputFormatVersion, int flags, string keyAttribut, string quantityAttribut,
            string lengthAttribut, ref object additionalAttributes, ref object result) where T : IJobInterface
        {
            return proxyRef.Instance.GetBomPartList(consumer, outputFormatVersion, flags, keyAttribut, quantityAttribut, lengthAttribut, ref additionalAttributes, ref result);
        }

        public static int GetBooleanStateExt<T>(this ProxyBase<T> proxyRef,string expression) where T : IJobInterface
        {
            return proxyRef.Instance.GetBooleanState(expression);
        }

        public static int GetBundleCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBundleCount();
        }

        public static int GetBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetBundleIds(ref ids);
        }

        public static int GetBusLineColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBusLineColour();
        }

        public static int GetBusLineLevelExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBusLineLevel();
        }

        public static int GetBusLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBusLineStyle();
        }

        public static int GetBusLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBusLineWidth();
        }

        public static double GetBusLineWidthExExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetBusLineWidthEx();
        }

        public static int GetCableCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetCableCount();
        }

        public static int GetCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetCableIds(ref ids);
        }

        public static int GetCableTypeCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetCableTypeCount();
        }

        public static int GetCableTypeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetCableTypeIds(ref ids);
        }

        public static int GetCadstarCrossProbingExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetCadstarCrossProbing();
        }

        public static int GetComponentCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetComponentCount();
        }

        public static int GetComponentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetComponentIds(ref ids);
        }

        public static int GetConnectionCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionCount();
        }

        public static int GetConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionIds(ref ids);
        }

        public static double GetConnectionInclinationAngleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionInclinationAngle();
        }

        public static double GetConnectionInclinationDistanceExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionInclinationDistance();
        }

        public static int GetConnectionModeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionMode();
        }

        public static int GetConnectionTargetFormatExt<T>(this ProxyBase<T> proxyRef,int txttyp, out object flags, out object entire_prefix, out object entire_suffix,
            out object count, out object prefix, out object name, out object funct) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectionTargetFormat(txttyp, out flags, out entire_prefix, out entire_suffix, out count, out prefix, out name, out funct);
        }

        public static int GetConnectorCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectorCount();
        }

        public static int GetConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectorIds(ref ids);
        }

        public static int GetConnectorPinTerminalParameterOverwriteModelPinExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectorPinTerminalParameterOverwriteModelPin();
        }

        public static int GetConnectorSymbolFormatExt<T>(this ProxyBase<T> proxyRef,out object texttypes, out object dispflags) where T : IJobInterface
        {
            return proxyRef.Instance.GetConnectorSymbolFormat(out texttypes, out dispflags);
        }

        public static int GetCreateUniqueSheetNamesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetCreateUniqueSheetNames();
        }

        public static string GetCurrentUserNameExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetCurrentUserName();
        }

        public static int GetCurrentUserNamesExt<T>(this ProxyBase<T> proxyRef,ref object names) where T : IJobInterface
        {
            return proxyRef.Instance.GetCurrentUserNames(ref names);
        }

        public static int GetCursorPositionExt<T>(this ProxyBase<T> proxyRef,ref object xpos, ref object ypos) where T : IJobInterface
        {
            return proxyRef.Instance.GetCursorPosition(ref xpos, ref ypos);
        }

        public static int GetDefaultHoseTubeExt<T>(this ProxyBase<T> proxyRef,out object HoseTube) where T : IJobInterface
        {
            return proxyRef.Instance.GetDefaultHoseTube(out HoseTube);
        }

        public static int GetDefaultJumperExt<T>(this ProxyBase<T> proxyRef,out object jumpergroup, out object jumpername) where T : IJobInterface
        {
            return proxyRef.Instance.GetDefaultJumper(out jumpergroup, out jumpername);
        }

        public static int GetDefaultWireExt<T>(this ProxyBase<T> proxyRef,out object wiregroup, out object wirename) where T : IJobInterface
        {
            return proxyRef.Instance.GetDefaultWire(out wiregroup, out wirename);
        }

        public static int GetDeleteCoresOnDelClineExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeleteCoresOnDelCline();
        }

        public static int GetDeletePinAttributesOnUnplaceExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeletePinAttributesOnUnplace();
        }

        public static int GetDeleteSignalOnDelClineExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeleteSignalOnDelCline();
        }

        public static int GetDetermineConnectorSymbolExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDetermineConnectorSymbol();
        }

        public static int GetDetermineConnectorViewSymbolExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDetermineConnectorViewSymbol();
        }

        public static int GetDeviceCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeviceCount();
        }

        public static int GetDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeviceIds(ref ids);
        }

        public static string GetDeviceNameSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeviceNameSeparator();
        }

        public static string GetDeviceNameSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDeviceNameSuffixSeparator();
        }

        public static string GetDisplayAltCompCodeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayAltCompCode();
        }

        public static int GetDisplayAppendFormboardNameToDeviceNameExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayAppendFormboardNameToDeviceName();
        }

        public static int GetDisplayConnectionModeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayConnectionMode();
        }

        public static int GetDisplayConnectionTypeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayConnectionType();
        }

        public static int GetDisplayConnectPointsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayConnectPoints();
        }

        public static int GetDisplayDuctDockingPointsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayDuctDockingPoints();
        }

        public static int GetDisplayDuctFillSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayDuctFillSize();
        }

        public static int GetDisplayFormboardEffectiveDirectionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayFormboardEffectiveDirection();
        }

        public static int GetDisplayFormboardMarkDifferenLengthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayFormboardMarkDifferenLength();
        }

        public static int GetDisplayFormboardNodesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayFormboardNodes();
        }

        public static int GetDisplayFormboardTableSubsidiaryLinesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayFormboardTableSubsidiaryLines();
        }

        public static int GetDisplayFormboardUnconnectedCoresExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayFormboardUnconnectedCores();
        }

        public static int GetDisplayIntExtRepresentationExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayIntExtRepresentation();
        }

        public static int GetDisplayMILStandardExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayMILStandard();
        }

        public static int GetDisplayOptionsAllExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayOptionsAll();
        }

        public static int GetDisplayOptionsColouredExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayOptionsColoured();
        }

        public static int GetDisplayOptionsNoneExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayOptionsNone();
        }

        public static int GetDisplayRotatedTextAccStandardExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayRotatedTextAccStandard();
        }

        public static int GetDisplayUnconnectedNodesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayUnconnectedNodes();
        }

        public static int GetDisplayViewNumbersExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetDisplayViewNumbers();
        }

        public static int GetExclusiveModeExt<T>(this ProxyBase<T> proxyRef,string name, out object user) where T : IJobInterface
        {
            return proxyRef.Instance.GetExclusiveMode(name, out user);
        }

        public static int GetExportWithCablesAndWiresExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetExportWithCablesAndWires();
        }

        public static int GetExportWithCablesAndWiresOptionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetExportWithCablesAndWiresOption();
        }

        public static int GetExternalDocumentCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetExternalDocumentCount();
        }

        public static int GetExternalDocumentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetExternalDocumentIds(ref ids);
        }

        public static int GetFieldCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldCount();
        }

        public static int GetFieldHatchColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldHatchColour();
        }

        public static double GetFieldHatchLineDistanceExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldHatchLineDistance();
        }

        public static double GetFieldHatchLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldHatchLineWidth();
        }

        public static int GetFieldHatchPatternExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldHatchPattern();
        }

        public static int GetFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldIds(ref ids);
        }

        public static int GetFieldOutlineColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldOutlineColour();
        }

        public static int GetFieldOutlineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldOutlineStyle();
        }

        public static double GetFieldOutlineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldOutlineWidth();
        }

        public static string GetFieldTextTemplateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFieldTextTemplate();
        }

        public static int GetFileVersionExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.GetFileVersion(filename);
        }

        public static int GetFormboardAutoplaceTableSymbolExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFormboardAutoplaceTableSymbol();
        }

        public static int GetFormboardAutorotateConnectorSymbolsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFormboardAutorotateConnectorSymbols();
        }

        public static int GetFormboardBranchAngleStepExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetFormboardBranchAngleStep();
        }

        public static int GetFunctionalUnitIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetFunctionalUnitIds(ref ids);
        }

        public static double GetGapToPlaceSinglePinsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGapToPlaceSinglePins();
        }

        public static int GetGeneratedWireNameFormatExt<T>(this ProxyBase<T> proxyRef,out object prefix, out object separator, out object postfix, out object attPrefix,
            out object attType, out object attname) where T : IJobInterface
        {
            return proxyRef.Instance.GetGeneratedWireNameFormat(out prefix, out separator, out postfix, out attPrefix, out attType, out attname);
        }

        public static int GetGetterOptionHandlingModeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGetterOptionHandlingMode();
        }

        public static string GetGidOfIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IJobInterface
        {
            return proxyRef.Instance.GetGidOfId(id);
        }

        public static int GetGraphArrowsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphArrows();
        }

        public static int GetGraphColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphColour();
        }

        public static int GetGraphHatchColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphHatchColour();
        }

        public static double GetGraphHatchDistanceExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphHatchDistance();
        }

        public static int GetGraphHatchPatternExt<T>(this ProxyBase<T> proxyRef,ref object angle1, ref object angle2) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphHatchPattern(ref angle1, ref angle2);
        }

        public static int GetGraphHatchStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphHatchStyle();
        }

        public static double GetGraphHatchWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphHatchWidth();
        }

        public static int GetGraphLevelExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphLevel();
        }

        public static int GetGraphStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphStyle();
        }

        public static int GetGraphTextColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextColour();
        }

        public static int GetGraphTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextCount();
        }

        public static string GetGraphTextFontNameExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextFontName();
        }

        public static double GetGraphTextHeightExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextHeight();
        }

        public static int GetGraphTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextIds(ref ids);
        }

        public static int GetGraphTextLevelExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextLevel();
        }

        public static int GetGraphTextModeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextMode();
        }

        public static double GetGraphTextSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextSize();
        }

        public static int GetGraphTextStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphTextStyle();
        }

        public static double GetGraphWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGraphWidth();
        }

        public static double GetGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetGridSize();
        }

        public static int GetGroupIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetGroupIds(ref ids);
        }

        public static int GetHarnessIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetHarnessIds(ref ids);
        }

        public static int GetHighlightColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetHighlightColour();
        }

        public static int GetHighlightKeepExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetHighlightKeep();
        }

        public static double GetHighlightLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetHighlightLineWidth();
        }

        public static int GetHoseIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetHoseIds(ref ids);
        }

        public static int GetHyperlinkTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetHyperlinkTextIds(ref ids);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetIdOfGidExt<T>(this ProxyBase<T> proxyRef,string gid) where T : IJobInterface
        {
            return proxyRef.Instance.GetIdOfGid(gid);
        }

        public static int GetIEC61346SettingExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetIEC61346Setting();
        }

        public static string GetImportItemDesignationSuffixExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportItemDesignationSuffix();
        }

        public static int GetImportMergeAttributesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeAttributes();
        }

        public static int GetImportMergeConnectLinesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeConnectLines();
        }

        public static int GetImportMergeExistingAssembliesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeExistingAssemblies();
        }

        public static int GetImportMergeExistingDevicesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeExistingDevices();
        }

        public static int GetImportMergeExistingTerminalStripsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeExistingTerminalStrips();
        }

        public static int GetImportMergeOptionsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportMergeOptions();
        }

        public static int GetImportUseItemDesignationSuffixExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetImportUseItemDesignationSuffix();
        }

        public static int GetItemSheetIdsExt<T>(this ProxyBase<T> proxyRef,int item, out object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetItemSheetIds(item, out ids);
        }

        public static int GetItemTypeExt<T>(this ProxyBase<T> proxyRef,int id) where T : IJobInterface
        {
            return proxyRef.Instance.GetItemType(id);
        }

        public static int GetKeepActiveConnectorPinTerminalOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepActiveConnectorPinTerminalOnUpdate();
        }

        public static int GetKeepActiveCounterpartOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepActiveCounterpartOnUpdate();
        }

        public static int GetKeepActiveFittingOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepActiveFittingOnUpdate();
        }

        public static int GetKeepConnectorSymbolsOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepConnectorSymbolsOnUpdate();
        }

        public static int GetKeepModelTextParametersOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepModelTextParametersOnUpdate();
        }

        public static int GetKeepModelTextVisibilityOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepModelTextVisibilityOnUpdate();
        }

        public static int GetKeepSymbolTextParametersOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepSymbolTextParametersOnUpdate();
        }

        public static int GetKeepSymbolTextVisibilityOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetKeepSymbolTextVisibilityOnUpdate();
        }

        public static int GetLanguagesExt<T>(this ProxyBase<T> proxyRef,ref object languages) where T : IJobInterface
        {
            return proxyRef.Instance.GetLanguages(ref languages);
        }

        public static int GetLastAddedItemsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int type = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetLastAddedItems(ref ids, type);
        }

        public static int GetLastDeletedAttributeValuesExt<T>(this ProxyBase<T> proxyRef,ref object owner_ids, ref object attribute_names, ref object attribute_values) where T : IJobInterface
        {
            return proxyRef.Instance.GetLastDeletedAttributeValues(ref owner_ids, ref attribute_names, ref attribute_values);
        }

        public static int GetLastDeletedItemsExt<T>(this ProxyBase<T> proxyRef,ref object items, int type) where T : IJobInterface
        {
            return proxyRef.Instance.GetLastDeletedItems(ref items, type);
        }

        public static int GetLastModifiedItemsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int type = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetLastModifiedItems(ref ids, type);
        }

        public static int GetLayerIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetLayerIds(ref ids);
        }

        public static int GetLevelIndexExt<T>(this ProxyBase<T> proxyRef,string value) where T : IJobInterface
        {
            return proxyRef.Instance.GetLevelIndex(value);
        }

        public static string GetLevelNameExt<T>(this ProxyBase<T> proxyRef,int level) where T : IJobInterface
        {
            return proxyRef.Instance.GetLevelName(level);
        }

        public static int GetLevelsExt<T>(this ProxyBase<T> proxyRef,ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr) where T : IJobInterface
        {
            return proxyRef.Instance.GetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr);
        }

        public static int GetLevelsExt<T>(this ProxyBase<T> proxyRef,ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr, ref object names) where T : IJobInterface
        {
            return proxyRef.Instance.GetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr, ref names);
        }

        public static int GetLineColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLineColour();
        }

        public static int GetLineLevelExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLineLevel();
        }

        public static int GetLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLineStyle();
        }

        public static int GetLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLineWidth();
        }

        public static double GetLineWidthExExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLineWidthEx();
        }

        public static string GetLocationSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLocationSeparator();
        }

        public static string GetLocationSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetLocationSuffixSeparator();
        }

        public static string GetMeasureExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMeasure();
        }

        public static int GetMergeAlphanumericReferencesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMergeAlphanumericReferences();
        }

        public static int GetMergeSheetReferencesExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMergeSheetReferences();
        }

        public static int GetMergeUsingExactCoreConnectionOnImportExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMergeUsingExactCoreConnectionOnImport();
        }

        public static int GetMILGraphicLineColourExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMILGraphicLineColour();
        }

        public static int GetMILGraphicLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMILGraphicLineStyle();
        }

        public static double GetMILGraphicLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMILGraphicLineWidth();
        }

        public static int GetModuleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetModuleIds(ref ids);
        }

        public static string GetMultiuserPathExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetMultiuserPath();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNetIds(ref ids);
        }

        public static int GetNetSegmentAttributeSplittingRuleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetNetSegmentAttributeSplittingRule();
        }

        public static int GetNetSegmentLengthSplittingRuleExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetNetSegmentLengthSplittingRule();
        }

        public static int GetNewAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewAllDeviceIds(ref ids);
        }

        public static int GetNewBlockIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewBlockIds(ref ids);
        }

        public static int GetNewBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewBundleIds(ref ids);
        }

        public static int GetNewCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewCableIds(ref ids);
        }

        public static int GetNewConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewConnectionIds(ref ids);
        }

        public static int GetNewConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewConnectorIds(ref ids);
        }

        public static int GetNewCoreIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewCoreIds(ref ids);
        }

        public static int GetNewDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewDeviceIds(ref ids);
        }

        public static int GetNewFieldIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewFieldIds(ref ids);
        }

        public static int GetNewGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewGraphIds(ref ids);
        }

        public static int GetNewNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewNetSegmentIds(ref ids);
        }

        public static int GetNewSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewSheetIds(ref ids);
        }

        public static int GetNewSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewSignalIds(ref ids);
        }

        public static int GetNewSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewSymbolIds(ref ids);
        }

        public static int GetNewTerminalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetNewTerminalIds(ref ids);
        }

        public static int GetNewTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IJobInterface
        {
            return proxyRef.Instance.GetNewTextIds(ref ids, txttyp, search_string);
        }

        public static int GetNextWireNumberExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetNextWireNumber();
        }

        public static string GetNextWireNumberFormattedExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetNextWireNumberFormatted();
        }

        public static int GetOptionAliasesExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionAliases(ref ids);
        }

        public static int GetOptionCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionCount();
        }

        public static int GetOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionIds(ref ids);
        }

        public static int GetOptionLockIDExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionLockID();
        }

        public static int GetOptionLockIDsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionLockIDs(ref ids);
        }

        public static string GetOptionTermDescriptionExt<T>(this ProxyBase<T> proxyRef,string alias) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionTermDescription(alias);
        }

        public static int GetOptionTermsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOptionTerms(ref ids);
        }

        public static int GetOutbarTextExt<T>(this ProxyBase<T> proxyRef,int index, ref object lst) where T : IJobInterface
        {
            return proxyRef.Instance.GetOutbarText(index, ref lst);
        }

        public static int GetOutdatedAllComponentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOutdatedAllComponentIds(ref ids);
        }

        public static int GetOutdatedCableTypeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOutdatedCableTypeIds(ref ids);
        }

        public static int GetOutdatedComponentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOutdatedComponentIds(ref ids);
        }

        public static int GetOutdatedSymbolTypeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOutdatedSymbolTypeIds(ref ids);
        }

        public static double GetOuterDiameterExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetOuterDiameter(ref ids);
        }

        public static double GetPanelAltGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPanelAltGridSize();
        }

        public static double GetPanelGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPanelGridSize();
        }

        public static double GetPanelTrapSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPanelTrapSize();
        }

        public static int GetParentSheetIdsExt<T>(this ProxyBase<T> proxyRef,int flags, ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetParentSheetIds(flags, ref ids);
        }

        public static int GetPartExtensionExt<T>(this ProxyBase<T> proxyRef,string part, string vers, ref object xl, ref object yl, ref object xh, ref object yh,
            ref object shtcnt, ref object xp, ref object yp, ref object subcircuitType) where T : IJobInterface
        {
            return proxyRef.Instance.GetPartExtension(part, vers, ref xl, ref yl, ref xh, ref yh, ref shtcnt, ref xp, ref yp, ref subcircuitType);
        }

        public static string GetPathExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPath();
        }

        public static string GetPinViewSymbolForBlockConnectorPinsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPinViewSymbolForBlockConnectorPins();
        }

        public static string GetPinViewSymbolForConnectorPinsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPinViewSymbolForConnectorPins();
        }

        public static string GetPinViewSymbolForDevicePinsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPinViewSymbolForDevicePins();
        }

        public static double GetPointGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPointGridSize();
        }

        public static string GetPortNameSeparatorExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPortNameSeparator();
        }

        public static object GetProjectPropertyExt<T>(this ProxyBase<T> proxyRef,string what) where T : IJobInterface
        {
            return proxyRef.Instance.GetProjectProperty(what);
        }

        public static int GetPurgeUnplacedPinViewsBeforeSaveExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPurgeUnplacedPinViewsBeforeSave();
        }

        public static int GetPurgeUnusedBeforeSaveExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetPurgeUnusedBeforeSave();
        }

        public static int GetRedlinedGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetRedlinedGraphIds(ref ids);
        }

        public static int GetRedlinedGraphTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetRedlinedGraphTextIds(ref ids);
        }

        public static int GetReloadAttributesOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetReloadAttributesOnUpdate();
        }

        public static int GetRestoreChangedPinNamesOnUpdateExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetRestoreChangedPinNamesOnUpdate();
        }

        public static int GetResultTextExt<T>(this ProxyBase<T> proxyRef,int index, ref object lst) where T : IJobInterface
        {
            return proxyRef.Instance.GetResultText(index, ref lst);
        }

        public static int GetRGBValueExt<T>(this ProxyBase<T> proxyRef,int index, ref object r, ref object g, ref object b) where T : IJobInterface
        {
            return proxyRef.Instance.GetRGBValue(index, ref r, ref g, ref b);
        }

        public static int GetRootModuleIdExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetRootModuleId();
        }

        public static double GetRulerGridSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetRulerGridSize();
        }

        public static string GetSchematicTypeDescriptionExt<T>(this ProxyBase<T> proxyRef,int type) where T : IJobInterface
        {
            return proxyRef.Instance.GetSchematicTypeDescription(type);
        }

        public static int GetSelectedAllDeviceCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedAllDeviceCount();
        }

        public static int GetSelectedAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedAllDeviceIds(ref ids);
        }

        public static int GetSelectedBlockCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedBlockCount();
        }

        public static int GetSelectedBlockIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedBlockIds(ref ids);
        }

        public static int GetSelectedBundleCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedBundleCount();
        }

        public static int GetSelectedBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedBundleIds(ref ids);
        }

        public static int GetSelectedCableCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedCableCount();
        }

        public static int GetSelectedCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedCableIds(ref ids);
        }

        public static int GetSelectedConnectionCountExt<T>(this ProxyBase<T> proxyRef,int flags = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedConnectionCount(flags);
        }

        public static int GetSelectedConnectionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int flags = 0) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedConnectionIds(ref ids, flags);
        }

        public static int GetSelectedConnectorCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedConnectorCount();
        }

        public static int GetSelectedConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedConnectorIds(ref ids);
        }

        public static int GetSelectedDeviceCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedDeviceCount();
        }

        public static int GetSelectedDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedDeviceIds(ref ids);
        }

        public static int GetSelectedDimensionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedDimensionIds(ref ids);
        }

        public static int GetSelectedGraphCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedGraphCount();
        }

        public static int GetSelectedGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedGraphIds(ref ids);
        }

        public static int GetSelectedNetSegmentCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedNetSegmentCount();
        }

        public static int GetSelectedNetSegmentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedNetSegmentIds(ref ids);
        }

        public static int GetSelectedSheetCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSheetCount();
        }

        public static int GetSelectedSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSheetIds(ref ids);
        }

        public static int GetSelectedSignalCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSignalCount();
        }

        public static int GetSelectedSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSignalIds(ref ids);
        }

        public static int GetSelectedSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSymbolCount();
        }

        public static int GetSelectedSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedSymbolIds(ref ids);
        }

        public static int GetSelectedTerminalCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedTerminalCount();
        }

        public static int GetSelectedTerminalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedTerminalIds(ref ids);
        }

        public static int GetSelectedTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedTextCount();
        }

        public static int GetSelectedTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSelectedTextIds(ref ids);
        }

        public static object GetSettingValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.GetSettingValue(name);
        }

        public static int GetSheetCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSheetCount();
        }

        public static int GetSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSheetIds(ref ids);
        }

        public static int GetSheetTreeStructureExt<T>(this ProxyBase<T> proxyRef,ref object structarr, ref object info) where T : IJobInterface
        {
            return proxyRef.Instance.GetSheetTreeStructure(ref structarr, ref info);
        }

        public static int GetShortcutPositionExt<T>(this ProxyBase<T> proxyRef,ref object xpos, ref object ypos) where T : IJobInterface
        {
            return proxyRef.Instance.GetShortcutPosition(ref xpos, ref ypos);
        }

        public static int GetSignalClassIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSignalClassIds(ref ids);
        }

        public static int GetSignalCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSignalCount();
        }

        public static int GetSignalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSignalIds(ref ids);
        }

        public static int GetSignalStructureNodeIdExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSignalStructureNodeId();
        }

        public static int GetStructureNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetStructureNodeIds(ref ids);
        }

        public static int GetSupplyIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSupplyIds(ref ids);
        }

        public static int GetSymbolCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSymbolCount();
        }

        public static string GetSymbolForBlockConnectorsWithoutCompcodeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSymbolForBlockConnectorsWithoutCompcode();
        }

        public static string GetSymbolForConnectorsWithoutCompcodeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetSymbolForConnectorsWithoutCompcode();
        }

        public static int GetSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string symnam = null, int level = -1, int view = -1) where T : IJobInterface
        {
            return proxyRef.Instance.GetSymbolIds(ref ids, symnam, level, view);
        }

        public static int GetSymbolTypeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetSymbolTypeIds(ref ids);
        }

        public static string GetTableSymbolExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetTableSymbol();
        }

        public static int GetTerminalCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetTerminalCount();
        }

        public static int GetTerminalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTerminalIds(ref ids);
        }

        public static int GetTerminalPlanSettingsExt<T>(this ProxyBase<T> proxyRef,ref object settings) where T : IJobInterface
        {
            return proxyRef.Instance.GetTerminalPlanSettings(ref settings);
        }

        public static int GetTerminalPlanSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTerminalPlanSheetIds(ref ids);
        }

        public static int GetTestpointIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTestpointIds(ref ids);
        }

        public static int GetTextCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetTextCount();
        }

        public static int GetTextIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, int txttyp = 0, string search_string = "") where T : IJobInterface
        {
            return proxyRef.Instance.GetTextIds(ref ids, txttyp, search_string);
        }

        public static double GetTrapSizeExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetTrapSize();
        }

        public static int GetTreeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeIds(ref ids);
        }

        public static int GetTreeSelectedAllDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedAllDeviceIds(ref ids);
        }

        public static int GetTreeSelectedAllDeviceIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedAllDeviceIdsByFolder(ref ids);
        }

        public static int GetTreeSelectedBlockIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedBlockIds(ref ids);
        }

        public static int GetTreeSelectedBundleIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedBundleIds(ref ids);
        }

        public static int GetTreeSelectedCableIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedCableIds(ref ids);
        }

        public static int GetTreeSelectedConnectorIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedConnectorIds(ref ids);
        }

        public static int GetTreeSelectedDeviceIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedDeviceIds(ref ids);
        }

        public static int GetTreeSelectedExternalDocumentIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedExternalDocumentIds(ref ids);
        }

        public static int GetTreeSelectedExternalDocumentIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedExternalDocumentIdsByFolder(ref ids);
        }

        public static int GetTreeSelectedPinIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedPinIds(ref ids);
        }

        public static int GetTreeSelectedSheetIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedSheetIds(ref ids);
        }

        public static int GetTreeSelectedSheetIdsByFolderExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedSheetIdsByFolder(ref ids);
        }

        public static int GetTreeSelectedStructureNodeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedStructureNodeIds(ref ids);
        }

        public static int GetTreeSelectedSymbolIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedSymbolIds(ref ids);
        }

        public static int GetTreeSelectedTerminalIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTreeSelectedTerminalIds(ref ids);
        }

        public static int GetTubeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetTubeIds(ref ids);
        }

        public static string GetTypeNameExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetTypeName();
        }

        public static int GetUnconnectCoresOnDelClineExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetUnconnectCoresOnDelCline();
        }

        public static int GetUnplacedGroupIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetUnplacedGroupIds(ref ids);
        }

        public static int GetUseBlockDesignationExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetUseBlockDesignation();
        }

        public static int GetUsePinAttributesOnAssignExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetUsePinAttributesOnAssign();
        }

        public static int GetUsePinAttributesOnImportExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetUsePinAttributesOnImport();
        }

        public static int GetVariantCountExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetVariantCount();
        }

        public static int GetVariantIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.GetVariantIds(ref ids);
        }

        public static string GetViewSymbolForTerminalStripsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.GetViewSymbolForTerminalStrips();
        }

        public static int GetWireRangeExt<T>(this ProxyBase<T> proxyRef,ref object from, ref object to) where T : IJobInterface
        {
            return proxyRef.Instance.GetWireRange(ref from, ref to);
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int HighlightAttributeExt<T>(this ProxyBase<T> proxyRef,string attnam, string attvalue, int colour, double width) where T : IJobInterface
        {
            return proxyRef.Instance.HighlightAttribute(attnam, attvalue, colour, width);
        }

        public static int ImportBoardLayoutExt<T>(this ProxyBase<T> proxyRef,string type, string file = null, int flags = 0, string map = null) where T : IJobInterface
        {
            return proxyRef.Instance.ImportBoardLayout(type, file, flags, map);
        }

        public static int ImportBoardLayoutExt<T>(this ProxyBase<T> proxyRef,string type, string file, int flags, string map, ref object exclusions) where T : IJobInterface
        {
            return proxyRef.Instance.ImportBoardLayout(type, file, flags, map, ref exclusions);
        }

        public static int ImportDDSCExt<T>(this ProxyBase<T> proxyRef,string file, int options, int level = 0) where T : IJobInterface
        {
            return proxyRef.Instance.ImportDDSC(file, options, level);
        }

        public static int ImportDrawingExt<T>(this ProxyBase<T> proxyRef,string name, int unique, double posx = -950309, double posy = -950309) where T : IJobInterface
        {
            return proxyRef.Instance.ImportDrawing(name, unique, posx, posy);
        }

        public static int ImportDrawingExExt<T>(this ProxyBase<T> proxyRef,string name, int unique, int flags, double posx = -950309, double posy = -950309) where T : IJobInterface
        {
            return proxyRef.Instance.ImportDrawingEx(name, unique, flags, posx, posy);
        }

        public static int ImportELCADExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IJobInterface
        {
            return proxyRef.Instance.ImportELCAD(ref parameters);
        }

        public static int ImportForeignProjectExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IJobInterface
        {
            return proxyRef.Instance.ImportForeignProject(ref parameters);
        }

        public static int ImportMultiuserExt<T>(this ProxyBase<T> proxyRef,string file, string name) where T : IJobInterface
        {
            return proxyRef.Instance.ImportMultiuser(file, name);
        }

        public static int ImportPanlibExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IJobInterface
        {
            return proxyRef.Instance.ImportPanlib(ref parameters);
        }

        public static int ImportRuplanExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IJobInterface
        {
            return proxyRef.Instance.ImportRuplan(ref parameters);
        }

        public static int ImportWESPEExt<T>(this ProxyBase<T> proxyRef,ref object parameters) where T : IJobInterface
        {
            return proxyRef.Instance.ImportWESPE(ref parameters);
        }

        public static int IsChangedExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.IsChanged();
        }

        public static int IsFileReadonlyExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.IsFileReadonly();
        }

        public static int IsMultiuserProjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.IsMultiuserProject();
        }

        public static int IsOfflineIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IJobInterface
        {
            return proxyRef.Instance.IsOfflineId(id);
        }

        public static int JumpToIDExt<T>(this ProxyBase<T> proxyRef,int jumpid) where T : IJobInterface
        {
            return proxyRef.Instance.JumpToID(jumpid);
        }

        public static int LoadLevelConfigurationExt<T>(this ProxyBase<T> proxyRef,string file) where T : IJobInterface
        {
            return proxyRef.Instance.LoadLevelConfiguration(file);
        }

        public static int LoadOptionStructureExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.LoadOptionStructure(filename);
        }

        public static int LoadOptionStructureExExt<T>(this ProxyBase<T> proxyRef,string filename, int flags) where T : IJobInterface
        {
            return proxyRef.Instance.LoadOptionStructureEx(filename, flags);
        }

        public static int LoadPartExt<T>(this ProxyBase<T> proxyRef,string name, string version, int unique) where T : IJobInterface
        {
            return proxyRef.Instance.LoadPart(name, version, unique);
        }

        public static int LoadSignalStructureExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.LoadSignalStructure(filename);
        }

        public static int LoadStructureTemplateExt<T>(this ProxyBase<T> proxyRef,string structure_file) where T : IJobInterface
        {
            return proxyRef.Instance.LoadStructureTemplate(structure_file);
        }

        public static int LockVariantStructureExt<T>(this ProxyBase<T> proxyRef,string password) where T : IJobInterface
        {
            return proxyRef.Instance.LockVariantStructure(password);
        }

        public static int NewExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.New(name);
        }

        public static int NewMultiuserExt<T>(this ProxyBase<T> proxyRef,string name, string description, string filename, int checkin, int unlock = 0) where T : IJobInterface
        {
            return proxyRef.Instance.NewMultiuser(name, description, filename, checkin, unlock);
        }

        public static int OpenExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.Open(name);
        }

        public static int OpenMultiuserExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.OpenMultiuser(name);
        }

        public static int PlacePartInteractivelyExt<T>(this ProxyBase<T> proxyRef,string name, string version, out object x, out object y, out object rot) where T : IJobInterface
        {
            return proxyRef.Instance.PlacePartInteractively(name, version, out x, out y, out rot);
        }

        public static int PlacePartInteractivelyExExt<T>(this ProxyBase<T> proxyRef,string name, string version, int flags, out object x, out object y, out object rot) where T : IJobInterface
        {
            return proxyRef.Instance.PlacePartInteractivelyEx(name, version, flags, out x, out y, out rot);
        }

        public static int PrintOutExt<T>(this ProxyBase<T> proxyRef,double scale, ref object shtids) where T : IJobInterface
        {
            return proxyRef.Instance.PrintOut(scale, ref shtids);
        }

        public static int PurgeUnplacedPinViewsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.PurgeUnplacedPinViews();
        }

        public static int PurgeUnusedExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.PurgeUnused();
        }

        public static int QuitFrameTransactionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.QuitFrameTransaction();
        }

        public static int RecalcWireLengthExt<T>(this ProxyBase<T> proxyRef,string bundlesequence_attribute, string length_attribute) where T : IJobInterface
        {
            return proxyRef.Instance.RecalcWireLength(bundlesequence_attribute, length_attribute);
        }

        public static int ReloadSettingsExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.ReloadSettings(filename);
        }

        public static int RemoveUndoInformationExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.RemoveUndoInformation();
        }

        public static int RenameMultiuserExt<T>(this ProxyBase<T> proxyRef,string oldname, string newname, string newdesc = null) where T : IJobInterface
        {
            return proxyRef.Instance.RenameMultiuser(oldname, newname, newdesc);
        }

        public static int RepairCheckExtendedExt<T>(this ProxyBase<T> proxyRef,int mode) where T : IJobInterface
        {
            return proxyRef.Instance.RepairCheckExtended(mode);
        }

        public static int ResetAttributeHighWaterMarkExt<T>(this ProxyBase<T> proxyRef,string attname) where T : IJobInterface
        {
            return proxyRef.Instance.ResetAttributeHighWaterMark(attname);
        }

        public static int ResetHighlightExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.ResetHighlight();
        }

        public static int ResetHighlightAttributeExt<T>(this ProxyBase<T> proxyRef,string attnam, string attvalue) where T : IJobInterface
        {
            return proxyRef.Instance.ResetHighlightAttribute(attnam, attvalue);
        }

        public static int RestoreOptionVisibilityExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.RestoreOptionVisibility(filename);
        }

        public static int RestoreVariantVisibilityExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.RestoreVariantVisibility(filename);
        }

        public static int RunUnitTestsExt<T>(this ProxyBase<T> proxyRef,ref object tests, out object fixtures, out object testcases, out object succeeded, out object failed,
            out object inconclusive) where T : IJobInterface
        {
            return proxyRef.Instance.RunUnitTests(ref tests, out fixtures, out testcases, out succeeded, out failed, out inconclusive);
        }

        public static int SaveExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.Save();
        }

        public static int SaveAsExt<T>(this ProxyBase<T> proxyRef,string name, int compressed = -1) where T : IJobInterface
        {
            return proxyRef.Instance.SaveAs(name, compressed);
        }

        public static int SaveLevelConfigurationExt<T>(this ProxyBase<T> proxyRef,string file) where T : IJobInterface
        {
            return proxyRef.Instance.SaveLevelConfiguration(file);
        }

        public static int SaveMultiuserExt<T>(this ProxyBase<T> proxyRef,uint mode) where T : IJobInterface
        {
            return proxyRef.Instance.SaveMultiuser(mode);
        }

        public static int SaveOptionStructureExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.SaveOptionStructure(filename);
        }

        public static int SaveSheetsAsSingleUserExt<T>(this ProxyBase<T> proxyRef,string name, ref object shtids, int compressed = -1, string completeName = "",
            int completeCompressed = -1) where T : IJobInterface
        {
            return proxyRef.Instance.SaveSheetsAsSingleUser(name, ref shtids, compressed, completeName, completeCompressed);
        }

        public static int SetActiveOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IJobInterface
        {
            return proxyRef.Instance.SetActiveOptionIds(ref ids);
        }

        public static int SetActiveSheetTreeIDExt<T>(this ProxyBase<T> proxyRef,int treeid) where T : IJobInterface
        {
            return proxyRef.Instance.SetActiveSheetTreeID(treeid);
        }

        public static int SetActiveVariantIdExt<T>(this ProxyBase<T> proxyRef,int vari) where T : IJobInterface
        {
            return proxyRef.Instance.SetActiveVariantId(vari);
        }

        public static int SetAddDeviceDesignationOfConnectionTargetExt<T>(this ProxyBase<T> proxyRef,int bMerge) where T : IJobInterface
        {
            return proxyRef.Instance.SetAddDeviceDesignationOfConnectionTarget(bMerge);
        }

        public static double SetAltGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetAltGridSize(newsize);
        }

        public static string SetAssignmentSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            return proxyRef.Instance.SetAssignmentSeparator(newsep);
        }

        public static void SetAssignmentSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            proxyRef.Instance.SetAssignmentSuffixSeparator(newsep);
        }

        public static int SetAttributeNotInheritableExt<T>(this ProxyBase<T> proxyRef,string attnam, int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetAttributeNotInheritable(attnam, newval);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IJobInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetBlockCopyGraphicInSplitExt<T>(this ProxyBase<T> proxyRef,int copy) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockCopyGraphicInSplit(copy);
        }

        public static int SetBlockReferenceTextDirectionExt<T>(this ProxyBase<T> proxyRef,int newdir) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockReferenceTextDirection(newdir);
        }

        public static double SetBlockReferenceTextGapExt<T>(this ProxyBase<T> proxyRef,double newgap) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockReferenceTextGap(newgap);
        }

        public static int SetBlockReferenceTextLevelExt<T>(this ProxyBase<T> proxyRef,int newlev) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockReferenceTextLevel(newlev);
        }

        public static int SetBlockReferenceTextRotateExt<T>(this ProxyBase<T> proxyRef,int rotate) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockReferenceTextRotate(rotate);
        }

        public static int SetBlockReferenceTypeExt<T>(this ProxyBase<T> proxyRef,int newtype) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockReferenceType(newtype);
        }

        public static int SetBlockTextAlignmentExt<T>(this ProxyBase<T> proxyRef,int newalign) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextAlignment(newalign);
        }

        public static int SetBlockTextColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextColour(newcol);
        }

        public static string SetBlockTextFontExt<T>(this ProxyBase<T> proxyRef,string newfont) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextFont(newfont);
        }

        public static int SetBlockTextRatioExt<T>(this ProxyBase<T> proxyRef,int newratio) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextRatio(newratio);
        }

        public static double SetBlockTextSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextSize(newsize);
        }

        public static int SetBlockTextStyleExt<T>(this ProxyBase<T> proxyRef,int newstyle) where T : IJobInterface
        {
            return proxyRef.Instance.SetBlockTextStyle(newstyle);
        }

        public static int SetBusLineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetBusLineColour(newcol);
        }

        public static int SetBusLineLevelExt<T>(this ProxyBase<T> proxyRef,int newlev) where T : IJobInterface
        {
            return proxyRef.Instance.SetBusLineLevel(newlev);
        }

        public static int SetBusLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstl) where T : IJobInterface
        {
            return proxyRef.Instance.SetBusLineStyle(newstl);
        }

        public static int SetBusLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : IJobInterface
        {
            return proxyRef.Instance.SetBusLineWidth(newwid);
        }

        public static int SetCadstarCrossProbingExt<T>(this ProxyBase<T> proxyRef,int probe) where T : IJobInterface
        {
            return proxyRef.Instance.SetCadstarCrossProbing(probe);
        }

        public static int SetChangedExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetChanged(newval);
        }

        public static double SetConnectionInclinationAngleExt<T>(this ProxyBase<T> proxyRef,double angle) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectionInclinationAngle(angle);
        }

        public static double SetConnectionInclinationDistanceExt<T>(this ProxyBase<T> proxyRef,double destination) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectionInclinationDistance(destination);
        }

        public static int SetConnectionModeExt<T>(this ProxyBase<T> proxyRef,int mode) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectionMode(mode);
        }

        public static int SetConnectionTargetFormatExt<T>(this ProxyBase<T> proxyRef,int txttyp, int flags, string entire_prefix, string entire_suffix, int count,
            ref object prefix, ref object name, ref object funct) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectionTargetFormat(txttyp, flags, entire_prefix, entire_suffix, count, ref prefix, ref name, ref funct);
        }

        public static int SetConnectorPinTerminalParameterOverwriteModelPinExt<T>(this ProxyBase<T> proxyRef,int bValue) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectorPinTerminalParameterOverwriteModelPin(bValue);
        }

        public static int SetConnectorSymbolFormatExt<T>(this ProxyBase<T> proxyRef,ref object texttypes, ref object dispflags) where T : IJobInterface
        {
            return proxyRef.Instance.SetConnectorSymbolFormat(ref texttypes, ref dispflags);
        }

        public static int SetCreateUniqueSheetNamesExt<T>(this ProxyBase<T> proxyRef,int uniquenames) where T : IJobInterface
        {
            return proxyRef.Instance.SetCreateUniqueSheetNames(uniquenames);
        }

        public static int SetDefaultHoseTubeExt<T>(this ProxyBase<T> proxyRef,string HoseTube) where T : IJobInterface
        {
            return proxyRef.Instance.SetDefaultHoseTube(HoseTube);
        }

        public static int SetDefaultJumperExt<T>(this ProxyBase<T> proxyRef,string jumpergroup, string jumpername) where T : IJobInterface
        {
            return proxyRef.Instance.SetDefaultJumper(jumpergroup, jumpername);
        }

        public static int SetDefaultWireExt<T>(this ProxyBase<T> proxyRef,string wiregroup, string wirename) where T : IJobInterface
        {
            return proxyRef.Instance.SetDefaultWire(wiregroup, wirename);
        }

        public static int SetDeleteCoresOnDelClineExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDeleteCoresOnDelCline(newval);
        }

        public static int SetDeletePinAttributesOnUnplaceExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDeletePinAttributesOnUnplace(newval);
        }

        public static int SetDeleteSignalOnDelClineExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDeleteSignalOnDelCline(newval);
        }

        public static int SetDetermineConnectorSymbolExt<T>(this ProxyBase<T> proxyRef,int determine) where T : IJobInterface
        {
            return proxyRef.Instance.SetDetermineConnectorSymbol(determine);
        }

        public static int SetDetermineConnectorViewSymbolExt<T>(this ProxyBase<T> proxyRef,int determine) where T : IJobInterface
        {
            return proxyRef.Instance.SetDetermineConnectorViewSymbol(determine);
        }

        public static string SetDeviceNameSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            return proxyRef.Instance.SetDeviceNameSeparator(newsep);
        }

        public static void SetDeviceNameSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            proxyRef.Instance.SetDeviceNameSuffixSeparator(newsep);
        }

        public static string SetDisplayAltCompCodeExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayAltCompCode(newval);
        }

        public static int SetDisplayAppendFormboardNameToDeviceNameExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayAppendFormboardNameToDeviceName(newval);
        }

        public static int SetDisplayConnectionModeExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayConnectionMode(value);
        }

        public static int SetDisplayConnectionTypeExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayConnectionType(newval);
        }

        public static int SetDisplayConnectPointsExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayConnectPoints(newval);
        }

        public static int SetDisplayDuctDockingPointsExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayDuctDockingPoints(newval);
        }

        public static int SetDisplayDuctFillSizeExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayDuctFillSize(newval);
        }

        public static int SetDisplayFormboardEffectiveDirectionExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayFormboardEffectiveDirection(newval);
        }

        public static int SetDisplayFormboardMarkDifferenLengthExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayFormboardMarkDifferenLength(newval);
        }

        public static int SetDisplayFormboardNodesExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayFormboardNodes(newval);
        }

        public static int SetDisplayFormboardTableSubsidiaryLinesExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayFormboardTableSubsidiaryLines(newval);
        }

        public static int SetDisplayFormboardUnconnectedCoresExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayFormboardUnconnectedCores(newval);
        }

        public static int SetDisplayIntExtRepresentationExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayIntExtRepresentation(newval);
        }

        public static int SetDisplayMILStandardExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayMILStandard(newval);
        }

        public static int SetDisplayOptionsAllExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayOptionsAll(newval);
        }

        public static int SetDisplayOptionsColouredExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayOptionsColoured(newval);
        }

        public static int SetDisplayOptionsNoneExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayOptionsNone(newval);
        }

        public static int SetDisplayRotatedTextAccStandardExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayRotatedTextAccStandard(newval);
        }

        public static int SetDisplayUnconnectedNodesExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayUnconnectedNodes(newval);
        }

        public static int SetDisplayViewNumbersExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetDisplayViewNumbers(newval);
        }

        public static int SetDynamicSymbolOriginInUpperLeftExt<T>(this ProxyBase<T> proxyRef,int bTopLeft) where T : IJobInterface
        {
            return proxyRef.Instance.SetDynamicSymbolOriginInUpperLeft(bTopLeft);
        }

        public static int SetExclusiveModeExt<T>(this ProxyBase<T> proxyRef,int mode) where T : IJobInterface
        {
            return proxyRef.Instance.SetExclusiveMode(mode);
        }

        public static int SetExportWithCablesAndWiresExt<T>(this ProxyBase<T> proxyRef,int cablesandwires) where T : IJobInterface
        {
            return proxyRef.Instance.SetExportWithCablesAndWires(cablesandwires);
        }

        public static int SetExportWithCablesAndWiresOptionExt<T>(this ProxyBase<T> proxyRef,int option) where T : IJobInterface
        {
            return proxyRef.Instance.SetExportWithCablesAndWiresOption(option);
        }

        public static int SetFieldHatchColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldHatchColour(newcol);
        }

        public static double SetFieldHatchLineDistanceExt<T>(this ProxyBase<T> proxyRef,double newdist) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldHatchLineDistance(newdist);
        }

        public static double SetFieldHatchLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldHatchLineWidth(newwid);
        }

        public static int SetFieldHatchPatternExt<T>(this ProxyBase<T> proxyRef,int newpat) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldHatchPattern(newpat);
        }

        public static int SetFieldOriginInUpperLeftExt<T>(this ProxyBase<T> proxyRef,int bTopLeft) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldOriginInUpperLeft(bTopLeft);
        }

        public static int SetFieldOutlineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldOutlineColour(newcol);
        }

        public static int SetFieldOutlineStyleExt<T>(this ProxyBase<T> proxyRef,int newstyle) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldOutlineStyle(newstyle);
        }

        public static double SetFieldOutlineWidthExt<T>(this ProxyBase<T> proxyRef,double width) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldOutlineWidth(width);
        }

        public static string SetFieldTextTemplateExt<T>(this ProxyBase<T> proxyRef,string newname) where T : IJobInterface
        {
            return proxyRef.Instance.SetFieldTextTemplate(newname);
        }

        public static int SetFormboardAutoplaceTableSymbolExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetFormboardAutoplaceTableSymbol(newval);
        }

        public static int SetFormboardAutorotateConnectorSymbolsExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetFormboardAutorotateConnectorSymbols(newval);
        }

        public static int SetFormboardBranchAngleStepExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetFormboardBranchAngleStep(newval);
        }

        public static double SetGapToPlaceSinglePinsExt<T>(this ProxyBase<T> proxyRef,double new_gap) where T : IJobInterface
        {
            return proxyRef.Instance.SetGapToPlaceSinglePins(new_gap);
        }

        public static int SetGeneratedWireNameFormatExt<T>(this ProxyBase<T> proxyRef,string prefix, string separator, string postfix, ref object attPrefix,
            ref object attType, ref object attname) where T : IJobInterface
        {
            return proxyRef.Instance.SetGeneratedWireNameFormat(prefix, separator, postfix, ref attPrefix, ref attType, ref attname);
        }

        public static int SetGetterOptionHandlingModeExt<T>(this ProxyBase<T> proxyRef,int mode) where T : IJobInterface
        {
            return proxyRef.Instance.SetGetterOptionHandlingMode(mode);
        }

        public static int SetGraphArrowsExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphArrows(value);
        }

        public static int SetGraphColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphColour(value);
        }

        public static int SetGraphHatchColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphHatchColour(value);
        }

        public static double SetGraphHatchDistanceExt<T>(this ProxyBase<T> proxyRef,double value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphHatchDistance(value);
        }

        public static int SetGraphHatchPatternExt<T>(this ProxyBase<T> proxyRef,int value, double angle1, double angle2) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphHatchPattern(value, angle1, angle2);
        }

        public static int SetGraphHatchStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphHatchStyle(value);
        }

        public static double SetGraphHatchWidthExt<T>(this ProxyBase<T> proxyRef,double value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphHatchWidth(value);
        }

        public static int SetGraphLevelExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphLevel(value);
        }

        public static int SetGraphStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphStyle(value);
        }

        public static int SetGraphTextColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextColour(value);
        }

        public static string SetGraphTextFontNameExt<T>(this ProxyBase<T> proxyRef,string newname) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextFontName(newname);
        }

        public static double SetGraphTextHeightExt<T>(this ProxyBase<T> proxyRef,double value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextHeight(value);
        }

        public static int SetGraphTextLevelExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextLevel(value);
        }

        public static int SetGraphTextModeExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextMode(value);
        }

        public static double SetGraphTextSizeExt<T>(this ProxyBase<T> proxyRef,double value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextSize(value);
        }

        public static int SetGraphTextStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphTextStyle(value);
        }

        public static double SetGraphWidthExt<T>(this ProxyBase<T> proxyRef,double value) where T : IJobInterface
        {
            return proxyRef.Instance.SetGraphWidth(value);
        }

        public static double SetGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetGridSize(newsize);
        }

        public static int SetHighlightColourExt<T>(this ProxyBase<T> proxyRef,int colour) where T : IJobInterface
        {
            return proxyRef.Instance.SetHighlightColour(colour);
        }

        public static int SetHighlightKeepExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetHighlightKeep(keep);
        }

        public static double SetHighlightLineWidthExt<T>(this ProxyBase<T> proxyRef,double width) where T : IJobInterface
        {
            return proxyRef.Instance.SetHighlightLineWidth(width);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IJobInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetIEC61346SettingExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetIEC61346Setting(newval);
        }

        public static string SetImportItemDesignationSuffixExt<T>(this ProxyBase<T> proxyRef,string newsuffix) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportItemDesignationSuffix(newsuffix);
        }

        public static int SetImportMergeAttributesExt<T>(this ProxyBase<T> proxyRef,int merge) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeAttributes(merge);
        }

        public static int SetImportMergeConnectLinesExt<T>(this ProxyBase<T> proxyRef,int merge) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeConnectLines(merge);
        }

        public static int SetImportMergeExistingAssembliesExt<T>(this ProxyBase<T> proxyRef,int merge) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeExistingAssemblies(merge);
        }

        public static int SetImportMergeExistingDevicesExt<T>(this ProxyBase<T> proxyRef,int merge) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeExistingDevices(merge);
        }

        public static int SetImportMergeExistingTerminalStripsExt<T>(this ProxyBase<T> proxyRef,int merge) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeExistingTerminalStrips(merge);
        }

        public static int SetImportMergeOptionsExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportMergeOptions(newval);
        }

        public static int SetImportUseItemDesignationSuffixExt<T>(this ProxyBase<T> proxyRef,int use) where T : IJobInterface
        {
            return proxyRef.Instance.SetImportUseItemDesignationSuffix(use);
        }

        public static int SetKeepActiveConnectorPinTerminalOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepActiveConnectorPinTerminalOnUpdate(keep);
        }

        public static int SetKeepActiveCounterpartOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepActiveCounterpartOnUpdate(keep);
        }

        public static int SetKeepActiveFittingOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepActiveFittingOnUpdate(keep);
        }

        public static int SetKeepConnectorSymbolsOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepConnectorSymbolsOnUpdate(keep);
        }

        public static int SetKeepModelTextParametersOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepModelTextParametersOnUpdate(keep);
        }

        public static int SetKeepModelTextVisibilityOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepModelTextVisibilityOnUpdate(keep);
        }

        public static int SetKeepSymbolTextParametersOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepSymbolTextParametersOnUpdate(keep);
        }

        public static int SetKeepSymbolTextVisibilityOnUpdateExt<T>(this ProxyBase<T> proxyRef,int keep) where T : IJobInterface
        {
            return proxyRef.Instance.SetKeepSymbolTextVisibilityOnUpdate(keep);
        }

        public static int SetLanguagesExt<T>(this ProxyBase<T> proxyRef,ref object languages) where T : IJobInterface
        {
            return proxyRef.Instance.SetLanguages(ref languages);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int lev, int onoff) where T : IJobInterface
        {
            return proxyRef.Instance.SetLevel(lev, onoff);
        }

        public static int SetLevelsExt<T>(this ProxyBase<T> proxyRef,ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr) where T : IJobInterface
        {
            return proxyRef.Instance.SetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr);
        }

        public static int SetLevelsExt<T>(this ProxyBase<T> proxyRef,ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr, ref object names) where T : IJobInterface
        {
            return proxyRef.Instance.SetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr, ref names);
        }

        public static int SetLineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetLineColour(newcol);
        }

        public static int SetLineLevelExt<T>(this ProxyBase<T> proxyRef,int newlev) where T : IJobInterface
        {
            return proxyRef.Instance.SetLineLevel(newlev);
        }

        public static int SetLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstl) where T : IJobInterface
        {
            return proxyRef.Instance.SetLineStyle(newstl);
        }

        public static int SetLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : IJobInterface
        {
            return proxyRef.Instance.SetLineWidth(newwid);
        }

        public static string SetLocationSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            return proxyRef.Instance.SetLocationSeparator(newsep);
        }

        public static void SetLocationSuffixSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            proxyRef.Instance.SetLocationSuffixSeparator(newsep);
        }

        public static int SetMeasureExt<T>(this ProxyBase<T> proxyRef,string measure) where T : IJobInterface
        {
            return proxyRef.Instance.SetMeasure(measure);
        }

        public static int SetMergeAlphanumericReferencesExt<T>(this ProxyBase<T> proxyRef,int bMerge) where T : IJobInterface
        {
            return proxyRef.Instance.SetMergeAlphanumericReferences(bMerge);
        }

        public static int SetMergeSheetReferencesExt<T>(this ProxyBase<T> proxyRef,int bMerge) where T : IJobInterface
        {
            return proxyRef.Instance.SetMergeSheetReferences(bMerge);
        }

        public static int SetMergeUsingExactCoreConnectionOnImportExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetMergeUsingExactCoreConnectionOnImport(newval);
        }

        public static int SetMILGraphicLineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IJobInterface
        {
            return proxyRef.Instance.SetMILGraphicLineColour(newcol);
        }

        public static int SetMILGraphicLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstyle) where T : IJobInterface
        {
            return proxyRef.Instance.SetMILGraphicLineStyle(newstyle);
        }

        public static double SetMILGraphicLineWidthExt<T>(this ProxyBase<T> proxyRef,double width) where T : IJobInterface
        {
            return proxyRef.Instance.SetMILGraphicLineWidth(width);
        }

        public static int SetNetSegmentAttributeSplittingRuleExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetNetSegmentAttributeSplittingRule(newval);
        }

        public static int SetNetSegmentLengthSplittingRuleExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetNetSegmentLengthSplittingRule(newval);
        }

        public static double SetPanelAltGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetPanelAltGridSize(newsize);
        }

        public static double SetPanelGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetPanelGridSize(newsize);
        }

        public static double SetPanelTrapSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetPanelTrapSize(newsize);
        }

        public static int SetPinViewSymbolForBlockConnectorPinsExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetPinViewSymbolForBlockConnectorPins(new_sym);
        }

        public static int SetPinViewSymbolForConnectorPinsExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetPinViewSymbolForConnectorPins(new_sym);
        }

        public static int SetPinViewSymbolForDevicePinsExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetPinViewSymbolForDevicePins(new_sym);
        }

        public static double SetPointGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetPointGridSize(newsize);
        }

        public static string SetPortNameSeparatorExt<T>(this ProxyBase<T> proxyRef,string newsep) where T : IJobInterface
        {
            return proxyRef.Instance.SetPortNameSeparator(newsep);
        }

        public static int SetPurgeUnplacedPinViewsBeforeSaveExt<T>(this ProxyBase<T> proxyRef,int purge) where T : IJobInterface
        {
            return proxyRef.Instance.SetPurgeUnplacedPinViewsBeforeSave(purge);
        }

        public static int SetPurgeUnusedBeforeSaveExt<T>(this ProxyBase<T> proxyRef,int purge) where T : IJobInterface
        {
            return proxyRef.Instance.SetPurgeUnusedBeforeSave(purge);
        }

        public static int SetReloadAttributesOnUpdateExt<T>(this ProxyBase<T> proxyRef,int reload) where T : IJobInterface
        {
            return proxyRef.Instance.SetReloadAttributesOnUpdate(reload);
        }

        public static int SetRestoreChangedPinNamesOnUpdateExt<T>(this ProxyBase<T> proxyRef,int restore) where T : IJobInterface
        {
            return proxyRef.Instance.SetRestoreChangedPinNamesOnUpdate(restore);
        }

        public static int SetRGBValueExt<T>(this ProxyBase<T> proxyRef,ref object index, ref object r, ref object g, ref object b) where T : IJobInterface
        {
            return proxyRef.Instance.SetRGBValue(ref index, ref r, ref g, ref b);
        }

        public static double SetRulerGridSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetRulerGridSize(newsize);
        }

        public static object SetSettingValueExt<T>(this ProxyBase<T> proxyRef,string name, ref object value) where T : IJobInterface
        {
            return proxyRef.Instance.SetSettingValue(name, ref value);
        }

        public static int SetSheetTreeStructureExt<T>(this ProxyBase<T> proxyRef,ref object structarr, ref object info) where T : IJobInterface
        {
            return proxyRef.Instance.SetSheetTreeStructure(ref structarr, ref info);
        }

        public static int SetSymbolForBlockConnectorsWithoutCompcodeExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetSymbolForBlockConnectorsWithoutCompcode(new_sym);
        }

        public static int SetSymbolForConnectorsWithoutCompcodeExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetSymbolForConnectorsWithoutCompcode(new_sym);
        }

        public static string SetTableSymbolExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetTableSymbol(newval);
        }

        public static int SetTerminalPlanSettingsExt<T>(this ProxyBase<T> proxyRef,ref object settings) where T : IJobInterface
        {
            return proxyRef.Instance.SetTerminalPlanSettings(ref settings);
        }

        public static double SetTrapSizeExt<T>(this ProxyBase<T> proxyRef,double newsize) where T : IJobInterface
        {
            return proxyRef.Instance.SetTrapSize(newsize);
        }

        public static int SetUnconnectCoresOnDelClineExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUnconnectCoresOnDelCline(newval);
        }

        public static int SetUnlockPasswordExt<T>(this ProxyBase<T> proxyRef,string oldval, string newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUnlockPassword(oldval, newval);
        }

        public static int SetUnlockVariantStructurePasswordExt<T>(this ProxyBase<T> proxyRef,string oldval, string newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUnlockVariantStructurePassword(oldval, newval);
        }

        public static int SetUseBlockDesignationExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUseBlockDesignation(newval);
        }

        public static int SetUsePinAttributesOnAssignExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUsePinAttributesOnAssign(newval);
        }

        public static int SetUsePinAttributesOnImportExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IJobInterface
        {
            return proxyRef.Instance.SetUsePinAttributesOnImport(newval);
        }

        public static int SetViewSymbolForTerminalStripsExt<T>(this ProxyBase<T> proxyRef,string new_sym) where T : IJobInterface
        {
            return proxyRef.Instance.SetViewSymbolForTerminalStrips(new_sym);
        }

        public static int SetWireRangeExt<T>(this ProxyBase<T> proxyRef,int @from, int to) where T : IJobInterface
        {
            return proxyRef.Instance.SetWireRange(@from, to);
        }

        public static int ShowPartPreviewExt<T>(this ProxyBase<T> proxyRef,string name) where T : IJobInterface
        {
            return proxyRef.Instance.ShowPartPreview(name);
        }

        public static int StartFrameTransactionExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.StartFrameTransaction();
        }

        public static int StoreOptionVisibilityExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.StoreOptionVisibility(filename);
        }

        public static int StoreVariantVisibilityExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.StoreVariantVisibility(filename);
        }

        public static int UnlockVariantStructureExt<T>(this ProxyBase<T> proxyRef,string password) where T : IJobInterface
        {
            return proxyRef.Instance.UnlockVariantStructure(password);
        }

        public static int UpdateAllComponentsExt<T>(this ProxyBase<T> proxyRef,int withSymbol = 1) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAllComponents(withSymbol);
        }

        public static int UpdateAllPartsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAllParts();
        }

        public static int UpdateAllSubCircuitsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAllSubCircuits();
        }

        public static int UpdateAllSymbolsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAllSymbols();
        }

        public static int UpdateAllTerminalPlansExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAllTerminalPlans();
        }

        public static int UpdateAutoShtrefsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateAutoShtrefs();
        }

        public static int UpdateCompleteProjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateCompleteProject();
        }

        public static int UpdateComponentExt<T>(this ProxyBase<T> proxyRef,string cmpnam, int withSymbol = 1) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateComponent(cmpnam, withSymbol);
        }

        public static int UpdateConfigurationExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateConfiguration();
        }

        public static int UpdateConnectionTargetsExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateConnectionTargets();
        }

        public static int UpdateCoresExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateCores();
        }

        public static int UpdateLanguageDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateLanguageDatabase();
        }

        public static int UpdateMultiuserExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateMultiuser();
        }

        public static int UpdatePartExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IJobInterface
        {
            return proxyRef.Instance.UpdatePart(filename);
        }

        public static int UpdateSubCircuitExt<T>(this ProxyBase<T> proxyRef,string cmpnam) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateSubCircuit(cmpnam);
        }

        public static int UpdateSymbolExt<T>(this ProxyBase<T> proxyRef,string symnam) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateSymbol(symnam);
        }

        public static int UpdateTextsInProjectExt<T>(this ProxyBase<T> proxyRef) where T : IJobInterface
        {
            return proxyRef.Instance.UpdateTextsInProject();
        }

        public static int VerifyExt<T>(this ProxyBase<T> proxyRef,int mode, string logfile = "") where T : IJobInterface
        {
            return proxyRef.Instance.Verify(mode, logfile);
        }

    }
    
}