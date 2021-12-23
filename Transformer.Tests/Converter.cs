using Xunit;

namespace Transformer.Tests
{
    public class Conversion
    {
        [Fact]
        public void Test1()
        {
            var myConverter = new Converter<bool>();

            myConverter.AddConversion<string>(x => x.ToString().ToLower());

            Assert.Equal("false", myConverter.Convert<string>(false));
            Assert.Equal("true", myConverter.Convert<string>(true));
        }
    }
}
