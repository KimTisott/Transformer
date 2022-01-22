namespace Transformer;

public class Conversion<TSource, TDestination> : IConversion
{
    Func<TSource?, TDestination?> Map { get; }

    public Conversion(Func<TSource?, TDestination?> map)
        => Map = map ?? throw new ArgumentNullException(nameof(map));

    public object? To(object? sourceValue, object? defaultValue = default)
        => Map != null ? Map((TSource?)sourceValue) : defaultValue;
}