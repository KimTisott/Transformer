namespace Transformer
{
    public class Converter<TSource>
    {
        public TDestination Convert<TDestination>(TSource source)
        {
            if (_conversions.TryGetValue(typeof(TDestination), out var converter))
                return (TDestination)converter(source);

            throw new KeyNotFoundException();
        }

        public void AddConversion<TDestination>(Func<TSource, object> conversion)
            => _conversions.Add(typeof(TDestination), conversion);

        readonly Dictionary<Type, Func<TSource, object>> _conversions = new();
    }
}