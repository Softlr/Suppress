namespace Softlr.Tests
{
    using FluentAssertions;
    using JetBrains.Annotations;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Xunit;
    using static System.Reflection.BindingFlags;

    [ExcludeFromCodeCoverage]
    public class SuppressTests
    {
        [PublicAPI]
        public static IEnumerable<object[]> Constants
        {
            get
            {
                var constants = typeof(Suppress).GetFields(Public | Static | FlattenHierarchy).Where(x => x.IsLiteral)
                    .Where(x => !x.IsInitOnly);
                foreach (var constant in constants)
                {
                    yield return new[] { constant.Name, constant.GetValue(null) };
                }
            }
        }

        [Theory]
        [MemberData(nameof(Constants))]
        public void ShouldHaveTrimmedConstantValues(string name, string value) =>
            value.Should().NotStartWith(" ", $"{name} value starts with a space")
                .And.NotEndWith(" ", $"{name} value ends with a space");

        [Theory]
        [MemberData(nameof(Constants))]
        public void ShouldNotContainMultipleSpacesInARowInConstantValues(string name, string value) =>
            value.Should().NotContain("  ", $"{name} contains multiple spaces in a row");
    }
}
