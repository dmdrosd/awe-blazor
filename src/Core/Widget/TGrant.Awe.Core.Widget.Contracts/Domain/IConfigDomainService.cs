using System.Globalization;
using _Blazor.Starter.Global.Nav.Model;
using BlazorComponent;
using TGrant.Awe.Core.Widget.Contracts.View.Page;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.Config;

public interface IConfigDomainService
{
    string IsDarkCookieKey { get; set; }
    string PageModeKey { get; set; }
    string NavigationMiniCookieKey { get; set; }
    string ExpandOnHoverCookieKey { get; set; }
    string FavoriteCookieKey { get; set; }
    CultureInfo? Culture { get; set; }
    bool IsDark { get; set; }
    PageModes PageMode { get; set; }
    bool NavigationMini { get; set; }
    bool ExpandOnHover { get; set; }
    string? Favorite { get; set; }
    NavModel? CurrentNav { get; set; }
    string DefaultRoute { get; }

    //TODO move to another
    event Action? OnPageModeChanged;
    event Action? OnCurrentNavChanged;
    event Action? OnLanguageChanged;
    void SetPageMode(StringNumber value);
}