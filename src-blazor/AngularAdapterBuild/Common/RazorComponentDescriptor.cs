// Copied from https://github.com/aspnet/samples/blob/716ddf3c9c769acce9ad9799ce5751b506c6f877/samples/aspnetcore/blazor/JSComponentGeneration/JSComponentGeneration.Build/Common/RazorComponentDescriptor.cs
namespace AngularAdapterBuild.Common;

internal class RazorComponentDescriptor {
    public string Name { get; }

    public IReadOnlyList<BoundAttributeDescriptor> Parameters { get; }

    public RazorComponentDescriptor(TagHelperDescriptor tagHelper) {
        Name = GetComponentTypeName(tagHelper.Name);
        Parameters = tagHelper.BoundAttributes;
    }

    private static string GetComponentTypeName(string fullName)
        => fullName.Substring(fullName.LastIndexOf('.') + 1);
}

