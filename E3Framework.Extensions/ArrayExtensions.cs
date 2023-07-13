namespace E3Framework.Extensions;

public static class ForeignArrayExtensions
{
    /// <summary>
    /// Cast E3 COM wrapped internal object identifiers array to IEnumerable of arbitrary type
    /// </summary>
    /// <param name="obj">Current array packed from COM interface</param>
    /// <returns></returns>
    public static IEnumerable<T> Unpack<T>(this object obj)
    {
        if (obj == null)
            throw new ArgumentNullException($"The object {nameof(obj)} cannot be null.");

        if (!(obj is object[] array))
            throw new InvalidCastException($"Object of type {obj.GetType()} is not convertible to {typeof(object[]).Name}.");

        return array.Where(o => o != null).Cast<T>();
    }

    /// <summary>
    /// Cast E3 COM wrapped internal object identifiers array to IEnumerable
    /// </summary>
    /// <param name="obj">Current int array packed from COM interface</param>
    /// <returns></returns>
    public static IEnumerable<int> Unpack(this object obj)
    {
        return obj.Unpack<int>();
    }
}