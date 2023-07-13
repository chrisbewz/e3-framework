// using System;
// using e3;
// using E3Framework.Contracts.Interfaces;
//
// namespace E3Framework.Abstractions.ProxyTypes
// {
//     /// <summary>
//     /// Proxy class (generated for E3.series 2015.1613)
//     /// </summary>
//      public static class E3GroupProxy <T> : ProxyBase<T>
//         where T : IGroupInterface
//     {
//         public static E3GroupProxy(object instance) 
//         {
//         }
//
//         public static int AddAttributeValue(string name, string value)
//         {
//             return proxyRef.Instance.AddAttributeValue(name, value);
//         }
//
//         public static int AddItems(ref object ids)
//         {
//             return proxyRef.Instance.AddItems(ref ids);
//         }
//
//         public static int Create(ref object ids, string name = null)
//         {
//             return proxyRef.Instance.Create(ref ids, name);
//         }
//
//         public static int Delete(ref object ids)
//         {
//             return proxyRef.Instance.Delete(ref ids);
//         }
//
//         public static int DeleteAttribute(string name)
//         {
//             return proxyRef.Instance.DeleteAttribute(name);
//         }
//
//         public static int GetAttributeCount<T>(this ProxyBase<T> proxyRef)
//         {
//             object attIds = null;
//             GetAttributeIds(ref attIds);
//             return attIds.Unpack<T>(this ProxyBase<T> proxyRef).Count<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static int DeleteContents<T>(this ProxyBase<T> proxyRef)
//         {
//             return proxyRef.Instance.DeleteContents<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static int DeleteUnplaced<T>(this ProxyBase<T> proxyRef)
//         {
//             return proxyRef.Instance.DeleteUnplaced<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static int GetAttributeIds(ref object ids, string name = null)
//         {
//             return proxyRef.Instance.GetAttributeIds(ref ids, name);
//         }
//
//         public static string GetAttributeValue(string name)
//         {
//             return proxyRef.Instance.GetAttributeValue(name);
//         }
//
//         [Obsolete("Method is not supported", true)]
//         public static int HasAttribute(string name)
//         {
//             throw new System.NotSupportedException("Method is not supported");
//         }
//
//         public static int GetGroupId(int id)
//         {
//             return proxyRef.Instance.GetGroupId(id);
//         }
//
//         public static int GetId<T>(this ProxyBase<T> proxyRef)
//         {
//             return proxyRef.Instance.GetId<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static int GetItems(ref object ids)
//         {
//             return proxyRef.Instance.GetItems(ref ids);
//         }
//
//         public static int GetLocation(ref object x, ref object y, ref object z, ref object grid)
//         {
//             return proxyRef.Instance.GetLocation(ref x, ref y, ref z, ref grid);
//         }
//
//         public static int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value)
//         {
//             return proxyRef.Instance.GetLocation(ref x, ref y, ref z, ref grid, ref column_value);
//         }
//
//         public static int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value,
//             ref object row_value)
//         {
//             return proxyRef.Instance.GetLocation(ref x, ref y, ref z, ref grid, ref column_value, ref row_value);
//         }
//
//         public static string GetName<T>(this ProxyBase<T> proxyRef)
//         {
//             return proxyRef.Instance.GetName<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static string GetPartName<T>(this ProxyBase<T> proxyRef)
//         {
//             return proxyRef.Instance.GetPartName<T>(this ProxyBase<T> proxyRef);
//         }
//
//         public static int IsPart()
//         {
//             return proxyRef.Instance.IsPart();
//         }
//
//         public static int IsSubCircuit()
//         {
//             return proxyRef.Instance.IsSubCircuit();
//         }
//
//         public static int IsUnplaced()
//         {
//             return proxyRef.Instance.IsUnplaced();
//         }
//
//         public static int Place(int shtId, double x, double y, double z, double rotation)
//         {
//             return proxyRef.Instance.Place(shtId, x, y, z, rotation);
//         }
//
//         public static int PlaceInteractively()
//         {
//             return proxyRef.Instance.PlaceInteractively();
//         }
//
//         public static int RemoveItems(ref object ids)
//         {
//             return proxyRef.Instance.RemoveItems(ref ids);
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
//         public static int SetPartName(string name)
//         {
//             return proxyRef.Instance.SetPartName(name);
//         }
//
//         public static int Unplace()
//         {
//             return proxyRef.Instance.Unplace();
//         }
//
//         public static int UpdatePart()
//         {
//             return proxyRef.Instance.UpdatePart();
//         }
//
//         public static int Id { get; set; }
//         public static T Instance { get; set; }
//     }
// }