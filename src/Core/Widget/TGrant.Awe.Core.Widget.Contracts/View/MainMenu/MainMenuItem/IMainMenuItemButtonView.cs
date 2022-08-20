namespace TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

public interface IMainMenuItemButtonView : IMenuItemView
{
    event System.Action ItemClick;
}