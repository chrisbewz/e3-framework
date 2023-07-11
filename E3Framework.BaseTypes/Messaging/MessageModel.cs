using E3Framework.Contracts.Enumerations;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Messaging;

public class MessageModel : IMessageModel
{
    private string _content;

    private MessageKind _kind;

    private MessageAwaiter _flag;

    public MessageModel(string content, MessageKind kind, MessageAwaiter flag)
    {
        _content = content;
        _kind = kind;
        _flag = flag;
    }

    public MessageKind Kind => _kind;

    public MessageAwaiter Flag => _flag;

    public string Contents => _content;
}