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
        [InlineData("AaALKJHGFDSDFGHJoiuytreertyuiomn098765434567890", "aa_a_l_k_j_h_g_f_d_s_d_f_g_h_joiuytreertyuiomn098765434567890")]
        public void CanConvertPascalCaseToSnakeCase (string pascalCase, string expectedSnakeCase)
        {
            string snakeCase = new SnakeCaseNamingPolicy().ConvertName(pascalCase);

            snakeCase.Should().Be(expectedSnakeCase);
        }
    }
}
