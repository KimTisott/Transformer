namespace Transformer.Converters;

public class BooleanConverter : BaseConverter<bool>
{
    public BooleanConverter()
    {
        AddConversion<byte>(x => (byte)(x ? 1 : 0));
        AddConversion<sbyte>(x => (sbyte)(x ? 1 : 0));
        AddConversion<char>(x => x ? 't' : 'f');
        AddConversion<decimal>(x => (decimal)(x ? 1 : 0));
        AddConversion<double>(x => (double)(x ? 1 : 0));
        AddConversion<float>(x => (float)(x ? 1 : 0));
        AddConversion<int>(x => x ? 1 : 0);
        AddConversion<uint>(x => (uint)(x ? 1 : 0));
        AddConversion<nint>(x => (nint)(x ? 1 : 0));
        AddConversion<nuint>(x => (nuint)(x ? 1 : 0));
        AddConversion<long>(x => (long)(x ? 1 : 0));
        AddConversion<ulong>(x => (ulong)(x ? 1 : 0));
        AddConversion<short>(x => (short)(x ? 1 : 0));
        AddConversion<ushort>(x => (ushort)(x ? 1 : 0));
    }
}