using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3UserMenuItemProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int id, string text, string command, string parameters, string folder, string image, string shortcut,
            int Visible, int wait, int flags = 1) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.Create(id, text, command, parameters, folder, image, shortcut, Visible, wait, flags);
        }

        public static int CreateContextSeparatorExt<T>(this ProxyBase<T> proxyRef,string text) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.CreateContextSeparator(text);
        }

        public static int CreateContextUserToolExt<T>(this ProxyBase<T> proxyRef,string text, string command) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.CreateContextUserTool(text, command);
        }

        public static int CreateSeparatorExt<T>(this ProxyBase<T> proxyRef,string text) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.CreateSeparator(text);
        }

        public static int CreateUserToolExt<T>(this ProxyBase<T> proxyRef,string text, string command) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.CreateUserTool(text, command);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteContextExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.DeleteContext();
        }

        public static int DeleteUserToolExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.DeleteUserTool();
        }

        public static string GetCommandExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetCommand();
        }

        public static string GetDescriptionExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetDescription();
        }

        public static int GetEnableExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetEnable();
        }

        public static string GetFolderExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetFolder();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetImageExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetImage();
        }

        public static string GetParametersExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetParameters();
        }

        public static string GetShortCutExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetShortCut();
        }

        public static string GetTextExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetText();
        }

        public static int GetVisibleExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetVisible();
        }

        public static int GetWaitForEndOfCommandExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.GetWaitForEndOfCommand();
        }

        public static int IsDeletedExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.IsDeleted();
        }

        public static int SetCommandExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetCommand(newval);
        }

        public static int SetDescriptionExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetDescription(newval);
        }

        public static int SetEnableExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetEnable(newval);
        }

        public static int SetFolderExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetFolder(newval);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetImageExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetImage(newval);
        }

        public static int SetParametersExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetParameters(newval);
        }

        public static int SetShortCutExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetShortCut(newval);
        }

        public static int SetTextExt<T>(this ProxyBase<T> proxyRef,string newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetText(newval);
        }

        public static int SetVisibleExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetVisible(newval);
        }

        public static int SetWaitForEndOfCommandExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.SetWaitForEndOfCommand(newval);
        }

        public static int UnDeleteExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.UnDelete();
        }

        public static int UpdateUserInterfaceExt<T>(this ProxyBase<T> proxyRef) where T : IUserMenuItemInterface
        {
            return proxyRef.Instance.UpdateUserInterface();
        }
    }
}