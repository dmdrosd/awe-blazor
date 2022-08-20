namespace Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

public interface IMainMenuItemGroupView : IMenuItemView
{
    public void AddSubItems(IEnumerable<IMenuItemView> createMenuItems);
}