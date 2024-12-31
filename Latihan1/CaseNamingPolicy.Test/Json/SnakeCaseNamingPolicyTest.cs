using CaseNamingPolicy.Moduls.Json;
using FluentAssertions;

namespace CaseNamingPolicy.Test.Json
{
    public class SnakeCaseNamingPolicyTest
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("A", "a")]
        [InlineData("Aa", "aa")]
        [InlineData("AA", "a_a")]
        [InlineData("AAa", "a_aa")]
        [InlineData("AaA", "aa_a")]
        public void CanConvertPascalCaseToSnakeCase (string pascalCase, string expectedSnakeCase)
        {
            string snakeCase = new SnakeCaseNamingPolicy().ConvertName(pascalCase);

            snakeCase.Should().Be(expectedSnakeCase);
        }
    }
}
