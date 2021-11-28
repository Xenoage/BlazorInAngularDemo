using BlazorComponents.Model;
using Microsoft.JSInterop;

namespace BlazorComponents.Services;

/// <summary>
/// Angular (= real) implementation of <see cref="IAppService"/>.
/// </summary>
public class AngularAppService : IAppService {

    private IJSRuntime js;

    public AngularAppService(IJSRuntime js) {
        this.js = js;
    }

    public async Task<User?> GetCurrentUser() =>
        await CallBlazorBridge<User?>("getCurrentUser");

    private async Task<T> CallBlazorBridge<T>(string methodName) =>
        await js.InvokeAsync<T>($"window.BlazorBridge.{methodName}");

}
