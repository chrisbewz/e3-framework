using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3ExternalDocumentProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int checkinExt<T>(this ProxyBase<T> proxyRef,int unlock = 1) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.checkin(unlock);
        }

        public static int CheckOutExt<T>(this ProxyBase<T> proxyRef,int @lock = 1) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.CheckOut(@lock);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string file) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Create(modi, name, file);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DisplayExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Display();
        }

        public static string GetAssignmentExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetAssignment();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static string GetFileExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetFile();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetId();
        }

        public static string GetInternalNameExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetInternalName();
        }

        public static string GetLocationExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetLocation();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetName();
        }

        public static string GetOwnerExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.GetOwner();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.HasAttribute(name);
        }

        public static int InsertFileExt<T>(this ProxyBase<T> proxyRef,int modi, string name, string file) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.InsertFile(modi, name, file);
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.IsOffline();
        }

        public static int IsReadOnlyExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.IsReadOnly();
        }

        public static int IsVisibleExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.IsVisible();
        }

        public static int MoveToExt<T>(this ProxyBase<T> proxyRef,int position, int before = 0) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.MoveTo(position, before);
        }

        public static int RemoveExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Remove();
        }

        public static int SaveExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Save();
        }

        public static int SearchExt<T>(this ProxyBase<T> proxyRef,int modi, string name) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Search(modi, name);
        }

        public static int SetAssignmentExt<T>(this ProxyBase<T> proxyRef,string newass) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetAssignment(newass);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetCompleteNameExt<T>(this ProxyBase<T> proxyRef,string newnam, string newass, string newloc) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetCompleteName(newnam, newass, newloc);
        }

        public static int SetCompleteNameExExt<T>(this ProxyBase<T> proxyRef,string newnam, string newass, string newloc, int onlygiven) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetCompleteNameEx(newnam, newass, newloc, onlygiven);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetId(id);
        }

        public static int SetLocationExt<T>(this ProxyBase<T> proxyRef,string newloc) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetLocation(newloc);
        }

        public static string SetNameExt<T>(this ProxyBase<T> proxyRef,string newname) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetName(newname);
        }

        public static int SetVisibleExt<T>(this ProxyBase<T> proxyRef,int Visible = 1) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.SetVisible(Visible);
        }

        public static int VisibleExt<T>(this ProxyBase<T> proxyRef) where T : IExternalDocumentInterface
        {

            return proxyRef.Instance.Visible();
        }

    }
}