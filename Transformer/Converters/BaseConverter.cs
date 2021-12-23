namespace Transformer;

public class BaseConverter<TSource>
{
    public TDestination To<TDestination>(TSource source)
    {
        if (_conversions.TryGetValue(typeof(TDestination), out var converter))
            return (TDestination)converter(source);

        throw new KeyNotFoundException();
    }

    public bool AddConversion<TDestination>(Func<TSource, object> conversion)
        => _conversions.TryAdd(typeof(TDestination), conversion);

    public bool RemoveConversion<TDestination>()
        => _conversions.Remove(typeof(TDestination));

    readonly Dictionary<Type, Func<TSource, object>> _conversions = new();
}