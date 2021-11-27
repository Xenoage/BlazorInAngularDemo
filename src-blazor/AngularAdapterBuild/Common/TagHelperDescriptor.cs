// Copied from https://github.com/aspnet/samples/blob/716ddf3c9c769acce9ad9799ce5751b506c6f877/samples/aspnetcore/blazor/JSComponentGeneration/JSComponentGeneration.Build/Common/TagHelperDescriptor.cs
namespace AngularAdapterBuild.Common;

internal class TagHelperDescriptor {
    public string Kind { get; set; }
    public string Name { get; set; }
    public BoundAttributeDescriptor[] BoundAttributes { get; set; }
}
