using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

public class RotObjectWrapper
{
    [Flags]
    public enum e3Type
    {
        E3 = 1,
        DBE = 2
    }
    
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00000001-0000-0000-C000-000000000046")]
    private interface IClassFactory
    {
        [PreserveSig]
        int CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject);
    }
    
    [DllImport("Ole32.dll")]
    public static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);
    
    [DllImport("Ole32.dll")]
    public static extern int CreateBindCtx(uint reserved, out IBindCtx ppbc);
    
    public Dictionary<string, dynamic> GetRunningE3Instances(e3Type type)
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        IBindCtx ppbc = null;
        IRunningObjectTable prot = null;
        GetRunningObjectTable(0, out prot);
        if (prot == null)
        {
            return dictionary;
        }
        CreateBindCtx(0u, out ppbc);
        if (ppbc == null)
        {
            return dictionary;
        }
        IEnumMoniker ppenumMoniker = null;
        prot.EnumRunning(out ppenumMoniker);
        if (ppenumMoniker == null)
        {
            return dictionary;
        }
        ppenumMoniker.Reset();
        IntPtr pceltFetched = default(IntPtr);
        IMoniker[] array = new IMoniker[1];
        while (ppenumMoniker.Next(1, array, pceltFetched) == 0)
        {
            object ppunkObject = null;
            prot.GetObject(array[0], out ppunkObject);
            if (ppunkObject == null)
            {
                continue;
            }
            string ppszDisplayName = null;
            array[0].GetDisplayName(ppbc, null, out ppszDisplayName);
            if (ppszDisplayName != null)
            {
                IClassFactory classFactory = ppunkObject as IClassFactory;
                if (type.HasFlag(e3Type.DBE) && classFactory != null && ppszDisplayName.ToUpper().StartsWith("!E3DBEAPPLICATIONFACTORY:"))
                {
                    Guid riid = new Guid("00000000-0000-0000-C000-000000000046");
                    classFactory.CreateInstance(IntPtr.Zero, ref riid, out var ppvObject);
                    dictionary[ppszDisplayName] = Marshal.GetObjectForIUnknown(ppvObject);
                }
                else if (type.HasFlag(e3Type.E3) && ppszDisplayName.ToUpper().StartsWith("!E3APPLICATION:"))
                {
                    dictionary[ppszDisplayName] = ppunkObject;
                }
            }
        }
        return dictionary;
    }
}
