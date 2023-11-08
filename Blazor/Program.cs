using BlazorComponents;
using BlazorComponents.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register our components as a custom elements
builder.RootComponents.RegisterCustomElement<Counter>("blazor-counter");
builder.RootComponents.RegisterCustomElement<HeroEditor>("blazor-heroeditor");

await builder.Build().RunAsync();
