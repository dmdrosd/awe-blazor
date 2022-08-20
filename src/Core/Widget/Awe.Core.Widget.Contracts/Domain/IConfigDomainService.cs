using System.Globalization;
using _Blazor.Starter.Global.Nav.Model;
using Awe.Core.Widget.Contracts.View.Page;
using BlazorComponent;

namespace Awe.Core.Widget.Contracts.Domain;

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
    event System.Action? OnPageModeChanged;
    event System.Action? OnCurrentNavChanged;
    event System.Action? OnLanguageChanged;
    void SetPageMode(StringNumber value);
}