namespace E3Framework.Contracts.Interfaces;

public interface IComponentBase<T> : IIdentifiable
{
    public T Instance { get; set; }
    
}

public interface IIdentifiable
{
    public abstract int Id { get; set; }
}