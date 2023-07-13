namespace E3Framework.Contracts.Interfaces;

public interface IProxyBase<T> : IDisposable
{
    T Instance { get; set; }
}