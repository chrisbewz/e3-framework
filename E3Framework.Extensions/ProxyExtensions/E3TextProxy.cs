using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3TextProxy
    {
        public static int AddAttributeValue<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ITextInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int CalculateBoxAtExt<T>(this ProxyBase<T> proxyRef,int shti, string text, double x, double y, double rotation, double height, int mode, int style,
            string fontname, int just, int balloon, ref object bx, ref object by) where T : ITextInterface
        {
            return proxyRef.Instance.CalculateBoxAt(shti, text, x, y, rotation, height, mode, style, fontname, just, balloon, ref bx, ref by);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ITextInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int DeleteBoxExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.DeleteBox();
        }

        public static int GetAlignmentExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetAlignment();
        }

        public static int GetAllowedLengthExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetAllowedLength();
        }

        public static int GetAssignedOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions, int Term = 0) where T : ITextInterface
        {
            return proxyRef.Instance.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public static int GetAssignedOptionIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : ITextInterface
        {
            return proxyRef.Instance.GetAssignedOptionIds(ref ids);
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : ITextInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : ITextInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetBallooningExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetBallooning();
        }

        public static int GetBoxExt<T>(this ProxyBase<T> proxyRef,ref object xsize, ref object ysize) where T : ITextInterface
        {
            return proxyRef.Instance.GetBox(ref xsize, ref ysize);
        }

        public static int GetColourExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetColour();
        }

        public static string GetFontNameExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetFontName();
        }

        public static double GetHeightExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetHeight();
        }

        public static string GetHyperlinkAddressExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetHyperlinkAddress();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetInternalTextExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetInternalText();
        }

        public static int GetLanguageIdExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetLanguageId();
        }

        public static int GetLeftJustifiedSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : ITextInterface
        {
            return proxyRef.Instance.GetLeftJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static int GetLockingExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetLocking();
        }

        public static int GetModeExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetMode();
        }

        public static int GetRightJustifiedSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : ITextInterface
        {
            return proxyRef.Instance.GetRightJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public static double GetRotationExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetRotation();
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid) where T : ITextInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value) where T : ITextInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public static int GetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value) where T : ITextInterface
        {
            return proxyRef.Instance.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public static int GetSingleLineExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetSingleLine();
        }

        public static int GetStyleExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetStyle();
        }

        public static string GetTextExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetText();
        }

        public static int GetTextExtentExt<T>(this ProxyBase<T> proxyRef,ref object xarr, ref object yarr) where T : ITextInterface
        {
            return proxyRef.Instance.GetTextExtent(ref xarr, ref yarr);
        }

        public static int GetTextExtentSingleLineExt<T>(this ProxyBase<T> proxyRef,ref object nlines, ref object xarr, ref object yarr) where T : ITextInterface
        {
            return proxyRef.Instance.GetTextExtentSingleLine(ref nlines, ref xarr, ref yarr);
        }

        public static int GetTypeIdExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetTypeId();
        }

        public static int GetVisibilityExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetVisibility();
        }

        public static double GetWidthExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.GetWidth();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : ITextInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsOfflineExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.IsOffline();
        }

        public static int IsRedlinedExt<T>(this ProxyBase<T> proxyRef) where T : ITextInterface
        {
            return proxyRef.Instance.IsRedlined();
        }

        public static int SetAlignmentExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetAlignment(newval);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : ITextInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetBallooningExt<T>(this ProxyBase<T> proxyRef,int onoff, int type) where T : ITextInterface
        {
            return proxyRef.Instance.SetBallooning(onoff, type);
        }

        public static int SetBoxExt<T>(this ProxyBase<T> proxyRef,double xsize, double ysize) where T : ITextInterface
        {
            return proxyRef.Instance.SetBox(xsize, ysize);
        }

        public static int SetColourExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetColour(newval);
        }

        public static int SetFontNameExt<T>(this ProxyBase<T> proxyRef,string newname) where T : ITextInterface
        {
            return proxyRef.Instance.SetFontName(newname);
        }

        public static int SetHeightExt<T>(this ProxyBase<T> proxyRef,double newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetHeight(newval);
        }

        public static int SetHyperlinkAddressExt<T>(this ProxyBase<T> proxyRef,string newtext) where T : ITextInterface
        {
            return proxyRef.Instance.SetHyperlinkAddress(newtext);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : ITextInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetLanguageIdExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetLanguageId(newval);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetLevel(newval);
        }

        public static int SetLockingExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetLocking(newval);
        }

        public static int SetModeExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetMode(newval);
        }

        public static int SetOptionExpressionsExt<T>(this ProxyBase<T> proxyRef,ref object expressions) where T : ITextInterface
        {
            return proxyRef.Instance.SetOptionExpressions(ref expressions);
        }

        public static double SetRotationExt<T>(this ProxyBase<T> proxyRef,double rotation) where T : ITextInterface
        {
            return proxyRef.Instance.SetRotation(rotation);
        }

        public static int SetSchemaLocationExt<T>(this ProxyBase<T> proxyRef,double x, double y) where T : ITextInterface
        {
            return proxyRef.Instance.SetSchemaLocation(x, y);
        }

        public static int SetSingleLineExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetSingleLine(newval);
        }

        public static int SetStyleExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetStyle(newval);
        }

        public static int SetTextExt<T>(this ProxyBase<T> proxyRef,string newtext) where T : ITextInterface
        {
            return proxyRef.Instance.SetText(newtext);
        }

        public static int SetVisibilityExt<T>(this ProxyBase<T> proxyRef,int newval) where T : ITextInterface
        {
            return proxyRef.Instance.SetVisibility(newval);
        }
    }
}