using Abp.Dependency;
using Abp.Domain.Services;
using Abp.Events.Bus;
using Awe.Core.Widget.Contracts.Builder;
using Awe.Core.Widget.Contracts.View.MainMenu;
using Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

namespace Awe.Core.Widget.Domain.Builders;

public class MainMenuBuilder : DomainService, IMainMenuBuilder
{
    private readonly IMainMenuView _mainMenuView;
    private readonly IEventDomainService _eventDomainService;
    
    public MainMenuBuilder(IMainMenuView mainMenuView, 
        IEventDomainService eventDomainService)
    {
        _mainMenuView = mainMenuView;
        _eventDomainService = eventDomainService;
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
                        var menuItemGroup = IocManager.Instance.Resolve<IMainMenuItemGroupView>();
                        menuItemGroup.Caption = menuItemInfo.Caption;

                        var menuItems = CreateMenuItems(menuItemInfo.MenuSubItems);
                        menuItemGroup.AddSubItems(menuItems);

                        _mainMenuView.AddItemGroup(menuItemGroup);
                        yield return menuItemGroup;
                        break;
                    case MenuItemType.MenuItem:
                    case MenuItemType.MenuPrintItem:
                        var menuItemButton =  IocManager.Instance.Resolve<IMainMenuItemButtonView>();
                        menuItemButton.Caption = menuItemInfo.Caption;
                    
                        menuItemButton.ItemClick += delegate
                        {
                            _eventDomainService.TriggerEvent(new MenuClickEventData(
                                menuItemInfo.Id,
                                menuItemInfo.Viewer != null
                                    ? menuItemInfo.Viewer.Id
                                    : -1)
                            );

                            EventBus.Default.Trigger(new WidgetEventData());
                        };

                        yield return menuItemButton;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
}