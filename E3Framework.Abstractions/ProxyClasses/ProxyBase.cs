namespace E3Framework.Abstractions.ProxyClasses;

public interface ProxyBase<T>
{
    public T Instance { get; set; }
}