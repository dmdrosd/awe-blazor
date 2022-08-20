namespace TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;

public interface IMenuItemView : IView
{
    bool IsSeparator { get;}
    object InnerItem { get; }
}