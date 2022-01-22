namespace Transformer;

public interface IConversion
{
    object? To(object? sourceValue, object? defaultValue);
}