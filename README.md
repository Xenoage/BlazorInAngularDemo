# BlazorInAngularDemo

> ### A demo project for integrating Blazor components into an existing Angular app.

&nbsp;

## Motivation

Although Blazor is a great choice for creating web frontends, abolishing an existing Angular app and starting from scratch is often no option. This project demonstrates, how .NET 7+ Blazor components can be integrated in an existing Angular project, making it possible to migrate step by step.

## Implementation details

Here are the basic steps how we implemented the demo based on the original Angular project:

* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/3ae2ab6ea282bed4a849ec48baeae355b247ba23) We cloned the [__Tour of Heroes__](https://angular.io/guide/example-apps-list#tour-of-heroes-completed-application) demo application from the angular.io docs. In our case, we cloned the [Angular RealWorld example app](https://github.com/gothinkster/angular-realworld-example-app). We compiled and ran the Angular app to make sure everything was working so far.
* We added a new directory `src-blazor`. Of course this directory could be anywhere and does not have to be a subdirectory of the Angular project.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/1c2c877edceb2904f40e0de21f487cadc35c33b7) We created a __Blazor .NET WebAssembly project__ in this directory. For the beginning just a runnable app with a simple counter component.
* For the demo, we wanted to replace the Angular component `ArticleCommentComponent` by a __Blazor component__.
  * [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/54bc52ad14b50ac5311d9cd96ffd77bdce507f1c) The required model classes are `Comment` and `Profile`. We ported them to C# records.
  * [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/d0f46c90699ac3157cbd2f50fa2caefe255e36fb) We created the `ArticleComment` component in Blazor. For the moment, we just implemented the HTML and parameters, not the logic like the Angular service. For correct appearance of the component, we included the external CSS content from the Angular project into the Blazor `index.html`.
  * [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/06d909665cd5c53bd158243326352b1098232229) For trying out the component in a pure Blazor context (multiple instances of the component on one page, routing to a different page), we created a minimal Blazor routing environment with pages.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/a7dce544015fb6c3733b4fddbdf5e9a8ef16c4dd) For building an __Angular component from our Blazor component__, we added a class library project `AngularAdapterBuild` to our C# solution. It is very much based on the [JavaScript component generation sample](https://github.com/aspnet/samples/commit/be8ebb6a4ed1eec2f18aa50c230800a491427882) from the ASP.NET Core samples with two important fixes: Updating all libraries to latest version, and calling `RegisterForJavaScript` method with the `javaScriptInitializer` parameter, see open [issue #38044](https://github.com/dotnet/aspnetcore/issues/38044).
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/4c4ef91671e56210d4ece884f974392dbddaded5) For loading the Blazor binaries into our Angular app, we created a folder `bin-blazor` into which the `BlazorComponents.csproj` buildfile publishes the Blazor runtime (`_framework` folder) and the `BlazorComponents.styles.css` styles. In `angular.json`, we defined both artifacts as assets to include them in the built Angular app. In the `src/index.html` of the Angular app, we loaded the CSS file and initialized Blazor.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/44287ab43b28b2a3b494a98312465c89d0c468e2) Now we could use the Blazor component in the Angular app. We imported it in a module and used the original Angular component and our new Blazor component side by side for comparison.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/6eaa7d4208e1d5e8216db9134e36794d66862043) We added __event handling__ both in the Blazor test environment and the Blazor app; added an additional event for testing.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/c451143dca002114fa79ce85d2e218d07143fcf2) Since we had to call a method from an __Angular service__ (a method from the `UserService` in our example), we exposed this method to the `window` object and called it in our Blazor code. We added a `blazor-bridge.service.ts` service to collect all required Angular service methods there.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/2824ce058b7ee2aaf7023f4902c9373cee5fb3df) To clean up the Blazor code, we created an `IAppService.cs` service interface for the required Angular service methods with two implementations: `TestAppService.cs` for the Blazor test environment, `AngularAppService.cs` for the real Angular environment using JS interop calls.
* [[Commit]](https://github.com/Xenoage/BlazorInAngularDemo/commit/be21c04eff128abff935d8688f301729c31d60e3) We added integration for github CI/CD with deployment to github pages for creating a live demo automatically.

## Thank you

This demo project is based on the [Angular RealWorld example app](https://github.com/gothinkster/angular-realworld-example-app) by 
[Thinkster](https://thinkster.io). Thank you very much for the useful template.

