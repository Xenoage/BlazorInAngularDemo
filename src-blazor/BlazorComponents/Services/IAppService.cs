using BlazorComponents.Model;

namespace BlazorComponents.Services;

/// <summary>
/// Angular service methods called by our Blazor components.
/// </summary>
public interface IAppService {

    /// <summary>
    /// Gets the currently logged-in user, if any.
    /// </summary>
    public Task<User?> GetCurrentUser();

}
