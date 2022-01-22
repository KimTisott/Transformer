namespace Transformer;

public interface IConverter
{
    TDestination? To<TDestination>(object? sourceValue, TDestination? defaultValue);
}