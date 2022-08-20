using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace Awe.Platform.Wasm.Domain.App
{
    public class TestAuthStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity();
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}