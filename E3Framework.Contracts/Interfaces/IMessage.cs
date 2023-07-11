namespace E3Framework.Contracts.Interfaces;

public interface IMessage
{
    public void RaiseMessage(string contents);

    public void RaiseMessage(string contents, IColor color);

    public void RaiseMessage(string contents, IMessageModel color);
}