# BlazorInAngularDemo

> ### A demo project for integrating Blazor components into an existing Angular app.

&nbsp;

## Motivation

Although Blazor is a great choice for creating web frontends, abolishing an existing Angular app and starting from scratch is often no option. This project demonstrates, how .NET 7+ Blazor components can be integrated in an existing Angular project, making it possible to migrate step by step.

## Implementation details

Here are the basic steps how we implemented the demo based on the original Angular project:

* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/3ae2ab6ea282bed4a849ec48baeae355b247ba23) We cloned the __[Tour of Heroes](https://angular.io/guide/example-apps-list#tour-of-heroes-completed-application)__ Angular demo application into the `/Angular` directory. We compiled and ran the Angular app to make sure everything was working so far: `npm install --legacy-peer-deps` and `npm start`.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/be5a677bba37b43dad24e6726cf9be4422b1d447) We created a simple .NET 7 __Blazor WebAssembly project__ in the `/Blazor` directory. For the beginning, just a runnable app with a simple counter component, displayed on a test page.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/f5faafa8dc6c0315e795950f46f7b29b4458c970) We created a `HeroEditor` component in Blazor, including a parameter and an event callback. Our goal is to replace the inner part of Angular's `HeroDetailComponent` later.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/05ff41343843b7807f8f15da4b44f722aac258e4) We exported the Blazor components as web components, by using the [Microsoft.AspNetCore.Components.CustomElements](https://www.nuget.org/packages/microsoft.aspnetcore.components.customelements) package, registering the elements as custom elements and running `dotnet publish`.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/f51cc799077804b2b9610dce41c770e27b0cff8c) We imported the compiled Blazor web components into the Angular project (see commit diff for all required steps) and replaced the app component by our Blazor counter component for a quick test. `npm start` now successfully serves the Blazor component in an Angular context.
* ... Work in progress.