[![RealWorld Frontend](https://img.shields.io/badge/realworld-frontend-%23783578.svg)](http://realworld.io)

# ![Angular Example App](logo.png)

> ### Demo project for integrating Blazor components into an existing Angular app.

&nbsp;

## Motivation

Although Blazor is a great choice for creating web frontends, abolishing an existing
Angular app and starting from scratch is often no option. This project demonstrates, how Blazor
components can be integrated in an existing Angular project, making it possible to migrate
step by step.

## [Live demo](https://xenoage.github.io/BlazorInAngularDemo/)

Visit [this demo](https://xenoage.github.io/BlazorInAngularDemo/) deployed to github pages by our [github CI/CD script](https://github.com/Xenoage/BlazorInAngularDemo/blob/master/.github/workflows/main.yml).

## How to compile and run

In the `src-blazor` folder, there is a Blazor solution with two projects. `dotnet build` the `AngularAdapterBuild` project first, then `dotnet publish` the `BlazorComponents` project. This will
create the Angular-to-Blazor bindings in the Angular project and copy the Blazor runtime into
the `bin-blazor` directory.

In the root folder, there is a usual Angular project. Call `npm install` and `npm start` to run it.

If you want to test the Blazor components on its own, in the `BlazorComponents` project set the `Settings.isTestEnvironment` field to `true` and run the project in Visual Studio 2022. This will
open a browser window, showing the components in a test environment without Angular. 

## Thank you

This demo project is based on the [Angular RealWorld example app](https://github.com/gothinkster/angular-realworld-example-app) by 
[Thinkster](https://thinkster.io). Thank you very much for the useful template.

