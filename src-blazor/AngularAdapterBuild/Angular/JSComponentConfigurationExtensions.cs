// Copied from https://github.com/aspnet/samples/blob/716ddf3c9c769acce9ad9799ce5751b506c6f877/samples/aspnetcore/blazor/JSComponentGeneration/JSComponentGeneration/Angular/JSComponentConfigurationExtensions.cs
using AngularAdapterBuild.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace AngularAdapterBuild;

public static class JSComponentConfigurationExtensions {
    public static void RegisterForAngular<TComponent>(this IJSComponentConfiguration configuration) where TComponent : IComponent {
        var typeNameKebabCase = typeof(TComponent).Name.ToKebabCase();
        configuration.RegisterForJavaScript<TComponent>($"{typeNameKebabCase}-angular", javaScriptInitializer: "initApp"); // TODO: see open Issue https://github.com/dotnet/aspnetcore/issues/38044
    }
}
