using Xunit;

namespace Transformer.Tests
{
    public class DefaultConverters
    {
        [Fact]
        public void Bool()
        {
            Assert.Equal((byte   )0  , TypeConverter.To<byte   >(false));
            Assert.Equal((byte   )1  , TypeConverter.To<byte   >(true ));
            Assert.Equal((sbyte  )0  , TypeConverter.To<sbyte  >(false));
            Assert.Equal((sbyte  )1  , TypeConverter.To<sbyte  >(true ));
            Assert.Equal((char   )'0', TypeConverter.To<char   >(false));
            Assert.Equal((char   )'1', TypeConverter.To<char   >(true ));
            Assert.Equal((decimal)0M , TypeConverter.To<decimal>(false));
            Assert.Equal((decimal)1M , TypeConverter.To<decimal>(true ));
            Assert.Equal((double )0D , TypeConverter.To<double >(false));
            Assert.Equal((double )1D , TypeConverter.To<double >(true ));
            Assert.Equal((float  )0F , TypeConverter.To<float  >(false));
            Assert.Equal((float  )1F , TypeConverter.To<float  >(true ));
            Assert.Equal((int    )0  , TypeConverter.To<int    >(false));
            Assert.Equal((int    )1  , TypeConverter.To<int    >(true ));
            Assert.Equal((uint   )0  , TypeConverter.To<uint   >(false));
            Assert.Equal((uint   )1  , TypeConverter.To<uint   >(true ));
            Assert.Equal((nint   )0  , TypeConverter.To<nint   >(false));
            Assert.Equal((nint   )1  , TypeConverter.To<nint   >(true ));
            Assert.Equal((nuint  )0  , TypeConverter.To<nuint  >(false));
            Assert.Equal((nuint  )1  , TypeConverter.To<nuint  >(true ));
            Assert.Equal((long   )0L , TypeConverter.To<long   >(false));
            Assert.Equal((long   )1L , TypeConverter.To<long   >(true ));
            Assert.Equal((ulong  )0L , TypeConverter.To<ulong  >(false));
            Assert.Equal((ulong  )1L , TypeConverter.To<ulong  >(true ));
            Assert.Equal((short  )0  , TypeConverter.To<short  >(false));
            Assert.Equal((short  )1  , TypeConverter.To<short  >(true ));
            Assert.Equal((ushort )0  , TypeConverter.To<ushort >(false));
            Assert.Equal((ushort )1  , TypeConverter.To<ushort >(true ));
            Assert.Equal((object )0  , TypeConverter.To<object >(false));
            Assert.Equal((object )1  , TypeConverter.To<object >(true ));
            Assert.Equal((string )"0", TypeConverter.To<string >(false));
            Assert.Equal((string )"1", TypeConverter.To<string >(true ));
            Assert.Equal((dynamic)0  , TypeConverter.To<dynamic>(false));
            Assert.Equal((dynamic)1  , TypeConverter.To<dynamic>(true ));
        }
    }
}