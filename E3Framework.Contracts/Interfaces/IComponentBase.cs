namespace E3Framework.Contracts.Interfaces;

public interface IComponentBase<T>
{
    public T Instance { get; set; }

    public int Id { get; set; }
}