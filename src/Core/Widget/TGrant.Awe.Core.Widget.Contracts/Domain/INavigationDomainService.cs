using _Blazor.Starter.Global.Nav.Model;
using BlazorComponent;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.Navigation;

public interface INavigationDomainService
{
    List<NavModel> Navs { get; }
    List<NavModel> SameLevelNavs { get; }
    
    //TODO remove masa reference
    List<PageTabItem> PageTabItems { get; }
    void NavigateTo(NavModel nav);
    void NavigateTo(string href);
    void RefreshRender(NavModel nav);
    void NavigateToByEvent(NavModel nav);
    void Active(NavModel nav);
}