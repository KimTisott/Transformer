namespace Transformer;

public class Converter<TSource> : IConverter
{
    readonly ConversionCollection<TSource> _conversions;

    public Converter(IEnumerable<(Type destinationType, IConversion conversion)>? conversions)
        => _conversions = new ConversionCollection<TSource>(conversions?.ToDictionary(x => x.destinationType, x => x.conversion)) ?? new();

    public Converter(ConversionCollection<TSource>? conversions = null)
        => _conversions = conversions ?? new();

    public Converter<TSource> AddConversion<TDestination>(Func<TSource?, TDestination?> map)
        => _conversions.Add(map) ? this :
            throw new Exception($"Could not add {typeof(TSource).Name} -> {typeof(TDestination).Name} Conversion.");

    public bool RemoveConversion<TDestination>()
        => _conversions.Remove<TDestination>();

    public TDestination? To<TDestination>(object? sourceValue, TDestination? defaultValue = default)
        => (TDestination?)_conversions.Get<TDestination>().To(sourceValue, defaultValue);
}