namespace E3Framework.Contracts.Interfaces;

public interface IComponentBase<T> : IComponentBase
{
    public T Instance { get; set; }
    
}

public interface IComponentBase
{
    public abstract int Id { get; set; }
}