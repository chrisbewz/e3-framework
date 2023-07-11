using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Dispatcher : IDIspatcherBase
{
    private object _activeInstance;

    public object ActiveInstance => _activeInstance;

    private Dispatcher(dynamic? instance)
    {
        _activeInstance = instance;
    }

    public static IDIspatcherBase FromInstance(dynamic? instance)
    {
        return new Dispatcher(instance);
    }
}