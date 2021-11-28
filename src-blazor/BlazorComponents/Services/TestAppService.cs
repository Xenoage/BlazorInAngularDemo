using BlazorComponents.Model;

namespace BlazorComponents.Services;

/// <summary>
/// Blazor test environment implementation of <see cref="IAppService"/>.
/// </summary>
public class TestAppService : IAppService {

    private readonly User loggedInUser = new("user@xenoage.com", "abcdefg", "User0", "born 1984", "icon-32.png");

    public Task<User?> GetCurrentUser() =>
        Task.FromResult<User?>(loggedInUser);

}
