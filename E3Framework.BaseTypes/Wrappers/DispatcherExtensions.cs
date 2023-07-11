using System.ComponentModel;
using System.Runtime.InteropServices;
using E3Framework.BaseTypes.E3ContentHandlers;
using E3Framework.Contracts.Enumerations;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Wrappers;

public static class DispatcherExtensions
{
    public static IDIspatcherBase CreateDispatcherWithInstance()
    {
        dynamic? currentApp = null;
        try
        {
            var currentObjects = RotWrapper.GetRunningE3Objects(E3InstanceKind.E3);

            // WindowsBindings.GetWindowThreadProcessId(WindowsBindings.GetForegroundWindow(), out var pId);

            currentApp = currentObjects.Any()
                ? currentObjects.Select(kv => kv.Value).FirstOrDefault() as object
                : null;

            if (currentApp is null) return CreateDIspatcherFromStaticInstance();
        }
        catch (Win32Exception winEx)
        {
        }
        catch (COMException comEx)
        {
        }
        catch (NullReferenceException nullEx)
        {
        }

        return Dispatcher.FromInstance(((dynamic)currentApp!)!);
    }

    public static IDIspatcherBase CreateDIspatcherFromStaticInstance()
    {
        var rot = new RotWrapper();
        var hndw = rot.GetObject(RotWrapper.E3_APP_MONIKER + ':');
        return Dispatcher.FromInstance(hndw);
    }
}