using AngularAdapterBuild;
using BlazorComponents.Components;
using BlazorComponents.Test;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

/* // Use the following line when testing the pure Blazor environment:
builder.RootComponents.Add<TestApp>("#app");
/*/ // Use the following line for when using the component within Angular:
builder.RootComponents.RegisterForAngular<BlazorArticleComment>();
//*/

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
