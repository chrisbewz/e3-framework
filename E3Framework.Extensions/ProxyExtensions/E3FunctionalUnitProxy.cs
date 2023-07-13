// using e3;
// using E3Framework.Contracts.Interfaces;
//
// namespace E3Framework.Abstractions.ProxyTypes
// {
//     /// <summary>
//     /// Proxy class (generated for E3.series 2015.1613)
//     /// </summary>
//      public static class E3FunctionalUnitProxy <T> : ProxyBase<T>
//         where T : IFunctionalUnitInterface
//     {
//         public static E3FunctionalUnitProxy(object instance) 
//         {
//         }
//         
//         public static int AddAttributeValue(string name, string value)
//         {
//             return proxyRef.Instance.AddAttributeValue(name, value);
//         }
//
//         public static int Create(int fdbID, string name, string symnam, string symver)
//         {
//             return proxyRef.Instance.Create(fdbID, name, symnam, symver);
//         }
//
//         public static int Delete()
//         {
//             return proxyRef.Instance.Delete();
//         }
//
//         public static int DeleteAttribute(string name)
//         {
//             return proxyRef.Instance.DeleteAttribute(name);
//         }
//
//         public static int GetAttributeCount()
//         {
//             object attIds = null;
//             GetAttributeIds(ref attIds);
//             return attIds.ToIEnumerable().Count();
//         }
//
//         public static int GetAttributeIds(ref object ids, string attnam = null)
//         {
//             return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
//         }
//
//         public static string GetAttributeValue(string name)
//         {
//             return proxyRef.Instance.GetAttributeValue(name);
//         }
//
//         public static int GetDeviceId()
//         {
//             return proxyRef.Instance.GetDeviceId();
//         }
//
//         public static int GetFunctionalPortIds(ref object ids)
//         {
//             return proxyRef.Instance.GetFunctionalPortIds(ref ids);
//         }
//
//         public static int GetId()
//         {
//             return proxyRef.Instance.GetId();
//         }
//
//         public static string GetName()
//         {
//             return proxyRef.Instance.GetName();
//         }
//
//         public static int GetSchemaSymbolId()
//         {
//             return proxyRef.Instance.GetSchemaSymbolId();
//         }
//
//         public static int HasAttribute(string name)
//         {
//             return proxyRef.Instance.HasAttribute(name);
//         }
//
//         public static int IsDynamic()
//         {
//             return proxyRef.Instance.IsDynamic();
//         }
//
//         public static int SetAttributeValue(string name, string value)
//         {
//             return proxyRef.Instance.SetAttributeValue(name, value);
//         }
//
//         public static int SetId(int id)
//         {
//             return proxyRef.Instance.SetId(id);
//         }
//
//         public static int SetName(string name)
//         {
//             return proxyRef.Instance.SetName(name);
//         }
//
//         public static int Id { get; set; }
//         public static T Instance { get; set; }
//     }
// }