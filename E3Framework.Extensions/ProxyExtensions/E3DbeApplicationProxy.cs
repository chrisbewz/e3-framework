using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3DbeApplicationProxy
    {
        public static int AvoidAutomaticClosing<T>(this ProxyBase<T> proxyRef,int avoid = 1) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.AvoidAutomaticClosing(avoid);
        }

        public static int BeginForeignTaskExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.BeginForeignTask();
        }

        public static void ClearOutputWindowExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            proxyRef.Instance.ClearOutputWindow();
        }

        public static void ClearResultWindowExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            proxyRef.Instance.ClearResultWindow();
        }

        public static int DeleteComponent<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.DeleteComponent(name, version);
        }

        public static int DeleteModel<T>(this ProxyBase<T> proxyRef,string name) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.DeleteModel(name);
        }

        public static int DeleteSymbol<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.DeleteSymbol(name, version);
        }

        public static int DisplayExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Display();
        }

        public static int EditComponent<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EditComponent(name, version);
        }

        public static int EditModel<T>(this ProxyBase<T> proxyRef,string name) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EditModel(name);
        }

        public static int EditSymbol<T>(this ProxyBase<T> proxyRef,string name, string version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EditSymbol(name, version);
        }

        public static int EnableCOM<T>(this ProxyBase<T> proxyRef,string password) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EnableCOM(password);
        }

        public static int EnableLogfile<T>(this ProxyBase<T> proxyRef,int en) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EnableLogfile(en);
        }

        public static int EndForeignTaskExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.EndForeignTask();
        }

        public static int FreeLicense<T>(this ProxyBase<T> proxyRef,string feature) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.FreeLicense(feature);
        }

        public static int FreeLicensePermanent<T>(this ProxyBase<T> proxyRef,string feature) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.FreeLicensePermanent(feature);
        }

        public static string fullnameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.fullname();
        }

        public static string GetActualDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetActualDatabase();
        }

        public static int GetAvailableLanguages<T>(this ProxyBase<T> proxyRef,ref object languages) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetAvailableLanguages(ref languages);
        }

        public static string GetBuildExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetBuild();
        }

        public static string GetComponentDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetComponentDatabase();
        }

        public static string GetComponentDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetComponentDatabaseTableSchema();
        }

        public static string GetConfigurationDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetConfigurationDatabase();
        }

        public static string GetConfigurationDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetConfigurationDatabaseTableSchema();
        }

        public static int GetDatabaseTableSelectedComponents<T>(this ProxyBase<T> proxyRef,out object ComponentArray, out object VersionArray) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTableSelectedComponents(out ComponentArray, out VersionArray);
        }

        public static int GetDatabaseTreeSelectedComponents<T>(this ProxyBase<T> proxyRef,out object ComponentName, out object version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedComponents(out ComponentName, out version);
        }

        public static int GetDatabaseTreeSelectedModels<T>(this ProxyBase<T> proxyRef,out object ModelName) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedModels(out ModelName);
        }

        public static int GetDatabaseTreeSelectedSymbols<T>(this ProxyBase<T> proxyRef,out object SymbolName, out object version) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedSymbols(out SymbolName, out version);
        }

        public static int GetDefinedDatabaseConnectionStrings<T>(this ProxyBase<T> proxyRef,string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDefinedDatabaseConnectionStrings(dbname, out cmp_cs, out sym_cs, out cnf_cs);
        }

        public static int GetDefinedDatabases<T>(this ProxyBase<T> proxyRef,out object dbnames) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetDefinedDatabases(out dbnames);
        }

        public static int GetEnableInteractiveDialogsExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetEnableInteractiveDialogs();
        }

        public static int GetErrorCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetErrorCount();
        }

        public static string GetFullNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetFullName();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInfoCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetInfoCount();
        }

        public static int GetInstallationLanguageExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetInstallationLanguage();
        }

        public static string GetInstallationPathExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetInstallationPath();
        }

        public static string GetLanguageDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetLanguageDatabase();
        }

        public static string GetLanguageDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetLanguageDatabaseTableSchema();
        }

        public static int GetLicense<T>(this ProxyBase<T> proxyRef,string feature) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetLicense(feature);
        }

        public static int GetLicensePermanent<T>(this ProxyBase<T> proxyRef,string feature) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetLicensePermanent(feature);
        }

        public static string GetLogfileName<T>(this ProxyBase<T> proxyRef,int index = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetLogfileName(index);
        }

        public static object GetModalWindowExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetModalWindow();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static object GetPluginObject<T>(this ProxyBase<T> proxyRef,ref object Plugin) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPluginObject(ref Plugin);
        }

        public static int GetPrintCropMarksExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrintCropMarks();
        }

        public static int GetPrinterColourExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrinterColour();
        }

        public static double GetPrinterLinewidthExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrinterLinewidth();
        }

        public static int GetPrinterMargins<T>(this ProxyBase<T> proxyRef,ref object top, ref object bottom, ref object left, ref object right) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrinterMargins(ref top, ref bottom, ref left, ref right);
        }

        public static string GetPrinterNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrinterName();
        }

        public static int GetPrintPageNumbersExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrintPageNumbers();
        }

        public static int GetPrintSheetOrderExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrintSheetOrder();
        }

        public static int GetPrintSplitPagesExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetPrintSplitPages();
        }

        public static object GetProcessPropertyExt<T>(this ProxyBase<T> proxyRef,string what) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetProcessProperty(what);
        }

        public static int GetProjectInformationExt<T>(this ProxyBase<T> proxyRef,ref object filename, ref object type, ref object is_dbe) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetProjectInformation(ref filename, ref type, ref is_dbe);
        }

        public static string GetProviderExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetProvider(dbname);
        }

        public static string GetRegistryVersionExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetRegistryVersion();
        }

        public static object GetScriptArgumentsExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetScriptArguments();
        }

        public static int GetScriptReturnExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetScriptReturn();
        }

        public static string GetSymbolDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetSymbolDatabase();
        }

        public static string GetSymbolDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetSymbolDatabaseTableSchema();
        }

        public static string GetTemplateFileDBEExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetTemplateFileDBE();
        }

        public static int GetTestMarkExt<T>(this ProxyBase<T> proxyRef,int num) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetTestMark(num);
        }

        public static string GetTranslatedTextExt<T>(this ProxyBase<T> proxyRef,string text, string language) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetTranslatedText(text, language);
        }

        public static int GetTriggerExt<T>(this ProxyBase<T> proxyRef,string name, ref object filename) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetTrigger(name, ref filename);
        }

        public static int GetTriggerReturnExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetTriggerReturn();
        }

        public static int GetUseSheetOrientationExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetUseSheetOrientation();
        }

        public static string GetVersionExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetVersion();
        }

        public static int GetWarningCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetWarningCount();
        }

        public static string GetWorkspaceNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.GetWorkspaceName();
        }

        public static int IncludeExt<T>(this ProxyBase<T> proxyRef,string text) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Include(text);
        }

        public static int IsBasicExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsBasic();
        }

        public static int IsBoardExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsBoard();
        }

        public static int IsCableExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsCable();
        }

        public static int IsCaddyExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsCaddy();
        }

        public static int IsCaddyBasicExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsCaddyBasic();
        }

        public static int IsCaddyDemoExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsCaddyDemo();
        }

        public static int IsCaddyEconomyExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsCaddyEconomy();
        }

        public static int IsDemoExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsDemo();
        }

        public static int IsEconomyExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsEconomy();
        }

        public static int IsFluidExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsFluid();
        }

        public static int IsFormboardExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsFormboard();
        }

        public static int IsFunctionalDesignExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsFunctionalDesign();
        }

        public static int IsLogicExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsLogic();
        }

        public static int IsMultiuserExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsMultiuser();
        }

        public static int IsPanelExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsPanel();
        }

        public static int IsRedlinerExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsRedliner();
        }

        public static int IsSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsSchema();
        }

        public static int IsScriptRunningExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsScriptRunning();
        }

        public static int IsSmallBusinessExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsSmallBusiness();
        }

        public static int IsStudentExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsStudent();
        }

        public static int IsViewerExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsViewer();
        }

        public static int IsViewPlusExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsViewPlus();
        }

        public static int IsWagoExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsWago();
        }

        public static int IsWagoDemoExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsWagoDemo();
        }

        public static int IsWireExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsWire();
        }

        public static int IsWireWorksExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.IsWireWorks();
        }

        public static int MaximizeExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Maximize();
        }

        public static int MinimizeExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Minimize();
        }

        public static int NewComponentExt<T>(this ProxyBase<T> proxyRef,string name, string version, string baseName, string baseVersion, int flags = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.NewComponent(name, version, baseName, baseVersion, flags);
        }

        public static int NewModelExt<T>(this ProxyBase<T> proxyRef,string name, string baseName, int flags = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.NewModel(name, baseName, flags);
        }

        public static int NewSymbolExt<T>(this ProxyBase<T> proxyRef,string name, string version, string baseName, string baseVersion, int flags = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.NewSymbol(name, version, baseName, baseVersion, flags);
        }

        public static int PutErrorExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.PutError(ok, text, item);
        }

        public static int PutInfoExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.PutInfo(ok, text, item);
        }

        public static int PutMessageExt<T>(this ProxyBase<T> proxyRef,string text, int item = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.PutMessage(text, item);
        }

        public static int PutWarningExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.PutWarning(ok, text, item);
        }

        public static int QuitExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Quit();
        }

        public static int ResetErrorCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ResetErrorCount();
        }

        public static int ResetInfoCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ResetInfoCount();
        }

        public static int ResetWarningCountExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ResetWarningCount();
        }

        public static int RunExt<T>(this ProxyBase<T> proxyRef,string filename, ref object arguments) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Run(filename, ref arguments);
        }

        public static object ScriptArgumentsExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ScriptArguments();
        }

        public static string ScriptFullNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ScriptFullName();
        }

        public static string ScriptNameExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ScriptName();
        }

        public static int SelectComponentFromTableExt<T>(this ProxyBase<T> proxyRef,ref object ComponentName, ref object ComponentVersion) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SelectComponentFromTable(ref ComponentName, ref ComponentVersion);
        }

        public static int SetActualDatabaseExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetActualDatabase(dbname);
        }

        public static int SetDefinedDatabaseConnectionStringsExt<T>(this ProxyBase<T> proxyRef,string dbname, string cmp_cs, string sym_cs, string cnf_cs) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetDefinedDatabaseConnectionStrings(dbname, cmp_cs, sym_cs, cnf_cs);
        }

        public static int SetEnableInteractiveDialogsExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetEnableInteractiveDialogs(value);
        }

        public static int SetLanguageDatabaseExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetLanguageDatabase(dbname);
        }

        public static int SetLogfileNameExt<T>(this ProxyBase<T> proxyRef,string logfile, int index = 0) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetLogfileName(logfile, index);
        }

        public static int SetModalWindowExt<T>(this ProxyBase<T> proxyRef,ref object hWnd) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetModalWindow(ref hWnd);
        }

        public static int SetPrintCropMarksExt<T>(this ProxyBase<T> proxyRef,int set) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrintCropMarks(set);
        }

        public static int SetPrinterCollateExt<T>(this ProxyBase<T> proxyRef,int col) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterCollate(col);
        }

        public static int SetPrinterColourExt<T>(this ProxyBase<T> proxyRef,int colour) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterColour(colour);
        }

        public static int SetPrinterCopiesExt<T>(this ProxyBase<T> proxyRef,int copies) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterCopies(copies);
        }

        public static double SetPrinterLinewidthExt<T>(this ProxyBase<T> proxyRef,double linewidth) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterLinewidth(linewidth);
        }

        public static int SetPrinterMarginsExt<T>(this ProxyBase<T> proxyRef,double top, double bottom, double left, double right) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterMargins(top, bottom, left, right);
        }

        public static int SetPrinterNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrinterName(name);
        }

        public static int SetPrintPageNumbersExt<T>(this ProxyBase<T> proxyRef,int set) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrintPageNumbers(set);
        }

        public static int SetPrintSheetOrderExt<T>(this ProxyBase<T> proxyRef,int set) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrintSheetOrder(set);
        }

        public static int SetPrintSplitPagesExt<T>(this ProxyBase<T> proxyRef,int set) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetPrintSplitPages(set);
        }

        public static int SetScriptReturnExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetScriptReturn(value);
        }

        public static int SetTemplateFileDBEExt<T>(this ProxyBase<T> proxyRef,string templatefilename) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetTemplateFileDBE(templatefilename);
        }

        public static int SetTestMarkExt<T>(this ProxyBase<T> proxyRef,int num, int value) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetTestMark(num, value);
        }

        public static int SetTriggerExt<T>(this ProxyBase<T> proxyRef,string name, string filename, int active) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetTrigger(name, filename, active);
        }

        public static int SetTriggerReturnExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetTriggerReturn(value);
        }

        public static int SetUseSheetOrientationExt<T>(this ProxyBase<T> proxyRef,int set) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SetUseSheetOrientation(set);
        }

        public static int ShowNormalExt<T>(this ProxyBase<T> proxyRef) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.ShowNormal();
        }

        public static int SleepExt<T>(this ProxyBase<T> proxyRef,int msec) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.Sleep(msec);
        }

        public static int SortArrayByIndexExt<T>(this ProxyBase<T> proxyRef,ref object array, int rows, int columns, int sortindex1, int sortindex2) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SortArrayByIndex(ref array, rows, columns, sortindex1, sortindex2);
        }

        public static int SortArrayByIndexExt<T>(this ProxyBase<T> proxyRef,ref object array, ref object options) where T : IDbeApplicationInterface
        {
            return proxyRef.Instance.SortArrayByIndexEx(ref array, ref options);
        }
    }
}