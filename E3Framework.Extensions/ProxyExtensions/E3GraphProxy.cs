using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3GraphProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IGraphInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int CreateArcExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, double radius, double start, double end) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateArc(shti, x, y, radius, start, end);
        }

        public static int CreateCircleExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, double radius) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateCircle(shti, x, y, radius);
        }

        public static int CreateCurveExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateCurve(shti, pnts, ref x, ref y);
        }

        public static int CreateFromSymbolExt<T>(this ProxyBase<T> proxyRef,int shti, double x, double y, string rot, double scale, int maintaintextsize, string symnam,
            string symver) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateFromSymbol(shti, x, y, rot, scale, maintaintextsize, symnam, symver);
        }

        public static int CreateGroupExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateGroup(ref ids);
        }

        public static int CreateImageExt<T>(this ProxyBase<T> proxyRef,int sheetid, double xpos, double ypos, double xsize, double ysize, string filename, int embed = 1) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateImage(sheetid, xpos, ypos, xsize, ysize, filename, embed);
        }

        public static int CreateLineExt<T>(this ProxyBase<T> proxyRef,int shti, double x1, double y1, double x2, double y2) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateLine(shti, x1, y1, x2, y2);
        }

        public static int CreateMeasureExt<T>(this ProxyBase<T> proxyRef,int shti, double x1, double y1, double x2, double y2) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateMeasure(shti, x1, y1, x2, y2);
        }

        public static int CreatePolygonExt<T>(this ProxyBase<T> proxyRef,int shti, int pnts, ref object x, ref object y) where T : IGraphInterface
        {
            return proxyRef.Instance.CreatePolygon(shti, pnts, ref x, ref y);
        }

        public static int CreateRectangleExt<T>(this ProxyBase<T> proxyRef,int shti, double x1, double y1, double x2, double y2) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateRectangle(shti, x1, y1, x2, y2);
        }

        public static int CreateRotatedTextExt<T>(this ProxyBase<T> proxyRef,int shti, string text, double x, double y, double rotation) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateRotatedText(shti, text, x, y, rotation);
        }

        public static int CreateTextExt<T>(this ProxyBase<T> proxyRef,int shti, string text, double x, double y) where T : IGraphInterface
        {
            return proxyRef.Instance.CreateText(shti, text, x, y);
        }

        public static int Delete<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IGraphInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetArcExt<T>(this ProxyBase<T> proxyRef,ref object xm, ref object ym, ref object rad, ref object startang, ref object endang) where T : IGraphInterface
        {
            return proxyRef.Instance.GetArc(ref xm, ref ym, ref rad, ref startang, ref endang);
        }

        public static int GetArrows<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetArrows();
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionExpressionsExExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static int GetAttributeCount<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IGraphInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetCircleExt<T>(this ProxyBase<T> proxyRef,ref object xm, ref object ym, ref object rad) where T : IGraphInterface
        {
            return proxyRef.Instance.GetCircle(ref xm, ref ym, ref rad);
        }

        public static int GetColourExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetColour();
        }

        public static int GetCurveExt<T>(this ProxyBase<T> proxyRef,ref object npnts, ref object xarr, ref object yarr) where T : IGraphInterface
        {
            return proxyRef.Instance.GetCurve(ref npnts, ref xarr, ref yarr);
        }

        public static int GetGraphCountExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetGraphCount();
        }

        public static int GetGraphIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IGraphInterface
        {
            return proxyRef.Instance.GetGraphIds(ref ids);
        }

        public static int GetHatchColourExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetHatchColour();
        }

        public static double GetHatchLineDistanceExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetHatchLineDistance();
        }

        public static int GetHatchLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetHatchLineStyle();
        }

        public static double GetHatchLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetHatchLineWidth();
        }

        public static int GetHatchPatternExt<T>(this ProxyBase<T> proxyRef,out object angle1, out object angle2) where T : IGraphInterface
        {
            return proxyRef.Instance.GetHatchPattern(out angle1, out angle2);
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetImageInfoExt<T>(this ProxyBase<T> proxyRef,ref object xpos, ref object ypos, ref object xsize, ref object ysize, ref object filename,
            ref object embed) where T : IGraphInterface
        {
            return proxyRef.Instance.GetImageInfo(ref xpos, ref ypos, ref xsize, ref ysize, ref filename, ref embed);
        }

        public static string GetInternalTextExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetInternalText();
        }

        public static int GetLanguageIdExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLanguageId();
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static int GetLineExt<T>(this ProxyBase<T> proxyRef,ref object x1, ref object y1, ref object x2, ref object y2) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLine(ref x1, ref y1, ref x2, ref y2);
        }

        public static int GetLineColourExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLineColour();
        }

        public static int GetLineStyleExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLineStyle();
        }

        public static double GetLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetLineWidth();
        }

        public static int GetParentIDExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetParentID();
        }

        public static int GetPolygonExt<T>(this ProxyBase<T> proxyRef,ref object npnts, ref object xarr, ref object yarr) where T : IGraphInterface
        {
            return proxyRef.Instance.GetPolygon(ref npnts, ref xarr, ref yarr);
        }

        public static int GetRectangleExt<T>(this ProxyBase<T> proxyRef,ref object x1, ref object y1, ref object x2, ref object y2) where T : IGraphInterface
        {
            return proxyRef.Instance.GetRectangle(ref x1, ref y1, ref x2, ref y2);
        }

        public static string GetTextExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetText();
        }

        public static int GetTextColourExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextColour();
        }

        public static string GetTextFontNameExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextFontName();
        }

        public static double GetTextHeightExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextHeight();
        }

        public static int GetTextLeftJustifiedSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextLeftJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetTextModeExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextMode();
        }

        public static double GetTextRotationExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextRotation();
        }

        public static int GetTextStyleExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTextStyle();
        }

        public static int GetTypeIdExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.GetTypeId();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IGraphInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsRedlinedExt<T>(this ProxyBase<T> proxyRef) where T : IGraphInterface
        {
            return proxyRef.Instance.IsRedlined();
        }

        public static int PlaceExt<T>(this ProxyBase<T> proxyRef,double x, double y) where T : IGraphInterface
        {
            return proxyRef.Instance.Place(x, y);
        }

        public static int SaveImageExt<T>(this ProxyBase<T> proxyRef,string filename) where T : IGraphInterface
        {
            return proxyRef.Instance.SaveImage(filename);
        }

        public static int SetArrowsExt<T>(this ProxyBase<T> proxyRef,int newarrows) where T : IGraphInterface
        {
            return proxyRef.Instance.SetArrows(newarrows);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IGraphInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IGraphInterface
        {
            return proxyRef.Instance.SetColour(newcol);
        }

        public static int SetHatchColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IGraphInterface
        {
            return proxyRef.Instance.SetHatchColour(newcol);
        }

        public static double SetHatchLineDistanceExt<T>(this ProxyBase<T> proxyRef,double newdist) where T : IGraphInterface
        {
            return proxyRef.Instance.SetHatchLineDistance(newdist);
        }

        public static int SetHatchLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstyle) where T : IGraphInterface
        {
            return proxyRef.Instance.SetHatchLineStyle(newstyle);
        }

        public static double SetHatchLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : IGraphInterface
        {
            return proxyRef.Instance.SetHatchLineWidth(newwid);
        }

        public static int SetHatchPatternExt<T>(this ProxyBase<T> proxyRef,int newpat, double angle1, double angle2) where T : IGraphInterface
        {
            return proxyRef.Instance.SetHatchPattern(newpat, angle1, angle2);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IGraphInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetImageInfoExt<T>(this ProxyBase<T> proxyRef,double xpos, double ypos, double xsize, double ysize, string filename = null, int embed = -1) where T : IGraphInterface
        {
            return proxyRef.Instance.SetImageInfo(xpos, ypos, xsize, ysize, filename, embed);
        }

        public static int SetLanguageIdExt<T>(this ProxyBase<T> proxyRef,int newval) where T : IGraphInterface
        {
            return proxyRef.Instance.SetLanguageId(newval);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int newlev) where T : IGraphInterface
        {
            return proxyRef.Instance.SetLevel(newlev);
        }

        public static int SetLineColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IGraphInterface
        {
            return proxyRef.Instance.SetLineColour(newcol);
        }

        public static int SetLineStyleExt<T>(this ProxyBase<T> proxyRef,int newstyle) where T : IGraphInterface
        {
            return proxyRef.Instance.SetLineStyle(newstyle);
        }

        public static double SetLineWidthExt<T>(this ProxyBase<T> proxyRef,double newwid) where T : IGraphInterface
        {
            return proxyRef.Instance.SetLineWidth(newwid);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : IGraphInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static int SetParentIDExt<T>(this ProxyBase<T> proxyRef,int id) where T : IGraphInterface
        {
            return proxyRef.Instance.SetParentID(id);
        }

        public static int SetTextExt<T>(this ProxyBase<T> proxyRef,string newtext) where T : IGraphInterface
        {
            return proxyRef.Instance.SetText(newtext);
        }

        public static int SetTextColourExt<T>(this ProxyBase<T> proxyRef,int newcol) where T : IGraphInterface
        {
            return proxyRef.Instance.SetTextColour(newcol);
        }

        public static int SetTextFontNameExt<T>(this ProxyBase<T> proxyRef,string newname) where T : IGraphInterface
        {
            return proxyRef.Instance.SetTextFontName(newname);
        }

        public static int SetTextHeightExt<T>(this ProxyBase<T> proxyRef,double hgt) where T : IGraphInterface
        {
            return proxyRef.Instance.SetTextHeight(hgt);
        }

        public static int SetTextModeExt<T>(this ProxyBase<T> proxyRef,int newmod) where T : IGraphInterface
        {
            return proxyRef.Instance.SetTextMode(newmod);
        }

        public static int SetTextStyleExt<T>(this ProxyBase<T> proxyRef,int newstl) where T : IGraphInterface
        {
            return proxyRef.Instance.SetTextStyle(newstl);
        }

        public static int UnGroupExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IGraphInterface
        {
            return proxyRef.Instance.UnGroup(ref ids);
        }
        
    }
}