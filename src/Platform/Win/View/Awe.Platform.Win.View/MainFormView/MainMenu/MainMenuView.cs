using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Dependency;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using TGrant.Awe.Core.Widget.Contracts.View.MainMenu;

namespace Awe.Platform.Win.View.MainFormView.MainMenu;

public class MainMenuView : IMainMenuView, ISingletonDependency
{
    private readonly RibbonControl _mainMenu;

    public MainMenuView(RibbonControl mainMenu)
    {
        _mainMenu = mainMenu;
    }

    public void BeginUpdate()
    {
        //_mainMenu.BeginUpdate();
    }

    public void AddItems(IEnumerable<IMenuItemView> menuItems)
    {
        foreach (var cMenuItem in menuItems)
        {
            //switch (cMenuItem.InnerItem)
            //{
            //    case BarSubItem item:
            //        _mainMenu.AddItem(item);
            //        break;
            //    case BarButtonItem barButtonItem:
            //        _mainMenu.AddItem(barButtonItem);
            //        break;
            //    default:
            //        throw new NotSupportedException(cMenuItem.Caption);
            //}
        }
    }

    public void EndUpdate()
    {
        //_mainMenu.EndUpdate();
    }

    public void ClearMenu()
    {
        //_mainMenu.BeginUpdate();
        //_mainMenu.ClearLinks();
        //_mainMenu.EndUpdate();
    }

    public void AddItemGroup(IMainMenuItemGroupView menuItemGroup)
    {
        var menuPage = _mainMenu.Pages.FirstOrDefault();

        if (menuPage == null)
        {
            throw new ArgumentOutOfRangeException();
        }

        menuPage.Groups.Add((RibbonPageGroup)menuItemGroup.InnerItem);
    }

    public string Caption { get; set; }
}