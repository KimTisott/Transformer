using System;
using Transformer.Converters;
using Xunit;

namespace Transformer.Tests;

public class Custom
{
    [Fact]
    public void Init()
    {
        Person person = new("Kim", new(1999, 9, 1));

        var personConverter = new BaseConverter<Person>();

        personConverter.AddConversion<int>(x => x.Age);

        Assert.Equal(22, personConverter.To<int>(person));
    }

    class Person
    {
        public Person(string name, System.DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; }

        public DateTime Birthdate { get; }

        public int Age => DateTime.Now.Year - Birthdate.Year;
    }
}