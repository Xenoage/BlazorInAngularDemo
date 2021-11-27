using AngularAdapterBuild;
using BlazorComponents;
using BlazorComponents.Components;
using BlazorComponents.Test;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

if (Settings.isTestEnvironment) {
    // Testing within the pure Blazor environment (just like a normal Blazor WebAssembly app)
    builder.RootComponents.Add<TestApp>("#app");
} else {
    // Register the component for usage in Angular app
    builder.RootComponents.RegisterForAngular<BlazorArticleComment>();
}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
