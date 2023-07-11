using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace E3Framework.BaseTypes.Wrappers;

public static class WindowsBindings
{
    [DllImport("ole32.dll")]
    public static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    [DllImport("Ole32.dll")]
    public static extern int CreateBindCtx(uint reserved, out IBindCtx ppbc);

    [DllImport("Ole32.dll")]
    public static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);
}