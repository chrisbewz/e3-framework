using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using E3Framework.Contracts.Enumerations;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Wrappers;

public partial class RotWrapper : IDisposable
{
    internal const string E3_APP_MONIKER = "E3APPLICATION";
    private IRunningObjectTable _rot;

    public static Dictionary<string, dynamic> GetRunningE3Objects(E3InstanceKind type)
    {
        Dictionary<string, dynamic> e3Objects = new();


        IBindCtx bindContext = null;

        IRunningObjectTable rot = null;

        WindowsBindings.GetRunningObjectTable(0, out rot);

        if (rot == null)

            return e3Objects;

        WindowsBindings.CreateBindCtx(0, out bindContext);

        if (bindContext == null)

            return e3Objects;

        IEnumMoniker monikerEnumerator = null;

        rot.EnumRunning(out monikerEnumerator);

        if (monikerEnumerator == null)

            return e3Objects;

        monikerEnumerator.Reset();

        var pNumFetched = new IntPtr();

        IMoniker[] monikers = new IMoniker[1];

        while (monikerEnumerator.Next(1, monikers, pNumFetched) == 0)

        {
            object obj = null;

            rot.GetObject(monikers[0], out obj);

            if (obj == null)

                continue;

            string displayName = null;

            monikers[0].GetDisplayName(bindContext, null, out displayName);

            if (displayName == null)

                continue;

            var classFactory = obj as IClassFactory;

            if (type.HasFlag(E3InstanceKind.DBE) && classFactory != null && displayName.ToUpper().StartsWith("!" + "E3DBEAPPLICATIONFACTORY" + ":"))

            {
                IntPtr appObject;

                var guidIUnknown = new Guid("00000000-0000-0000-C000-000000000046");

                var result = classFactory.CreateInstance(IntPtr.Zero, ref guidIUnknown, out appObject);

                if (appObject != null) e3Objects[displayName] = Marshal.GetObjectForIUnknown(appObject);
            }

            else if (type.HasFlag(E3InstanceKind.E3) && displayName.ToUpper().StartsWith("!" + "E3APPLICATION" + ":"))

            {
                e3Objects[displayName] = obj;
            }
        }

        return e3Objects;
    }
}