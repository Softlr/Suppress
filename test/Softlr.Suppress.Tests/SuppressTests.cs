namespace Softlr.Tests
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using FluentAssertions;
    using JetBrains.Annotations;
    using Xunit;
    using static System.Reflection.BindingFlags;
    using static Softlr.Suppress;

    [ExcludeFromCodeCoverage]
    public class SuppressTests
    {
        [PublicAPI]
        public static TheoryData<string, string> Constants
        {
            get
            {
                var reservedName = new List<string>
                {
                    nameof(CODE_CRACKER),
                    nameof(SONARQUBE),
                    nameof(STYLECOP),
                    nameof(FXCOP)
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
        public void ShouldHaveTrimmedConstantValues(string name, string value) =>
            value.Should().NotStartWith(" ", $"{name} value starts with a space")
                .And.NotEndWith(" ", $"{name} value ends with a space");

        [Theory]
        [MemberData(nameof(Constants))]
        public void ShouldHaveValueStartingWithConstName(string name, string value) =>
            value.Should().StartWith($"{name}:", $"{name} dot not start with the proper text");

        [Theory]
        [MemberData(nameof(Constants))]
        public void ShouldNotContainMultipleSpacesInARowInConstantValues(string name, string value) =>
            value.Should().NotContain("  ", $"{name} contains multiple spaces in a row");
    }
}
