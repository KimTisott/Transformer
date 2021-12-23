using System.Collections.Generic;
using Transformer.Converters;
using Xunit;

namespace Transformer.Tests;

public class Boolean
{
    [Fact]
    public void Defaults()
    {
        var booleanConverter = new BooleanConverter();

        Assert.Equal(0, booleanConverter.To<byte>(false));
        Assert.Equal(1, booleanConverter.To<byte>(true));

        Assert.Equal(0, booleanConverter.To<sbyte>(false));
        Assert.Equal(1, booleanConverter.To<sbyte>(true));

        Assert.Equal('f', booleanConverter.To<char>(false));
        Assert.Equal('t', booleanConverter.To<char>(true));

        Assert.Equal(0, booleanConverter.To<decimal>(false));
        Assert.Equal(1, booleanConverter.To<decimal>(true));

        Assert.Equal(0, booleanConverter.To<double>(false));
        Assert.Equal(1, booleanConverter.To<double>(true));

        Assert.Equal(0, booleanConverter.To<float>(false));
        Assert.Equal(1, booleanConverter.To<float>(true));

        Assert.Equal(0, booleanConverter.To<int>(false));
        Assert.Equal(1, booleanConverter.To<int>(true));

        Assert.Equal((uint)0, booleanConverter.To<uint>(false));
        Assert.Equal((uint)1, booleanConverter.To<uint>(true));

        Assert.Equal(0, booleanConverter.To<nint>(false));
        Assert.Equal(1, booleanConverter.To<nint>(true));

        Assert.Equal((nuint)0, booleanConverter.To<nuint>(false));
        Assert.Equal((nuint)1, booleanConverter.To<nuint>(true));

        Assert.Equal(0, booleanConverter.To<long>(false));
        Assert.Equal(1, booleanConverter.To<long>(true));

        Assert.Equal((ulong)0, booleanConverter.To<ulong>(false));
        Assert.Equal((ulong)1, booleanConverter.To<ulong>(true));

        Assert.Equal(0, booleanConverter.To<short>(false));
        Assert.Equal(1, booleanConverter.To<short>(true));

        Assert.Equal(0, booleanConverter.To<ushort>(false));
        Assert.Equal(1, booleanConverter.To<ushort>(true));
    }

    [Fact]
    public void Conversion()
    {
        var booleanConverter = new BooleanConverter();

        booleanConverter.RemoveConversion<char>();

        Assert.Throws<KeyNotFoundException>(() => booleanConverter.To<char>(false));

        booleanConverter.AddConversion<char>(x => x ? 'c' : 'i');

        Assert.Equal('c', booleanConverter.To<char>(true));
    }
}