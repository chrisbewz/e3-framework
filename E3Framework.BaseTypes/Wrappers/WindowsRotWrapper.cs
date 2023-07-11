using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace E3Framework.BaseTypes.Wrappers;

public partial class RotWrapper
{
    private readonly IRunningObjectTable rot;
    private bool isDisposed = false;

    public RotWrapper()
    {
        Ole32.GetRunningObjectTable(0, out rot);
    }

    public void Dispose()
    {
        if (isDisposed) return;

        Marshal.ReleaseComObject(rot);
        isDisposed = true;
    }

    /// <summary>
    /// Attempts to register an item in the ROT.
    /// </summary>
    public IDisposable Register(string itemName, object obj)
    {
        var moniker = CreateMoniker(itemName);

        const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 1;
        var regCookie = rot.Register(ROTFLAGS_REGISTRATIONKEEPSALIVE, obj, moniker);

        return new RevokeRegistration(this, regCookie);
    }

    /// <summary>
    /// Attempts to retrieve an item from the ROT.
    /// </summary>
    public object GetObject(string itemName)
    {
        var mk = CreateMoniker(itemName);
        var hr = rot.GetObject(mk, out var obj);
        if (hr != 0) Marshal.ThrowExceptionForHR(hr);

        return obj;
    }

    private void Revoke(int regCookie)
    {
        rot.Revoke(regCookie);
    }

    private static IMoniker CreateMoniker(string itemName)
    {
        Ole32.CreateItemMoniker("!", itemName, out var mk);
        return mk;
    }

    private class RevokeRegistration : IDisposable
    {
        private readonly RotWrapper rot;
        private readonly int regCookie;

        public RevokeRegistration(RotWrapper rot, int regCookie)
        {
            this.rot = rot;
            this.regCookie = regCookie;
        }

        public void Dispose()
        {
            rot.Revoke(regCookie);
        }
    }

    private static class Ole32
    {
        [DllImport(nameof(Ole32))]
        public static extern void CreateItemMoniker(
            [MarshalAs(UnmanagedType.LPWStr)] string lpszDelim,
            [MarshalAs(UnmanagedType.LPWStr)] string lpszItem,
            out IMoniker ppmk);

        [DllImport(nameof(Ole32))]
        public static extern void GetRunningObjectTable(
            int reserved,
            out IRunningObjectTable pprot);
    }
}