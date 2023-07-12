namespace E3Framework.Data.Events;

public class ReferenceRequirentAbstract : EventArgs
{
    public Type Type { get; }
    public ReferenceRequirentAbstract(Type refType)
    {
        this.Type = refType;
    }
}