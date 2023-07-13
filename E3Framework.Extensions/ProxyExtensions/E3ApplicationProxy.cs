using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public static class E3ApplicationProxy
    {
        public static int AvoidAutomaticClosingExt<T>(this ProxyBase<T> proxyRef, int avoid = 1) where T : IApplicationInterface
        {
            return proxyRef.Instance.AvoidAutomaticClosing(avoid);
        }

        public static int BeginForeignTaskExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.BeginForeignTask();
        }

        public static void ClearOutputWindowExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            proxyRef.Instance.ClearOutputWindow();
        }

        public static void ClearResultWindowExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            proxyRef.Instance.ClearResultWindow();
        }

        public static object CreateDllObjectExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.CreateDllObject();
        }

        public static object CreateJobObjectExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.CreateJobObject();
        }

        public static object CreateMenuItemObjectExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.CreateMenuItemObject();
        }

        public static object CreateWespeObjectExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.CreateWespeObject();
        }

        public static int DisplayExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.Display();
        }

        public static int EnableCOMExt<T>(this ProxyBase<T> proxyRef,string password) where T : IApplicationInterface
        {
            return proxyRef.Instance.EnableCOM(password);
        }

        public static int EnableLogfileExt<T>(this ProxyBase<T> proxyRef,int en) where T : IApplicationInterface
        {
            return proxyRef.Instance.EnableLogfile(en);
        }

        public static int EndForeignTaskExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.EndForeignTask();
        }

        public static int FreeLicenseExt<T>(this ProxyBase<T> proxyRef,string feature) where T : IApplicationInterface
        {
            return proxyRef.Instance.FreeLicense(feature);
        }

        public static int FreeLicensePermanentExt<T>(this ProxyBase<T> proxyRef,string feature) where T : IApplicationInterface
        {
            return proxyRef.Instance.FreeLicensePermanent(feature);
        }

        public static string fullnameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.fullname();
        }

        public static string GetActualDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetActualDatabase();
        }

        public static int GetAvailableLanguagesExt<T>(this ProxyBase<T> proxyRef,ref object languages) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetAvailableLanguages(ref languages);
        }

        public static string GetBuildExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetBuild();
        }

        public static string GetComponentDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetComponentDatabase();
        }

        public static string GetComponentDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetComponentDatabaseTableSchema();
        }

        public static string GetConfigurationDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetConfigurationDatabase();
        }

        public static string GetConfigurationDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetConfigurationDatabaseTableSchema();
        }

        public static int GetDatabaseTableSelectedComponentsExt<T>(this ProxyBase<T> proxyRef,ref object ComponentArray, ref object VersionArray) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTableSelectedComponents(ref ComponentArray, ref VersionArray);
        }

        public static int GetDatabaseTreeSelectedComponentsExt<T>(this ProxyBase<T> proxyRef,out object ComponentArray, out object VersionArray) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedComponents(out ComponentArray, out VersionArray);
        }

        public static int GetDatabaseTreeSelectedModelsExt<T>(this ProxyBase<T> proxyRef,out object ModelArray) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedModels(out ModelArray);
        }

        public static int GetDatabaseTreeSelectedSymbolsExt<T>(this ProxyBase<T> proxyRef,out object SymbolArray, out object VersionArray) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDatabaseTreeSelectedSymbols(out SymbolArray, out VersionArray);
        }

        public static int GetDefinedDatabaseConnectionStringsExt<T>(this ProxyBase<T> proxyRef,string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDefinedDatabaseConnectionStrings(dbname, out cmp_cs, out sym_cs, out cnf_cs);
        }

        public static int GetDefinedDatabasesExt<T>(this ProxyBase<T> proxyRef,out object dbnames) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetDefinedDatabases(out dbnames);
        }

        public static int GetEnableInteractiveDialogsExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetEnableInteractiveDialogs();
        }

        public static int GetErrorCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetErrorCount();
        }

        public static string GetFullNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetFullName();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetInfoCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetInfoCount();
        }

        public static int GetInstallationLanguageExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetInstallationLanguage();
        }

        public static string GetInstallationPathExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetInstallationPath();
        }

        public static int GetJobCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetJobCount();
        }

        public static int GetJobIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetJobIds(ref ids);
        }

        public static string GetLanguageDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetLanguageDatabase();
        }

        public static string GetLanguageDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetLanguageDatabaseTableSchema();
        }

        public static int GetLicenseExt<T>(this ProxyBase<T> proxyRef,string feature) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetLicense(feature);
        }

        public static int GetLicensePermanentExt<T>(this ProxyBase<T> proxyRef,string feature) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetLicensePermanent(feature);
        }

        public static string GetLogfileNameExt<T>(this ProxyBase<T> proxyRef,int index = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetLogfileName(index);
        }

        public static object GetModalWindowExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetModalWindow();
        }

        public static int GetMultiuserFolderPathExt<T>(this ProxyBase<T> proxyRef,out object path) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetMultiuserFolderPath(out path);
        }

        public static int GetMultiuserProjectsExt<T>(this ProxyBase<T> proxyRef,ref object name) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetMultiuserProjects(ref name);
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static object GetPluginObjectExt<T>(this ProxyBase<T> proxyRef,ref object Plugin) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPluginObject(ref Plugin);
        }

        public static int GetPrintCropMarksExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrintCropMarks();
        }

        public static int GetPrinterColourExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrinterColour();
        }

        public static double GetPrinterLinewidthExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrinterLinewidth();
        }

        public static int GetPrinterMarginsExt<T>(this ProxyBase<T> proxyRef,ref object top, ref object bottom, ref object left, ref object right) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrinterMargins(ref top, ref bottom, ref left, ref right);
        }

        public static string GetPrinterNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrinterName();
        }

        public static int GetPrintPageNumbersExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrintPageNumbers();
        }

        public static int GetPrintSheetOrderExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrintSheetOrder();
        }

        public static int GetPrintSplitPagesExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetPrintSplitPages();
        }

        public static object GetProcessPropertyExt<T>(this ProxyBase<T> proxyRef, string what) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetProcessProperty(what);
        }

        public static int GetProjectInformationExt<T>(this ProxyBase<T> proxyRef,ref object filename, ref object type, ref object is_dbe) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetProjectInformation(ref filename, ref type, ref is_dbe);
        }

        public static string GetProjectLifecycleExt<T>(this ProxyBase<T> proxyRef,string project) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetProjectLifecycle(project);
        }

        public static string GetProviderExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetProvider(dbname);
        }

        public static string GetRegistryVersionExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetRegistryVersion();
        }

        public static object GetScriptArgumentsExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetScriptArguments();
        }

        public static int GetScriptReturnExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetScriptReturn();
        }

        public static string GetServerNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetServerName();
        }

        public static int GetServerPortExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetServerPort();
        }

        public static string GetSymbolDatabaseExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetSymbolDatabase();
        }

        public static string GetSymbolDatabaseTableSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetSymbolDatabaseTableSchema();
        }

        public static int GetSystemMenuItemIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetSystemMenuItemIds(ref ids);
        }

        public static string GetTemplateFileExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTemplateFile();
        }

        public static string GetTemplateFileDBEExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTemplateFileDBE();
        }

        public static int GetTestMarkExt<T>(this ProxyBase<T> proxyRef,int num) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTestMark(num);
        }

        public static string GetTranslatedTextExt<T>(this ProxyBase<T> proxyRef,string text, string language) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTranslatedText(text, language);
        }

        public static int GetTriggerExt<T>(this ProxyBase<T> proxyRef,string name, ref object filename) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTrigger(name, ref filename);
        }

        public static int GetTriggerReturnExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetTriggerReturn();
        }

        public static int GetUserMenuItemIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetUserMenuItemIds(ref ids);
        }

        public static int GetUseSheetOrientationExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetUseSheetOrientation();
        }

        public static int GetVerifyCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetVerifyCount();
        }

        public static string GetVersionExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetVersion();
        }

        public static int GetWarningCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetWarningCount();
        }

        public static string GetWorkspaceNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.GetWorkspaceName();
        }

        public static int IncludeExt<T>(this ProxyBase<T> proxyRef,string text) where T : IApplicationInterface
        {
            return proxyRef.Instance.Include(text);
        }

        public static int IsBasicExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsBasic();
        }

        public static int IsBoardExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsBoard();
        }

        public static int IsCableExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsCable();
        }

        public static int IsCaddyExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsCaddy();
        }

        public static int IsCaddyBasicExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsCaddyBasic();
        }

        public static int IsCaddyDemoExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsCaddyDemo();
        }

        public static int IsCaddyEconomyExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsCaddyEconomy();
        }

        public static int IsDemoExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsDemo();
        }

        public static int IsEconomyExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsEconomy();
        }

        public static int IsFluidExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsFluid();
        }

        public static int IsFormboardExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsFormboard();
        }

        public static int IsFunctionalDesignExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsFunctionalDesign();
        }

        public static int IsLogicExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsLogic();
        }

        public static int IsMultiuserExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsMultiuser();
        }

        public static int IsPanelExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsPanel();
        }

        public static int IsRedlinerExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsRedliner();
        }

        public static int IsSchemaExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsSchema();
        }

        public static int IsScriptRunningExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsScriptRunning();
        }

        public static int IsSmallBusinessExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsSmallBusiness();
        }

        public static int IsStudentExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsStudent();
        }

        public static int IsViewerExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsViewer();
        }

        public static int IsViewPlusExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsViewPlus();
        }

        public static int IsWagoExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsWago();
        }

        public static int IsWagoDemoExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsWagoDemo();
        }

        public static int IsWireExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsWire();
        }

        public static int IsWireWorksExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.IsWireWorks();
        }

        public static int MaximizeExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.Maximize();
        }

        public static int MinimizeExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.Minimize();
        }

        public static int PutErrorExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutError(ok, text, item);
        }

        public static int PutInfoExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutInfo(ok, text, item);
        }

        public static int PutMessageExt<T>(this ProxyBase<T> proxyRef,string text, int item = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutMessage(text, item);
        }

        public static int PutMultiuserLogMessageExt<T>(this ProxyBase<T> proxyRef,string source, string text) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutMultiuserLogMessage(source, text);
        }

        public static int PutVerifyExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutVerify(ok, text, item);
        }

        public static int PutWarningExt<T>(this ProxyBase<T> proxyRef,int ok, string text, int item = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.PutWarning(ok, text, item);
        }

        public static int QuitExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.Quit();
        }

        public static int ResetErrorCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ResetErrorCount();
        }

        public static int ResetInfoCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ResetInfoCount();
        }

        public static int ResetVerifyCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ResetVerifyCount();
        }

        public static int ResetWarningCountExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ResetWarningCount();
        }

        public static int RunExt<T>(this ProxyBase<T> proxyRef,string filename, ref object arguments) where T : IApplicationInterface
        {
            return proxyRef.Instance.Run(filename, ref arguments);
        }

        public static object ScriptArgumentsExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ScriptArguments();
        }

        public static string ScriptFullNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ScriptFullName();
        }

        public static string ScriptNameExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ScriptName();
        }

        public static int SelectComponentFromTableExt<T>(this ProxyBase<T> proxyRef,ref object ComponentName, ref object ComponentVersion) where T : IApplicationInterface
        {
            return proxyRef.Instance.SelectComponentFromTable(ref ComponentName, ref ComponentVersion);
        }

        public static int SetActualDatabaseExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetActualDatabase(dbname);
        }

        public static int SetDefinedDatabaseConnectionStringsExt<T>(this ProxyBase<T> proxyRef,string dbname, string cmp_cs, string sym_cs, string cnf_cs) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetDefinedDatabaseConnectionStrings(dbname, cmp_cs, sym_cs, cnf_cs);
        }

        public static int SetEnableInteractiveDialogsExt<T>(this ProxyBase<T> proxyRef,int value) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetEnableInteractiveDialogs(value);
        }

        public static int SetLanguageDatabaseExt<T>(this ProxyBase<T> proxyRef,string dbname) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetLanguageDatabase(dbname);
        }

        public static int SetLogfileNameExt<T>(this ProxyBase<T> proxyRef,string logfile, int index = 0) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetLogfileName(logfile, index);
        }

        public static int SetModalWindowExt<T>(this ProxyBase<T> proxyRef,ref object hWnd) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetModalWindow(ref hWnd);
        }

        public static int SetPrintCropMarksExt<T>(this ProxyBase<T> proxyRef,int set) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrintCropMarks(set);
        }

        public static int SetPrinterCollateExt<T>(this ProxyBase<T> proxyRef,int col) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterCollate(col);
        }

        public static int SetPrinterColourExt<T>(this ProxyBase<T> proxyRef,int colour) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterColour(colour);
        }

        public static int SetPrinterCopiesExt<T>(this ProxyBase<T> proxyRef,int copies) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterCopies(copies);
        }

        public static double SetPrinterLinewidthExt<T>(this ProxyBase<T> proxyRef,double linewidth) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterLinewidth(linewidth);
        }

        public static int SetPrinterMarginsExt<T>(this ProxyBase<T> proxyRef,double top, double bottom, double left, double right) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterMargins(top, bottom, left, right);
        }

        public static int SetPrinterNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrinterName(name);
        }

        public static int SetPrintPageNumbersExt<T>(this ProxyBase<T> proxyRef,int set) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrintPageNumbers(set);
        }

        public static int SetPrintSheetOrderExt<T>(this ProxyBase<T> proxyRef,int set) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrintSheetOrder(set);
        }

        public static int SetPrintSplitPagesExt<T>(this ProxyBase<T> proxyRef,int set) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetPrintSplitPages(set);
        }

        public static int SetProjectLifecycleExt<T>(this ProxyBase<T> proxyRef,string project, string lifecycle) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetProjectLifecycle(project, lifecycle);
        }

        public static int SetScriptReturnExt<T>(this ProxyBase<T> proxyRef,int value) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetScriptReturn(value);
        }

        public static int SetTemplateFileExt<T>(this ProxyBase<T> proxyRef,string templatefilename) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetTemplateFile(templatefilename);
        }

        public static int SetTemplateFileDBEExt<T>(this ProxyBase<T> proxyRef,string templatefilename) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetTemplateFileDBE(templatefilename);
        }

        public static int SetTestMarkExt<T>(this ProxyBase<T> proxyRef,int num, int value) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetTestMark(num, value);
        }

        public static int SetTriggerExt<T>(this ProxyBase<T> proxyRef,string name, string filename, int active) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetTrigger(name, filename, active);
        }

        public static int SetTriggerReturnExt<T>(this ProxyBase<T> proxyRef,int value) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetTriggerReturn(value);
        }

        public static int SetUseSheetOrientationExt<T>(this ProxyBase<T> proxyRef,int set) where T : IApplicationInterface
        {
            return proxyRef.Instance.SetUseSheetOrientation(set);
        }

        public static int ShowNormalExt<T>(this ProxyBase<T> proxyRef) where T : IApplicationInterface
        {
            return proxyRef.Instance.ShowNormal();
        }

        public static int SleepExt<T>(this ProxyBase<T> proxyRef,int msec) where T : IApplicationInterface
        {
            return proxyRef.Instance.Sleep(msec);
        }

        public static int SortArrayByIndexExt<T>(this ProxyBase<T> proxyRef,ref object array, int rows, int columns, int sortindex1, int sortindex2) where T : IApplicationInterface
        {
            return proxyRef.Instance.SortArrayByIndex(ref array, rows, columns, sortindex1, sortindex2);
        }

        public static int SortArrayByIndexExExt<T>(this ProxyBase<T> proxyRef,ref object array, ref object options) where T : IApplicationInterface
        {
            return proxyRef.Instance.SortArrayByIndexEx(ref array, ref options);
        }
    }
}