namespace BlazorComponents;

public static class Settings {

    /// <summary>
    /// True, to run the Blazor test environment,
    /// false, to run within the Angular project.
    /// Set to false before calling "dotnet publish"!
    /// </summary>
    public static readonly bool isTestEnvironment = false;

    /// <summary>
    /// In our Angular app, we use "#/" in the path because the
    /// demo is hosted on github pages, which requires the hash based location strategy.
    /// See https://stackoverflow.com/questions/51020295 .
    /// </summary>
    public static string linkPrefix => isTestEnvironment ? "" : "#/";

}
