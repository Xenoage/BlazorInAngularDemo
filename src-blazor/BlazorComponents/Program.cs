using AngularAdapterBuild;
using BlazorComponents;
using BlazorComponents.Components;
using BlazorComponents.Services;
using BlazorComponents.Test;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

if (Settings.isTestEnvironment) {
    // Testing within the pure Blazor environment (just like a normal Blazor WebAssembly app)
    builder.Services.AddSingleton<IAppService, TestAppService>();
    builder.RootComponents.Add<TestApp>("#app");
    
} else {
    // Register the services and components for usage in Angular app
    builder.Services.AddSingleton<IAppService, AngularAppService>();
    builder.RootComponents.RegisterForAngular<BlazorArticleComment>();
}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
