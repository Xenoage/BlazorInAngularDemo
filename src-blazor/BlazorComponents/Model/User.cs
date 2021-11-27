namespace BlazorComponents.Model;

/// <summary>
/// Comment model copied from Angular project, see user.model.ts
/// </summary>
public record User(
    string email,
    string token,
    string username,
    string bio,
    string image
);
