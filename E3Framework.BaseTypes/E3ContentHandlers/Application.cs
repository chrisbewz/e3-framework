using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Application : IMessage
{
    public void RaiseMessage(string contents)
    {
        throw new NotImplementedException();
    }

    public void RaiseMessage(string contents, IColor color)
    {
        throw new NotImplementedException();
    }

    public void RaiseMessage(string contents, IMessageModel color)
    {
        throw new NotImplementedException();
    }
}