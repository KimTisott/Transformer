using System.Collections;
using System.Collections.Concurrent;

namespace Transformer;

public class ConverterCollection : IEnumerable<KeyValuePair<Type, IConverter>>
{
    readonly ConcurrentDictionary<Type, IConverter> _converters = new();

    public Converter<TSource> Add<TSource>(Converter<TSource> converter)
        => (Converter<TSource>)_converters.GetOrAdd(typeof(TSource), converter);

    public bool Remove<TSource>()
        => _converters.TryRemove(typeof(TSource), out _);

    public IConverter Get(Type sourceType)
        => _converters.TryGetValue(sourceType, out var converter) ? converter :
            throw new Exception($"Could not get {sourceType.Name} Converter.");

    public IEnumerator<KeyValuePair<Type, IConverter>> GetEnumerator()
        => _converters.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}