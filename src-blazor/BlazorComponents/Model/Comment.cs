namespace BlazorComponents.Model;

/// <summary>
/// Comment model copied from Angular project, see comment.model.ts
/// </summary>
public record Comment(
    int id,
    string body,
    string createdAt,
    Profile author
) {
    public static Comment Empty() => new(-1, "", DateTime.UtcNow.ToString("O"), Profile.Empty());
}
