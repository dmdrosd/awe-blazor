using Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

namespace Awe.Core.Widget.Contracts.View.MainMenu;

public interface IMainMenuView : IView
{
    void BeginUpdate();
    void AddItems(IEnumerable<IMenuItemView> menuItems);
    void EndUpdate();
    void ClearMenu();
    void AddItemGroup(IMainMenuItemGroupView menuItemGroup);
}
