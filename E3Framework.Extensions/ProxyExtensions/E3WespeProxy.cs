// using e3;
// using E3Framework.Contracts.Interfaces;
//
// namespace E3Framework.Abstractions.ProxyTypes
// {
//     /// <summary>
//     /// Proxy class (generated for E3.series 2015.1613)
//     /// </summary>
//      public static class E3WespeProxy<T> : ProxyBase<T>
//         where T : IWespeInterface
//     {
//         public static E3WespeProxy(object instance) 
//         {
//         }
//
//         public static int ChangeTextTo(int ttyp, int txtid)
//         {
//             return this.Instance.ChangeTextTo(ttyp, txtid);
//         }
//
//         public static object CreateProject(string name)
//         {
//             return this.Instance.CreateProject(name);
//         }
//
//         public static int CreateText(int ttyp, string value, int shtId, double x, double y)
//         {
//             return this.Instance.CreateText(ttyp, value, shtId, x, y);
//         }
//
//         public static int DeleteText(int txtid)
//         {
//             return this.Instance.DeleteText(txtid);
//         }
//
//         public static int DisintegrateDynamic(int symid, ref object ids)
//         {
//             return this.Instance.DisintegrateDynamic(symid, ref ids);
//         }
//
//         public static int GetCursorPosition(out object x, out object y, out object c, out object vk, out object modflg)
//         {
//             return this.Instance.GetCursorPosition(out x, out y, out c, out vk, out modflg);
//         }
//
//         public static int GetId()
//         {
//             return this.Instance.GetId();
//         }
//
//         public static int GetInsideSymbolIds(int fldid, ref object ids)
//         {
//             return this.Instance.GetInsideSymbolIds(fldid, ref ids);
//         }
//
//         public static int GetNodeIds(int shti, ref object ids)
//         {
//             return this.Instance.GetNodeIds(shti, ref ids);
//         }
//
//         public static int IdentifyGraphIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
//         {
//             return this.Instance.IdentifyGraphIds(shtId, ref ids, px, py, snap, Visible);
//         }
//
//         public static int IdentifyNetSegmentIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
//         {
//             return this.Instance.IdentifyNetSegmentIds(shtId, ref ids, px, py, snap, Visible);
//         }
//
//         public static int IdentifyNodePoint(int shtId, out object fx, out object fy, double px, double py, double snap = 0, int Visible = 1)
//         {
//             return this.Instance.IdentifyNodePoint(shtId, out fx, out fy, px, py, snap, Visible);
//         }
//
//         public static int IdentifySymbolIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
//         {
//             return this.Instance.IdentifySymbolIds(shtId, ref ids, px, py, snap, Visible);
//         }
//
//         public static int IdentifyTextIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
//         {
//             return this.Instance.IdentifyTextIds(shtId, ref ids, px, py, snap, Visible);
//         }
//
//         public static object ImportSheet(string name, string filename)
//         {
//             return this.Instance.ImportSheet(name, filename);
//         }
//
//         public static int MergeIdsToDynamic(int symid, ref object ids)
//         {
//             return this.Instance.MergeIdsToDynamic(symid, ref ids);
//         }
//
//         public static int MoveIds(ref object ids, int inside_only, int structlimit, double offx, double offy, ref object modids)
//         {
//             return this.Instance.MoveIds(ref ids, inside_only, structlimit, offx, offy, ref modids);
//         }
//
//         public static int PlacePart(string name, string version, int symid, int shtId, double x, double y, double rot)
//         {
//             return this.Instance.PlacePart(name, version, symid, shtId, x, y, rot);
//         }
//
//         public static int PlacePartInteractively(string name, string version, int symid, out object x, out object y, out object rot)
//         {
//             return this.Instance.PlacePartInteractively(name, version, symid, out x, out y, out rot);
//         }
//
//         public static int PlacePolygonField(int shti, int pnts, ref object x, ref object y, int moveall = 0)
//         {
//             return this.Instance.PlacePolygonField(shti, pnts, ref x, ref y, moveall);
//         }
//
//         public static int SaveProject(string name)
//         {
//             return this.Instance.SaveProject(name);
//         }
//
//         public static int SetGraphLine(int gri, double x1, double y1, double x2, double y2)
//         {
//             return this.Instance.SetGraphLine(gri, x1, y1, x2, y2);
//         }
//
//         public static int SetId(int id)
//         {
//             return this.Instance.SetId(id);
//         }
//
//         public static int SetParentApp(object app)
//         {
//             return this.Instance.SetParentApp(app);
//         }
//
//         public static int Id { get; set; }
//         public static T Instance { get; set; }
//     }
// }