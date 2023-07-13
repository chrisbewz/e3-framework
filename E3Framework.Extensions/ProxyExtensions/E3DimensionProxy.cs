using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3DimensionProxy
    {

        public static int AddAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IDimensionInterface
        {
            return proxyRef.Instance.AddAttributeValue(name, value);
        }

        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int shtId, double x1, double y1, double x2, double y2, int flags, double distance, string text, double tx,
            double ty) where T : IDimensionInterface
        {
            return proxyRef.Instance.Create(shtId, x1, y1, x2, y2, flags, distance, text, tx, ty);
        }

        public static int CreateExExt<T>(this ProxyBase<T> proxyRef,int dimtyp, int sheet, ref object x, ref object y, int flags = 0) where T : IDimensionInterface
        {
            return proxyRef.Instance.CreateEx(dimtyp, sheet, ref x, ref y, flags);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int DeleteAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDimensionInterface
        {
            return proxyRef.Instance.DeleteAttribute(name);
        }

        public static int GetArrowModeExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetArrowMode();
        }

        public static int GetAttributeCountExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetAttributeCount();
        }

        public static int GetAttributeIdsExt<T>(this ProxyBase<T> proxyRef,ref object ids, string attnam = null) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetAttributeIds(ref ids, attnam);
        }

        public static string GetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetAttributeValue(name);
        }

        public static int GetColourExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetColour();
        }

        public static int GetDimensionedIdsExt<T>(this ProxyBase<T> proxyRef,ref object anyids) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetDimensionedIds(ref anyids);
        }

        public static string GetDisplayAttributeExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetDisplayAttribute();
        }

        public static double GetExtensionExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetExtension();
        }

        public static double GetExtensionLineOffsetExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetExtensionLineOffset();
        }

        public static int GetHideLongerPartExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetHideLongerPart();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static int GetLevelExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetLevel();
        }

        public static double GetLineWidthExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetLineWidth();
        }

        public static double GetOffsetExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetOffset();
        }

        public static int GetParametersExt<T>(this ProxyBase<T> proxyRef,out object x1, out object y1, out object x2, out object y2, out object distance, out object flags,
            out object text, out object tx, out object ty) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetParameters(out x1, out y1, out x2, out y2, out distance, out flags, out text, out tx, out ty);
        }

        public static int GetPartIdsExt<T>(this ProxyBase<T> proxyRef,out object ids) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetPartIds(out ids);
        }

        public static int GetPrecisionExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetPrecision();
        }

        public static string GetPrefixExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetPrefix();
        }

        public static int GetRunningDimTextRotationExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetRunningDimTextRotation();
        }

        public static string GetSuffixExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetSuffix();
        }

        public static double GetSuffixSizeFactorExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetSuffixSizeFactor();
        }

        public static int GetTextExt<T>(this ProxyBase<T> proxyRef,out object text, out object @fixed) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetText(out text, out @fixed);
        }

        public static int GetTextColourExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetTextColour();
        }

        public static string GetTextFontNameExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetTextFontName();
        }

        public static double GetTextHeightExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetTextHeight();
        }

        public static int GetTextStyleExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.GetTextStyle();
        }

        public static int HasAttributeExt<T>(this ProxyBase<T> proxyRef,string name) where T : IDimensionInterface
        {
            return proxyRef.Instance.HasAttribute(name);
        }

        public static int IsAlongPathExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.IsAlongPath();
        }

        public static int IsPartOfDimensionExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.IsPartOfDimension();
        }

        public static int IsRunningDimensionExt<T>(this ProxyBase<T> proxyRef) where T : IDimensionInterface
        {
            return proxyRef.Instance.IsRunningDimension();
        }

        public static int SetArrowModeExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetArrowMode(value);
        }

        public static int SetAttributeValueExt<T>(this ProxyBase<T> proxyRef,string name, string value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetAttributeValue(name, value);
        }

        public static int SetColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetColour(value);
        }

        public static int SetDisplayAttributeExt<T>(this ProxyBase<T> proxyRef,string attnam) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetDisplayAttribute(attnam);
        }

        public static double SetExtensionExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetExtension(value);
        }

        public static double SetExtensionLineOffsetExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetExtensionLineOffset(value);
        }

        public static int SetHideLongerPartExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetHideLongerPart(value);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetLevelExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetLevel(value);
        }

        public static double SetLineWidthExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetLineWidth(value);
        }

        public static double SetOffsetExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetOffset(value);
        }

        public static int SetPrecisionExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetPrecision(value);
        }

        public static string SetPrefixExt<T>(this ProxyBase<T> proxyRef,string value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetPrefix(value);
        }

        public static int SetRunningDimTextRotationExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetRunningDimTextRotation(value);
        }

        public static string SetSuffixExt<T>(this ProxyBase<T> proxyRef,string value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetSuffix(value);
        }

        public static double SetSuffixSizeFactorExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetSuffixSizeFactor(value);
        }

        public static int SetTextExt<T>(this ProxyBase<T> proxyRef,string text, int @fixed) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetText(text, @fixed);
        }

        public static int SetTextColourExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetTextColour(value);
        }

        public static string SetTextFontNameExt<T>(this ProxyBase<T> proxyRef,string text) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetTextFontName(text);
        }

        public static double SetTextHeightExt<T>(this ProxyBase<T> proxyRef,double value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetTextHeight(value);
        }

        public static int SetTextStyleExt<T>(this ProxyBase<T> proxyRef,int value) where T : IDimensionInterface
        {
            return proxyRef.Instance.SetTextStyle(value);
        }

    }
}