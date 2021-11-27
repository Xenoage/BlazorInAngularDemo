// Copied from https://github.com/aspnet/samples/blob/716ddf3c9c769acce9ad9799ce5751b506c6f877/samples/aspnetcore/blazor/JSComponentGeneration/JSComponentGeneration.Shared/CasingUtilities.cs
using System.Text.RegularExpressions;

namespace AngularAdapterBuild.Common;

public static class StringUtils {

    /// <summary>
    /// Converts the given string in PascalCaseFormat into camelCaseFormat.
    /// </summary>
    public static string PascalToCamelCase(this string s)
        => s.Length > 0 ? char.ToLowerInvariant(s[0]) + s.Substring(1) : "";

    /// <summary>
    /// Converts the given string in camelCaseFormat or PascalCaseFormat into kebab-case-format.
    /// </summary>
    public static string ToKebabCase(this string s)
        => Regex.Replace(s, "[A-Z]+(?![a-z])|[A-Z]",
            match => (match.Index > 0 ? "-" : "") + match.Value.ToLowerInvariant());

}
