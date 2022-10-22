using System.Globalization;
using _Blazor.Starter.Global.Nav.Model;
using Abp.Dependency;
using Abp.Domain.Services;
using Abp.Extensions;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Contracts.View.Page;

namespace Awe.Platform.Wasm.Domain.Config
{
    public class MasaConfigDomainService : DomainService, IConfigDomainService, ISingletonDependency
    {
        private readonly I18n? _i18N;
        private readonly CookieStorage? _cookieStorage;

        private bool _isDark;
        private PageModes _pageMode = PageModes.PageTab;
        private bool _expandOnHover;
        private bool _navigationMini;
        private string? _favorite;
        private NavModel? _currentNav;

        public MasaConfigDomainService(I18n? i18N, CookieStorage? cookieStorage)
        {
            _i18N = i18N;
            _cookieStorage = cookieStorage;
        }

        //TODO move to appconfig
        public string DefaultRoute => "app/viewer/list";

        public string IsDarkCookieKey { get; set; } = "GlobalConfig_IsDark";
        public string PageModeKey { get; set; } = "GlobalConfig_PageMode";
        public string NavigationMiniCookieKey { get; set; } = "GlobalConfig_NavigationMini";
        public string ExpandOnHoverCookieKey { get; set; } = "GlobalConfig_ExpandOnHover";
        public string FavoriteCookieKey { get; set; } = "GlobalConfig_Favorite";


        public CultureInfo? Culture
        {
            get => _i18N?.Culture;
            set
            {
                if (_i18N is not null)
                {
                    _i18N.SetCulture(value);
                    OnLanguageChanged?.Invoke();
                }
            }
        }

        public bool IsDark
        {
            get => _isDark;
            set
            {
                _isDark = value;
                _cookieStorage?.SetItemAsync(IsDarkCookieKey, value);
            }
        }

        public PageModes PageMode
        {
            get => _pageMode;
            set
            {
                _pageMode = value;
                _cookieStorage?.SetItemAsync(PageModeKey, value);
                OnPageModeChanged?.Invoke();
            }
        }

        public bool NavigationMini
        {
            get => _navigationMini;
            set
            {
                _navigationMini = value;
                _cookieStorage?.SetItemAsync(NavigationMiniCookieKey, value);
            }
        }

        public bool ExpandOnHover
        {
            get => _expandOnHover;
            set
            {
                _expandOnHover = value;
                _cookieStorage?.SetItemAsync(ExpandOnHoverCookieKey, value);
            }
        }

        public string? Favorite
        {
            get => _favorite;
            set
            {
                _favorite = value;
                _cookieStorage?.SetItemAsync(FavoriteCookieKey, value);
            }
        }

        public NavModel? CurrentNav
        {
            get => _currentNav;
            set
            {
                _currentNav = value;
                OnCurrentNavChanged?.Invoke();
            }
        }

        public event Action? OnPageModeChanged;
        public event Action? OnCurrentNavChanged;
        public event Action? OnLanguageChanged;
        public void SetPageMode(StringNumber value)
        {
            PageMode = value.ToString().To<PageModes>();
        }
    }
}
