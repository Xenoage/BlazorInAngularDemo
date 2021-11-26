namespace BlazorComponents.Model;

/// <summary>
/// Profile model copied from Angular project, see profile.model.ts
/// </summary>
public record Profile(
    string username,
    string bio,
    string image,
    bool following
);