namespace E3Framework.Contracts.Interfaces;

public interface IReferenceRecipient
{
    event ReferenceHandler.ReferenceRequestedHandler ReferenceRequested;
}

public abstract class ReferenceHandler
{
    public delegate void ReferenceRequestedHandler(object sender, Type t);
}