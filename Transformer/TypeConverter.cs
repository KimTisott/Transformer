namespace Transformer;

public static class TypeConverter
{
    readonly static ConverterCollection _converters = new();

    static TypeConverter()
    {
        AddDefaultConverters();
    }

    public static TDestination? To<TDestination>(object sourceValue, TDestination? defaultValue = default)
        => _converters.Get(sourceValue.GetType()).To(sourceValue, defaultValue);

    public static Converter<TSource> AddConverter<TSource>()
        => _converters.Add<TSource>(new());

    public static bool RemoveConverter<TSource>()
        => _converters.Remove<TSource>();

    static void AddDefaultConverters()
    {
        AddConverter<bool>()
            .AddConversion(x => (byte   )(x ? 1   : 0  ))
            .AddConversion(x => (sbyte  )(x ? 1   : 0  ))
            .AddConversion(x => (char   )(x ? '1' : '0'))
            .AddConversion(x => (decimal)(x ? 1M  : 0M ))
            .AddConversion(x => (double )(x ? 1D  : 0D ))
            .AddConversion(x => (float  )(x ? 1F  : 0F ))
            .AddConversion(x => (int    )(x ? 1   : 0  ))
            .AddConversion(x => (uint   )(x ? 1   : 0  ))
            .AddConversion(x => (nint   )(x ? 1   : 0  ))
            .AddConversion(x => (nuint  )(x ? 1   : 0  ))
            .AddConversion(x => (long   )(x ? 1L  : 0L ))
            .AddConversion(x => (ulong  )(x ? 1L  : 0L ))
            .AddConversion(x => (short  )(x ? 1   : 0  ))
            .AddConversion(x => (ushort )(x ? 1   : 0  ))
            .AddConversion(x => (string )(x ? "1" : "0"))
            .AddConversion(x => (dynamic)(x ? 1   : 0  ));

        AddConverter<byte>()
            .AddConversion(x => (bool   )(x == 1           ))
            .AddConversion(x => (sbyte  )(x                ))
            .AddConversion(x => (char   )(Convert.ToChar(x)))
            .AddConversion(x => (decimal)(x                ))
            .AddConversion(x => (double )(x                ))
            .AddConversion(x => (float  )(x                ))
            .AddConversion(x => (int    )(x                ))
            .AddConversion(x => (uint   )(x                ))
            .AddConversion(x => (nint   )(x                ))
            .AddConversion(x => (nuint  )(x                ))
            .AddConversion(x => (long   )(x                ))
            .AddConversion(x => (ulong  )(x                ))
            .AddConversion(x => (short  )(x                ))
            .AddConversion(x => (ushort )(x                ))
            .AddConversion(x => (string )(x.ToString()     ))
            .AddConversion(x => (dynamic)(x                ));
    }
}