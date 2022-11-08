using Xunit;
using FluentAssertions;

namespace MyCSharpTypesExercise.Test;

public class UnitTest1
{
    [Fact]
    public void TestVariableCreation()
    {
        Class1 instance = new();

        var response = instance.someString is string;
        response.Should().Be(true);
    }
}
