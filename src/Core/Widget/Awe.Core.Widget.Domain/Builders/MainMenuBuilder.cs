using Awe.Core.Widget.Contracts.Builder;
using Awe.Core.Widget.Contracts.View.MainMenu;
using Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;
using Volo.Abp.EventBus.Local;

namespace Awe.Core.Widget.Domain.Builders;

public class MainMenuBuilder : DomainService, IMainMenuBuilder, ISingletonDependency
{
    private readonly IMainMenuView _mainMenuView;
    private readonly IEventDomainService _eventDomainService;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILocalEventBus _eventBus;

    public MainMenuBuilder(IMainMenuView mainMenuView, 
        IEventDomainService eventDomainService, IServiceProvider serviceProvider)
    {
        _mainMenuView = mainMenuView;

        _eventDomainService = eventDomainService;
        _serviceProvider = serviceProvider;
        _eventBus = NullLocalEventBus.Instance;
    }

    public void Build(IEnumerable<MenuItemInfo> menuItemInfos)
    {
        _mainMenuView.BeginUpdate();
            
        var cMenuItems = CreateMenuItems(menuItemInfos);

        _mainMenuView.AddItems(cMenuItems);

        _mainMenuView.EndUpdate();
    }
    
    private IEnumerable<IMenuItemView> CreateMenuItems(IEnumerable<MenuItemInfo> viewerChildMenus)
        {
            foreach (var menuItemInfo in viewerChildMenus)
            {
                switch (menuItemInfo.MenuItemType)
                {
                    case MenuItemType.MenuSeparator :
                        break;
                case MenuItemType.MenuGroup :
                        var menuItemGroup = _serviceProvider.GetService<IMainMenuItemGroupView>();
                        menuItemGroup.Caption = menuItemInfo.Caption;

                        var menuItems = CreateMenuItems(menuItemInfo.MenuSubItems);
                        menuItemGroup.AddSubItems(menuItems);

                        _mainMenuView.AddItemGroup(menuItemGroup);
                        yield return menuItemGroup;
                        break;
                    case MenuItemType.MenuItem:
                    case MenuItemType.MenuPrintItem:
                        var menuItemButton = _serviceProvider.GetService<IMainMenuItemButtonView>();
                        menuItemButton.Caption = menuItemInfo.Caption;
                    
                        menuItemButton.ItemClick += delegate
                        {
                            _eventDomainService.TriggerEvent(new MenuClickEventData(
                                menuItemInfo.Id,
                                menuItemInfo.Viewer != null
                                    ? menuItemInfo.Viewer.Id
                                    : -1)
                            );

                            _eventBus.PublishAsync(new WidgetEventData());
                        };

                        yield return menuItemButton;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
}