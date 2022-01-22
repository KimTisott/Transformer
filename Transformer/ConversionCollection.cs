using System.Collections;
using System.Collections.Concurrent;

namespace Transformer;

public class ConversionCollection<TSource> : IEnumerable<KeyValuePair<Type, IConversion>>
{
    readonly ConcurrentDictionary<Type, IConversion> _conversions;

    public ConversionCollection(Dictionary<Type, IConversion>? conversions = null)
        => _conversions = conversions != null ? new(conversions) : new();

    public bool Add<TDestination>(Func<TSource?, TDestination?> map)
        => _conversions.TryAdd(typeof(TDestination), new Conversion<TSource, TDestination>(map));

    public bool Remove<TDestination>()
        => _conversions.TryRemove(typeof(TDestination), out _);

    public bool Update<TDestination>(Func<TSource?, TDestination?> map)
        => Remove<TDestination>() && Add(map);

    public IConversion Get<TDestination>()
        => _conversions.TryGetValue(typeof(TDestination), out IConversion? conversion) ? conversion :
            throw new Exception($"Could not get {typeof(TSource).Name} -> {typeof(TDestination).Name} Conversion.");

    public IEnumerator<KeyValuePair<Type, IConversion>> GetEnumerator()
        => _conversions.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}