using _Blazor.Starter.Global.Nav.Model;
using Abp;
using Abp.Domain.Services;
using Awe.Core.Widget.Contracts.Domain;
using Microsoft.AspNetCore.Components;

namespace Awe.Platform.Wasm.Domain.Navigation
{
    public class MasaNavigationDomainService : DomainService, INavigationDomainService, IShouldInitialize
    {
        private readonly NavigationManager _navigationManager;
        private readonly IConfigDomainService _globalConfig;

        public MasaNavigationDomainService(NavigationManager navigationManager, IConfigDomainService globalConfig)
        {
            _navigationManager = navigationManager;
            _globalConfig = globalConfig;
            Initialization();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public List<NavModel> Navs { get; } = new();

        public List<NavModel> SameLevelNavs { get; } = new();

        public List<PageTabItem> PageTabItems { get; } = new();
        
        
        public void NavigateTo(NavModel nav)
        {
            Active(nav);
            _navigationManager.NavigateTo(nav.Href ?? "");
        }

        public void NavigateTo(string href)
        {
            var nav = SameLevelNavs.FirstOrDefault(n => n.Href == href);
            if (nav is not null) Active(nav);
            _navigationManager.NavigateTo(href);
        }

        public void RefreshRender(NavModel nav)
        {
            Active(nav);
            _globalConfig.CurrentNav = nav;
        }

        public void NavigateToByEvent(NavModel nav)
        {
            RefreshRender(nav);
            _navigationManager.NavigateTo(nav.Href ?? "");
        }

        public void Active(NavModel nav)
        {
            SameLevelNavs.ForEach(n => n.Active = false);
            nav.Active = true;
            if (nav.ParentId != 0) SameLevelNavs.First(n => n.Id == nav.ParentId).Active = true;
        }

        private void Initialization()
        {
            //TODO
            List<NavModel> _navList = NavLoader.LoadItems();
            
            _navList.ForEach(nav =>
            {
                if (nav.Hide is false)
                {
                    Navs.Add(nav);
                }

                if (nav.Children is null) return;

                nav.Children = nav.Children.Where(c => c.Hide is false).ToArray();

                nav.Children.ForEachNav(child =>
                {
                    child.ParentId = nav.Id;
                    child.FullTitle = $"{nav.Title} {child.Title}";
                    child.ParentIcon = nav.Icon;
                });
            });

            Navs.ForEach(nav =>
            {
                SameLevelNavs.Add(nav);
                if (nav.Children is not null) SameLevelNavs.AddRange(nav.Children);
            });

            SameLevelNavs.Where(nav => nav.Href is not null).ForEachNav(nav =>
            {
                PageTabItems.Add(new PageTabItem(nav.Title, nav.Href, nav.ParentIcon, PageTabsMatch.Prefix, nav.Target == "Self" ? PageTabsTarget.Self : PageTabsTarget.Blank));
            });
        }
    }
}
