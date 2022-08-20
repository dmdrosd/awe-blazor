using Abp.Domain.Services;
using Awe.Contracts.Settings.Enums.Menu;
using Awe.Contracts.Settings.Menu;
using Awe.Contracts.Settings.ViewerBuild;
using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Contracts.Builder;

namespace Awe.Platform.Win.Domain.MainForm;

public class MainMenuWinDomainService : DomainService, IMainMenuDomainService
{
    private readonly IMainMenuBuilder _mainMenuBuilder;
    
    private static readonly MenuItemInfo[] _mockMenuItemInfos = 
    {
            new()
            {
                Caption = "Администрирование",
                MenuItemType = MenuItemType.MenuGroup,
                MenuSubItems = new MenuItemInfo[]
                {
                    new()
                    {
                        Caption = "Вьюверы",
                        Viewer = new ViewerInfo { Id = 100500 },
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        Caption = "Свойства Вьюверов",
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        MenuItemType = MenuItemType.MenuSeparator
                    },
                    new()
                    {
                        Caption = "Переходы",
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        Caption = "Печать",
                        MenuItemType = MenuItemType.MenuPrintItem
                    },
                }
            },
            new()
            {
                Caption = "Это другое",
                MenuItemType = MenuItemType.MenuGroup,
                MenuSubItems = new MenuItemInfo[]
                {
                    new()
                    {
                        Caption = "Вьюверы",
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        Caption = "Свойства Вьюверов",
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        MenuItemType = MenuItemType.MenuSeparator
                    },
                    new()
                    {
                        Caption = "Переходы",
                        MenuItemType = MenuItemType.MenuItem
                    },
                    new()
                    {
                        Caption = "Печать",
                        MenuItemType = MenuItemType.MenuPrintItem
                    },
                }
            }
        };

    public MainMenuWinDomainService(IMainMenuBuilder mainMenuBuilder)
    {
        _mainMenuBuilder = mainMenuBuilder;
    }
    
    public void Build()
    {
        var menuItemInfos = _mockMenuItemInfos; //_settingsAppService.LoadMainMenu(userId);

        _mainMenuBuilder.Build(menuItemInfos);
    }
}
    
    