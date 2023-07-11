using System.Runtime.InteropServices;

namespace E3Framework.Contracts.Interfaces;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00000001-0000-0000-C000-000000000046")]
public interface IClassFactory
{
    [PreserveSig]
    int CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject);
}