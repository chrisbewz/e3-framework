// using e3;
// using E3Framework.Contracts.Interfaces;
//
// namespace E3Framework.Abstractions.ProxyTypes
// {
//     /// <summary>
//     /// Proxy class (generated for E3.series 2015.1613)
//     /// </summary>
//      public static class E3StructureNodeProxy <T> : ProxyBase<T>
//         where T : IStructureNodeInterface
//     {
//         public static E3StructureNodeProxy(object instance) 
//         {
//         }
//
//         public static int AddAttributeValue(string name, string value)
//         {
//             return this.Instance.AddAttributeValue(name, value);
//         }
//
//         public static int Create(string name, string typname, int parentid, int afterid)
//         {
//             return this.Instance.Create(name, typname, parentid, afterid);
//         }
//
//         public static int Delete()
//         {
//             return this.Instance.Delete();
//         }
//
//         public static int DeleteAttribute(string name)
//         {
//             return this.Instance.DeleteAttribute(name);
//         }
//
//         public static int GetAttributeCount()
//         {
//             object attIds = null;
//             GetAttributeIds(ref attIds);
//             return attIds.ToIEnumerable().Count();
//         }
//
//         public static int GetAllDeviceIds(ref object ids)
//         {
//             return this.Instance.GetAllDeviceIds(ref ids);
//         }
//
//         public static int GetAllSignalIds(ref object ids)
//         {
//             return this.Instance.GetAllSignalIds(ref ids);
//         }
//
//         public static int GetAttributeIds(ref object ids, string attnam = null)
//         {
//             return this.Instance.GetAttributeIds(ref ids, attnam);
//         }
//
//         public static string GetAttributeValue(string name)
//         {
//             return this.Instance.GetAttributeValue(name);
//         }
//
//         public static int GetExternalDocumentIds(ref object ids)
//         {
//             return this.Instance.GetExternalDocumentIds(ref ids);
//         }
//
//         public static int GetId()
//         {
//             return this.Instance.GetId();
//         }
//
//         public static string GetInternalName()
//         {
//             return this.Instance.GetInternalName();
//         }
//
//         public static string GetName()
//         {
//             return this.Instance.GetName();
//         }
//
//         public static int GetParentID()
//         {
//             return this.Instance.GetParentID();
//         }
//
//         public static int GetSheetIds(ref object ids)
//         {
//             return this.Instance.GetSheetIds(ref ids);
//         }
//
//         public static int GetStructureNodeIds(ref object ids)
//         {
//             return this.Instance.GetStructureNodeIds(ref ids);
//         }
//
//         public static string GetTypeName()
//         {
//             return this.Instance.GetTypeName();
//         }
//
//         public static int HasAttribute(string name)
//         {
//             return this.Instance.HasAttribute(name);
//         }
//
//         public static int Highlight(int colour, double width)
//         {
//             return this.Instance.Highlight(colour, width);
//         }
//
//         public static int IsObjectTypeAllowed(int sheets, int devices)
//         {
//             return this.Instance.IsObjectTypeAllowed(sheets, devices);
//         }
//
//         public static int MoveTo(int destID, int before = 0)
//         {
//             return this.Instance.MoveTo(destID, before);
//         }
//
//         public static int ResetHighlight()
//         {
//             return this.Instance.ResetHighlight();
//         }
//
//         public static int SetAttributeValue(string name, string value)
//         {
//             return this.Instance.SetAttributeValue(name, value);
//         }
//
//         public static int SetExternalDocumentIds(ref object ids)
//         {
//             return this.Instance.SetExternalDocumentIds(ref ids);
//         }
//
//         public static int SetId(int id)
//         {
//             return this.Instance.SetId(id);
//         }
//
//         public static int SetName(string name)
//         {
//             return this.Instance.SetName(name);
//         }
//
//         public static int SetSheetIds(ref object ids)
//         {
//             return this.Instance.SetSheetIds(ref ids);
//         }
//
//         public static int SetStructureNodeIds(ref object ids)
//         {
//             return this.Instance.SetStructureNodeIds(ref ids);
//         }
//
//         public static int Id { get; set; }
//         public static T Instance { get; set; }
//     }
// }