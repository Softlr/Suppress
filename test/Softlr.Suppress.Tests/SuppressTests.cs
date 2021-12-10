namespace Softlr.Tests;

[ExcludeFromCodeCoverage]
public class SuppressTests
{
    public static TheoryData<string, string> Constants
    {
        get
        {
            var reservedName = new List<string>
            {
                nameof(CODE_CRACKER),
                nameof(FXCOP),
                nameof(MICROSOFT_DESIGN),
                nameof(MICROSOFT_DOCUMENTATION),
                nameof(MICROSOFT_GLOBALIZATION),
                nameof(MICROSOFT_INTEROPERABILITY),
                nameof(MICROSOFT_MAINTAINABILITY),
                nameof(MICROSOFT_NAMING),
                nameof(MICROSOFT_PERFORMANCE),
                nameof(MICROSOFT_PUBLISH),
                nameof(MICROSOFT_RELIABILITY),
                nameof(MICROSOFT_SECURITY),
                nameof(MICROSOFT_USAGE),
                nameof(SONARQUBE),
                nameof(STYLECOP)
            };
            var constants = typeof(Suppress).GetFields(Public | Static | FlattenHierarchy).Where(x => x.IsLiteral)
                .Where(x => !x.IsInitOnly).Where(x => !reservedName.Contains(x.Name));
            var data = new TheoryData<string, string>();
            foreach (var constant in constants)
            {
                data.Add(constant.Name, (string)constant.GetValue(null));
            }

            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Constants))]
    public void Value_containing_multiple_spaces_in_a_row_is_invalid(string name, string value) =>
        value.Should().NotContain("  ", $"{name} contains multiple spaces in a row");

    [Theory]
    [MemberData(nameof(Constants))]
    public void Value_not_starting_with_const_name_and_colon_is_invalid(string name, string value) =>
        value.Should().StartWith($"{name}:", $"{name} dot not start with the proper text");

    [Theory]
    [MemberData(nameof(Constants))]
    public void Value_starting_with_a_space_is_invalid(string name, string value) =>
        value.Should().NotStartWith(" ", $"{name} value starts with a space")
            .And.NotEndWith(" ", $"{name} value ends with a space");
}
